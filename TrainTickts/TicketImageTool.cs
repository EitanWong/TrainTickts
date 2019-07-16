using System.IO;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QRCoder;

namespace TicketsBase
{
    public static class TicketImageTool
    {
        public static int test = 100;
        public static Brush whiteBrush = new SolidBrush(Color.White);
        public static Brush blackBrush = new SolidBrush(Color.FromArgb(235, 0, 0, 0));
        public static Brush RedBrush = new SolidBrush(Color.FromArgb(180, 255, 0, 0));
        public static Brush Aalpha = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
        public static Bitmap img_tailor(Bitmap src, Rectangle range)
        {
            return src.Clone(range, PixelFormat.DontCare);
        }
        public static Image byteToImage(byte[] myByte)
        {
            MemoryStream ms = new MemoryStream(myByte);
            Image _Image = Image.FromStream(ms);
            return _Image;
        }
        /// <summary>
        /// 识别车票
        /// </summary>


        public static byte[] Bitmap2Byte(Bitmap bitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Jpeg);
                byte[] data = new byte[stream.Length];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(data, 0, Convert.ToInt32(stream.Length));
                return data;
            }
        }
        //将image转换成byte[]数据
        public static byte[] imageToByte(Image _image)
        {
            MemoryStream ms = new MemoryStream();
            _image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        /// <summary>
        /// 按指定尺寸对图像pic进行非拉伸缩放
        /// </summary>
        public static Bitmap shrinkTo(Image pic, Size S, Boolean cutting)
        {
            //创建图像
            Bitmap tmp = new Bitmap(S.Width, S.Height);     //按指定大小创建位图

            //绘制
            Graphics g = Graphics.FromImage(tmp);           //从位图创建Graphics对象
            g.Clear(Color.FromArgb(0, 0, 0, 0));            //清空

            Boolean mode = (float)pic.Width / S.Width > (float)pic.Height / S.Height;   //zoom缩放
            if (cutting) mode = !mode;                      //裁切缩放

            //计算Zoom绘制区域             
            if (mode)
                S.Height = (int)((float)pic.Height * S.Width / pic.Width);
            else
                S.Width = (int)((float)pic.Width * S.Height / pic.Height);
            Point P = new Point((tmp.Width - S.Width) / 2, (tmp.Height - S.Height) / 2);

            g.DrawImage(pic, new Rectangle(P, S));

            return tmp;     //返回构建的新图像
        }

        public static List<Image> LoadAllTrainTicketsImage()
        {

            var path = TrainTicket.LoudTicketsPath;
            if (!Directory.Exists(path))//判断是否不存在
            {
                Directory.CreateDirectory(path);//创建新路径
            }
            //if (string.IsNullOrEmpty(text))
            // return;
            var images = Directory.GetFiles(path);
            if (images.Length <= 0)
            {
                MessageBox.Show("原始车票模为空:" + TrainTicket.LoudTicketsPath + "\n" + "请放入您要识别的原始车票", "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(TrainTicket.LoudTicketsPath);
                return null;
            }
            List<Image> TrainTickets_image = new List<Image>();
            foreach (var item in images)
            {
                Console.WriteLine(item);
                TrainTickets_image.Add(Image.FromFile(item));
            }
            return TrainTickets_image;

        }
        public static List<Image> LoadAllBaseTrainTicketsImage()
        {

            var path = TrainTicket.BaseTickfilePath;
            if (!Directory.Exists(path))//判断是否不存在
            {
                Directory.CreateDirectory(path);//创建新路径
            }
            //if (string.IsNullOrEmpty(text))
            // return;
            var images = Directory.GetFiles(path);
            if (images.Length <= 0)
            {
                MessageBox.Show("车票模板为空:" + TrainTicket.BaseTickfilePath + "\n" + "请检查是否含有车票模板", "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(TrainTicket.BaseTickfilePath);
                return null;
            }
            List<Image> TrainTickets_image = new List<Image>();
            foreach (var item in images)
            {
                Console.WriteLine(item);
                TrainTickets_image.Add(Image.FromFile(item));
            }
            return TrainTickets_image;

        }
        /// <summary>
        /// 添加车票信息到图片并存放
        /// </summary>
        /// <param name="tickInfo"></param>
        public static Image MakeTrainTickImage(TrainTicketInfo tickInfo)
        {
            if (tickInfo.logid == null)
                return null;

            if (TrainTicket.BaseTicketImage == null)
            {
                try
                {
                    TicketImageTool.LoadAllBaseTrainTicketsImage();
                }
                catch
                {
                    MessageBox.Show("车票模板为空:" + TrainTicket.BaseTickfilePath + "\n" + "请检查是否含有车票模板", "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Diagnostics.Process.Start(TrainTicket.BaseTickfilePath);
                }
                return null;
            }
            var ticketnumber = new Random().Next(0, TrainTicket.BaseTicketImage.Count);
            var image = TrainTicket.BaseTicketImage[ticketnumber];
            //Console.WriteLine(image.Width + " " + image.Height);
            Bitmap bitmap = new Bitmap(image, image.Width, image.Height);

            Graphics g = Graphics.FromImage(bitmap);

            //cutImage(image, new Point(136,69),50,30);



            //字体矩形位置 ：
            //x = 图片的长度的中心位置 - 字体长度的一半 - 字行距
            //y = 图片的高度的中心位置 - 字体大小的一半 - 偏移（去掉偏移，是居中位置）
            string year = null;
            if (tickInfo.date.Length >= 4)
            {
                year = tickInfo.date[0].ToString() + tickInfo.date[1].ToString() + tickInfo.date[2].ToString() + tickInfo.date[3].ToString();//年
            }

            string moth = null;
            if (tickInfo.date.Length >= 7)
            {
                moth = tickInfo.date[5].ToString() + tickInfo.date[6].ToString();//月
            }

            string day = null;
            if (tickInfo.date.Length >= 10)
            {
                day = tickInfo.date[8].ToString() + tickInfo.date[9].ToString();//日
            }
            string fickrates = null;
            if (tickInfo.ticket_rates.Contains("￥"))
            {
                fickrates = tickInfo.ticket_rates.Replace("￥", string.Empty);
            }

            string Rates = null;
            if (fickrates != null && fickrates.Contains("元"))
            {
                Rates = fickrates.Replace("元", string.Empty);
            }

            string Start_Station = null;
            string Start_Stationpinyin = null;
            if (!String.IsNullOrWhiteSpace(tickInfo.starting_station))
            {
                Start_Station = tickInfo.starting_station.Remove(tickInfo.starting_station.Length - 1);
                Start_Stationpinyin = PingYinHelper.GetPinyin(tickInfo.starting_station.Remove(tickInfo.starting_station.Length - 1));
            }


            string destination_Station = null;
            string Des_Stationpinyin = null;
            if (!String.IsNullOrWhiteSpace(tickInfo.destination_station))
            {
                destination_Station = tickInfo.destination_station.Remove(tickInfo.destination_station.Length - 1);
                Des_Stationpinyin = PingYinHelper.GetPinyin(tickInfo.destination_station.Remove(tickInfo.destination_station.Length - 1));
            }


            string S_station = null;
            string D_station = null;


            int S_pinyinaddX = 0;
            int D_pinyinaddX = 0;
            int max_pinyinmove_length = 9;
            bool D_ISLongPinyin = false;
            bool S_ISLongPinyin = false;
            if (Start_Stationpinyin != null && Start_Stationpinyin.Length <= max_pinyinmove_length)
            {
                S_pinyinaddX = 42 - Start_Stationpinyin.Length;
            }
            else {
                S_ISLongPinyin = true;
            }
            if (Des_Stationpinyin != null && Des_Stationpinyin.Length <= max_pinyinmove_length)
            {
                D_pinyinaddX = 42 - Des_Stationpinyin.Length;
            }
            else
            {
                D_ISLongPinyin = true;
            }

            if (Start_Station != null && Start_Station.Length <= 2)
            {
                S_station += Start_Station[0];
                S_station += "  ";
                S_station += Start_Station[1];
            }
            else
            {
                S_station = Start_Station;

            }
            if (destination_Station != null && destination_Station.Length <= 2)
            {
                D_station += destination_Station[0];
                D_station += "  ";
                D_station += destination_Station[1];
            }
            else
            {
                D_station = destination_Station;
            }
            string IDinfo = null;
            char addidinfo;
            for (int i = 0; i < tickInfo.ID.Length; i++)
            {
                if (i >= 10 && i <= 13)
                {
                    addidinfo = '*';
                }
                else
                {
                    addidinfo = tickInfo.ID[i];
                }
                IDinfo += addidinfo;
            }

            var reduce = new Random().Next(0, 20);

            AddInfoToImage(tickInfo.ticket_num, g, 40, "arial.ttf", 50, 35 - reduce, RedBrush, FontStyle.Bold);
            AddInfoToImage(tickInfo.jianpiao, g, 32, 680, 20, blackBrush);
            AddInfoToImage(S_station, g, 41, 110, 80, blackBrush);
            if (Start_Stationpinyin != null)
            {
                if (S_ISLongPinyin)
                {
                    AddInfoToImage(Start_Stationpinyin, g, 30, "标准仿宋体简.ttf", 110 + Start_Stationpinyin.Length + S_pinyinaddX, 140, blackBrush,FontStyle.Regular, 0.8f, 1);
                }
                else
                {
                    AddInfoToImage(Start_Stationpinyin, g, 30, "标准仿宋体简.ttf", 110 + Start_Stationpinyin.Length + S_pinyinaddX, 140, blackBrush);
                }
            }
            AddInfoToImage("站", g, 30, 290, 90, blackBrush);
            AddInfoToImage(D_station, g, 41, 600, 80, blackBrush);
            if (Des_Stationpinyin != null)
            {
                if (D_ISLongPinyin)
                {
                    AddInfoToImage(Des_Stationpinyin, g, 30, "标准仿宋体简.ttf", 600 + Des_Stationpinyin.Length + D_pinyinaddX, 140, blackBrush,FontStyle.Regular, 0.8f, 1);
                }
                else
                {
                    AddInfoToImage(Des_Stationpinyin, g, 30, "标准仿宋体简.ttf", 600 + Des_Stationpinyin.Length + D_pinyinaddX, 140, blackBrush);
                }
            }


            AddInfoToImage("站", g, 30, 780, 90, blackBrush);
            ////////////////////////////////////////////////

            if (tickInfo.train_num.Length < 4)
            {
                AddInfoToImage(tickInfo.train_num, g, 40, "车次.ttf", 400 + 20 - tickInfo.train_num.Length, 80, blackBrush);
            }
            else if (tickInfo.train_num.Length == 4)
            {
                AddInfoToImage(tickInfo.train_num, g, 40, "车次.ttf", 408, 80, blackBrush);
            }
            else if (tickInfo.train_num.Length == 5)
            {
                AddInfoToImage(tickInfo.train_num, g, 40, "车次.ttf", 392, 80, blackBrush);
            }

            /////////////////////////////////////////////////////////////////
            AddInfoToImage(tickInfo.train_che, g, 32, "TechnicBold.ttf", 587, 182, blackBrush);
            AddInfoToImage("车", g, 20, 637, 195, blackBrush);
            AddInfoToImage(tickInfo.train_hao, g, 32, "TechnicBold.ttf", 660, 182, blackBrush);
            AddInfoToImage("号", g, 20, 732, 195, blackBrush);
            //AddInfoToImage("限乘当日当次车", g, 9, 20, 110, blackBrush);
            //////////////////////////////////////////////////
            AddInfoToImage("网", g, 27, 400, 242, blackBrush);
            AddInfoToImage(tickInfo.seat_category, g, 25, 642, 240, blackBrush);
            AddInfoToImage(year, g, 34, "TechnicBold.ttf", 79, 182, blackBrush,FontStyle.Regular);
            AddInfoToImage("年", g, 20, 170, 195, blackBrush);
            AddInfoToImage(moth, g, 34, "TechnicBold.ttf", 200, 182, blackBrush,FontStyle.Regular);
            AddInfoToImage("月", g, 20, 255, 195, blackBrush);
            AddInfoToImage(day, g, 34, "TechnicBold.ttf", 285, 182, blackBrush, FontStyle.Regular);
            AddInfoToImage("日", g, 20, 337, 195, blackBrush);
            AddInfoToImage(tickInfo.train_starttime, g, 34, "TechnicBold.ttf", 376, 182, blackBrush,FontStyle.Bold);
            AddInfoToImage("开", g, 20, 480, 195, blackBrush);
            //AddInfoToImage("￥", g, 31, "华文宋体.ttf", 80, 240, blackBrush);
            AddInfoToImage(Rates, g, 33, "TechnicBold.ttf", 119, 240, blackBrush);
            int yuan_X = 0;
            if (Rates != null && Rates.Length > 4)
            {
                yuan_X += 25;
            }
            AddInfoToImage("元", g, 20, 205 + yuan_X, 250, blackBrush);
            // AddInfoToImage(tickInfo.ticket_num, g, 13, 20, 9, RedBrush);
            AddInfoToImage(tickInfo.name, g, 31, 460f, 397f, blackBrush);
            AddInfoToImage(IDinfo, g, 33.5f, "TechnicBoldshort.ttf", 78f, 397f, blackBrush);
            //AddInfoToImage(tickInfo.bottomid, g, 25f, 80f, 560f, blackBrush,FontStyle.Bold,1f,2f);
            AddInfoToImage(tickInfo.bottomid, g, 20f, "仿宋_GB2312.ttf", 90f, 560f, blackBrush, FontStyle.Regular, 1.147f, 1.6f);
            AddInfoToImage(Start_Station, g, 27f, 440f, 560f, blackBrush, FontStyle.Bold);
            int Shou_X = 0;
            if (Start_Station != null && Start_Station.Length <= 2)
            {
                Shou_X -= 38;
            }
            AddInfoToImage("售", g, 27f, 550f + Shou_X, 560f, blackBrush, FontStyle.Bold);

            string strCode =string.Format("网络异常\n车票读取信息为{0}\n{1}\n{2}→{3}\n{4}年{5}月{6}日{7}\n{8}车{9}号\n{10}", tickInfo.ticket_num,tickInfo.train_num,S_station,D_station,year,moth,day,tickInfo.train_starttime,tickInfo.train_che,tickInfo.train_hao,tickInfo.name);
           // string strCode = "https://www.12306.cn/index/";
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);

            // qrcode.GetGraphic 方法可参考最下发“补充说明”
            Bitmap qrCodeImage = qrcode.GetGraphic(3, Color.FromArgb(160,0,0,0), Color.FromArgb(0, 0, 0, 0), null, 16, 6, false);

            AddImageToImage(g,ResizeImage(qrCodeImage, qrCodeImage.Width-12, qrCodeImage.Height), new Point(735, 377));
            var FinalImage = byteToImage(Bitmap2Byte(bitmap));
            //"售"
            //bitmap.Save(TrainTicket.savePath + tickInfo.GetHashCode() + ".jpg", ImageFormat.Jpeg);
            //TrainTicket.TrainTicketImages.Add(byteToImage(Bitmap2Byte(bitmap)));
            g.Dispose();
            bitmap.Dispose();
            //image.Dispose();
            return FinalImage;
        }

        public static Letter GetRandomLetter()
        {
            return (Letter)(new Random().Next(0, 25));
        }


        public static Bitmap ResizeImage(Bitmap bmp, int newW, int newH)
        {
            try
            {
                Bitmap b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);
                // 插值算法的质量   
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 添加信息到图片
        /// </summary>
        /// <param name="Info">信息</param>
        /// <param name="Image_graphics">图片画板</param>
        /// <param name="fontSize">字体大小</param>
        /// <param name="rectX">X位置</param>
        /// <param name="rectY">Y位置</param>
        /// <param name="brush">笔刷颜色</param>
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, float rectX, float rectY, Brush brush)
        {
            // var path = AppDomain.CurrentDomain.BaseDirectory + "Font.ttf";
            //PrivateFontCollection fontc = new PrivateFontCollection();
            //fontc.AddFontFile(path);
            if (Info == null)
                return;

            // FontFamily myFontFamily = new FontFamily(fontc.Families[0].Name, fontc);
            //float textWidth = Info.Length * fontSize;
            Font font = new Font("黑体", fontSize, FontStyle.Regular);

            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素
            float rectHeight = (fontSize / 72) * 96;
            //绘制区域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

            Image_graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);

            Image_graphics.DrawString(Info, font, brush, textArea);

        }
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, string fontstyleName, float rectX, float rectY, Brush brush)
        {
            if (Info == null)
                return;
            var path = AppDomain.CurrentDomain.BaseDirectory + "Font\\" + fontstyleName;
            PrivateFontCollection fontc = new PrivateFontCollection();
            Font font;
            try
            {
                fontc.AddFontFile(path);
                font = new Font(fontc.Families[0], fontSize, FontStyle.Regular);
            }
            catch
            {
                font = new Font("黑体", fontSize, FontStyle.Regular);

            }

            // FontFamily myFontFamily = new FontFamily(fontc.Families[0].Name, fontc);
            //float textWidth = Info.Length * fontSize;


            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素
            float rectHeight = (fontSize / 72) * 96;
            //绘制区域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

            Image_graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);

            Image_graphics.DrawString(Info, font, brush, textArea);

        }
        /// <summary>
        /// 添加信息到图片
        /// </summary>
        /// <param name="Info">信息</param>
        /// <param name="Image_graphics">图片画板</param>
        /// <param name="fontSize">字体大小</param>
        /// <param name="rectX">X位置</param>
        /// <param name="rectY">Y位置</param>
        /// <param name="brush">笔刷颜色</param>
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, float rectX, float rectY, Brush brush, FontStyle fontStyle)
        {
            if (Info == null)
                return;
            //float textWidth = Info.Length * fontSize;
            Font font = new Font("黑体", fontSize, fontStyle);
            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素


            float rectHeight = (fontSize / 72) * 96;
            //绘制区域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

            Image_graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);

            Image_graphics.DrawString(Info, font, brush, textArea);

        }
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, string fontstyleName, float rectX, float rectY, Brush brush, FontStyle fontStyle)
        {
            if (Info == null)
                return;
            var path = AppDomain.CurrentDomain.BaseDirectory + "Font\\" + fontstyleName;
            PrivateFontCollection fontc = new PrivateFontCollection();
            Font font;
            try
            {
                fontc.AddFontFile(path);
                font = new Font(fontc.Families[0], fontSize, FontStyle.Regular);
            }
            catch
            {
                font = new Font("黑体", fontSize, FontStyle.Regular);

            }
            //float textWidth = Info.Length * fontSize;
            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素

            float rectHeight = (fontSize / 72) * 96;
            //绘制区域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

            Image_graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);

            Image_graphics.DrawString(Info, font, brush, textArea);

        }
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, float rectX, float rectY, Brush brush, FontStyle fontStyle, float Scalex, float Scaley)
        {
            if (Info == null)
                return;
            //float textWidth = Info.Length * fontSize;
            Font font = new Font("黑体", fontSize, fontStyle);
            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素

            //e.Graphics.DrawString("宋体!10号", new Font("宋体", 10f), Brushes.Black, new PointF(10f, 10f));

            float rectHeight = (fontSize / 72) * 96;
            // RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
            Matrix matrix = new Matrix();
            matrix.Scale(Scalex, Scaley, MatrixOrder.Prepend);

            //绘制区域
            Bitmap TextImage = new Bitmap(Convert.ToInt32(rectWidth * Scalex), Convert.ToInt32(rectHeight * Scaley));
            Graphics graphics = Graphics.FromImage(TextImage);
            graphics.Transform = matrix;
            graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);
            graphics.DrawString(Info, font, brush, new PointF(0, 0));
            //TextImage.Save(TrainTicket.savePath + "test.jpg");
            Image_graphics.DrawImage(TextImage, new PointF(rectX, rectY));
            //Image_graphics.DrawString(Info, font, brush, textArea);

        }
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize,string fontstyleName, float rectX, float rectY, Brush brush, FontStyle fontStyle, float Scalex, float Scaley)
        {
            if (Info == null)
                return;
            var path = AppDomain.CurrentDomain.BaseDirectory + "Font\\" + fontstyleName;
            PrivateFontCollection fontc = new PrivateFontCollection();
            Font font;
            try
            {
                fontc.AddFontFile(path);
                font = new Font(fontc.Families[0], fontSize, FontStyle.Regular);
            }
            catch
            {
                font = new Font("黑体", fontSize, FontStyle.Regular);

            }
            //float textWidth = Info.Length * fontSize;
            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素

            //e.Graphics.DrawString("宋体!10号", new Font("宋体", 10f), Brushes.Black, new PointF(10f, 10f));

            float rectHeight = (fontSize / 72) * 96;
            // RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
            Matrix matrix = new Matrix();
            matrix.Scale(Scalex, Scaley, MatrixOrder.Prepend);

            //绘制区域
            Bitmap TextImage = new Bitmap(Convert.ToInt32(rectWidth * Scalex), Convert.ToInt32(rectHeight * Scaley));
            Graphics graphics = Graphics.FromImage(TextImage);
            graphics.Transform = matrix;
            graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);
            graphics.DrawString(Info, font, brush, new PointF(0, 0));
            //TextImage.Save(TrainTicket.savePath + "test.jpg");
            Image_graphics.DrawImage(TextImage, new PointF(rectX, rectY));
            //Image_graphics.DrawString(Info, font, brush, textArea);

        }
        static void AddInfoToImage(string Info, Graphics Image_graphics, float fontSize, float rectX, float rectY, Brush brush, float Scalex, float Scaley)
        {
            if (String.IsNullOrWhiteSpace(Info))
                return;
            //float textWidth = Info.Length * fontSize;
            Font font = new Font("黑体", fontSize, FontStyle.Regular);
            float rectWidth = Info.Length * fontSize + font.Height * 3.14f;
            //英文字体的1磅，相当于1/72 
            //英寸常用的1024x768或800x600等标准的分辨率计算出来的dpi是一个常数：96
            //因此计算出来的毫米与像素的关系也约等于一个常数： 基本上 1毫米 约等于 3.78像素

            //e.Graphics.DrawString("宋体!10号", new Font("宋体", 10f), Brushes.Black, new PointF(10f, 10f));

            float rectHeight = (fontSize / 72) * 96;
            // RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
            Matrix matrix = new Matrix();
            matrix.Scale(Scalex, Scaley, MatrixOrder.Prepend);

            //绘制区域
            Bitmap TextImage = new Bitmap(Convert.ToInt32(rectWidth * Scalex), Convert.ToInt32(rectHeight * Scaley));
            Graphics graphics = Graphics.FromImage(TextImage);
            graphics.Transform = matrix;
            graphics.FillRectangle(Aalpha, rectX, rectY, rectWidth, rectHeight);
            graphics.DrawString(Info, font, brush, new PointF(0, 0));
            //TextImage.Save(TrainTicket.savePath + "test.jpg");
            Image_graphics.DrawImage(TextImage, new PointF(rectX, rectY));
            //Image_graphics.DrawString(Info, font, brush, textArea);

        }

        static void AddImageToImage(Graphics Image_graphics,Image image,Point point)
        {
            Image_graphics.DrawImage(image, point);
        }
        static void AddImageToImage(Graphics Image_graphics, Bitmap image, Point point)
        {
            Image_graphics.DrawImage(image, point);
        }
    }
}
