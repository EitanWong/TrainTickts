using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsBase;
using TrainTickts;

namespace TrainTickets
{
    public partial class TrainTicketMainForm : Form
    {
        public static TrainTicketMainForm _S;
        Setting Form_Setting = new Setting();
        AboutBox Form_AboutBox = new AboutBox();
        public  AreYouKidMe Form_AreYouKidMe = new AreYouKidMe();
        const int OrinWidth=350;
        int OpenWidth;
        public TrainTicketMainForm()
        {
            InitializeComponent();
            _S = this;
        }

        TrainTicketInfo NowSlectTickets;
        private bool ISOpen;

        private void TrainTicketMainForm_Load(object sender, EventArgs e)
        {

            var APP_ID = "16672550";
            var API_KEY = "lNls0VC4YjB4LocNTDGB9jn0";
            var SECRET_KEY = "OoGRDa7sYsM6qjOwGEDvx7r7mWBLPsG0";
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            // PhotoName = Console.ReadLine();
            TrainTicket.client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            TrainTicket.client.Timeout = 60000;  // 修改超时时间
            Console.WriteLine(TrainTicket.LoudTicketsPath);
            TrainTicket.InitPeople_ID();
            TrainTicket.BaseTicketImage = TicketImageTool.LoadAllBaseTrainTicketsImage();
            TrainTicket.OnTrainTicketMaked += UpdateTrainTicketView;
            TrainTicket.OnTrainTicketError += TrainTicketError;
            Control.CheckForIllegalCrossThreadCalls = false;
            _S.Opacity = 0;
            _S.timer1.Enabled = true;
            _S.Text = String.Format("AI智能火车票[识别/修改]系统-版本:{0}", Application.ProductVersion);
            OpenWidth = Width;
            Width = 350;

        }

        private void TrainTicketError(Image obj)
        {
            //throw new NotImplementedException();
            Form_AreYouKidMe.pictureBox1.Image = obj;
            Form_AreYouKidMe.ShowDialog();
        }
        void AI_LoadAllTrainTickets()
        {
            TrainTicketsInfoView.Items.Clear();
            TrainTicket.TrainTickets_Info.Clear();
            TrainTicket.TrainTickets_Image.Clear();
            var AllTrainticketimage = TicketImageTool.LoadAllTrainTicketsImage();
            foreach (var item in AllTrainticketimage)
            {
                TrainTicket.AI_TrainTicket(item);
            }
        }
        public void UpdateTrainTicketView(TrainTicketInfo ticketInfo)
        {
            AddTrainTicket(ticketInfo);

        }

        public void test_TrainTickets()
        {
            TrainTicketsInfoView.Items.Clear();
            TrainTicket.TrainTickets_Info.Clear();
            TrainTicket.TrainTickets_Image.Clear();
            CreateTrainTicket();
            CreateTrainTicket();
        }
        public void CreateTrainTicket()
        {
            var NEWticket = new TrainTicketInfo();
            //初始化车票信息
            {
                Random ran = new Random();
                int n = ran.Next(10, 24);
                int n2 = ran.Next(10, 24);
                NEWticket.train_starttime = n + ":" + n2;
                int n3 = ran.Next(1, 9);
                NEWticket.train_che = "0" + n3;
                int n4 = ran.Next(1, 9);
                NEWticket.logid = GetRandomlogid();
                NEWticket.train_hao = "0" + n4 + "B";
                NEWticket.ticket_num = "Z19W051789";
                NEWticket.date = "2019年06月29日";
                NEWticket.destination_station = "杭州东站";
                NEWticket.starting_station = "绍兴北站";
                NEWticket.seat_category = "二等座";
                NEWticket.train_num = "G1234";
                NEWticket.ticket_rates = "￥10.0元";
                NEWticket.name = "王小明";
                NEWticket.ID = "384951990042215674";
                NEWticket.bottomid = TrainTicket.GetRandombottomid();
                NEWticket.jianpiao = String.Format("检票:{0}", TrainTicket.GetRandomLetter().ToString() + new Random().Next(0, 9).ToString());
            }
            //var ticket = TrainTicket.AI_TrainTicket(TicketImageTool.LoadAllTrainTicketsImage()[0]);
            //  TrainTicket.TrainTickets_Info.Add(ticket);
           // TrainTicket.TrainTickets_Info.Add(NEWticket);
            AddTrainTicket(NEWticket);
        }
        public  void AddTrainTicket(TrainTicketInfo trainTicketInfo)
        {
            TrainTicket.TrainTickets_Info.Add(trainTicketInfo);
            TrainTicketsInfoView.Items.Add(trainTicketInfo.logid);
            UpateTicketPictureBoxImage(trainTicketInfo.logid, false);
            MessageBox.Show(String.Format("成功导入车票!\nID:{0}\n车票号码:{1}\n姓名:{2}\n出发站:{3}\n到达站:{4}", trainTicketInfo.logid, trainTicketInfo.ticket_num, trainTicketInfo.name, trainTicketInfo.starting_station, trainTicketInfo.destination_station), "车票识别系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string GetRandomlogid()
        {
            string result = null;
            for (int i = 0; i < 11; i++)
            {
                result += TrainTicket.GetRandomNumber();
            }
            return result;
        }
        private void TrainTicketsInfoView_MouseDown(object sender, MouseEventArgs e)
        {
            var index = TrainTicketsInfoView.IndexFromPoint(e.X, e.Y);
            TrainTicketsInfoView.SelectedIndex = index;
            if (index == -1)
            {
                TrainTicketsInfoView.ClearSelected();
                ClearTicketPictureBoxImage();
                ClearTickText();
                if (Width > OrinWidth)
                {
                    ISOpen = false;
                    FormOpentimer.Enabled = true;
                }

            }
            if (e.Button == MouseButtons.Right)
            {
               contextMenuStrip.Show(TrainTicketsInfoView, new Point(e.X, e.Y));
            }

        }
        public void ClearTicketPictureBoxImage()
        {
            TicketPictureBox.Image = null;
        }
        public void ClearTickText()
        {
            text_ticket_num.Text = null;
            text_train_num.Text = null;
            text_ticket_rates.Text = null;
            text_starting_station.Text = null;
            text_destination_station.Text = null;
            text_ID.Text = null;
            text_name.Text = null;
            text_date.Text = null;
            text_starttime.Text = null;
            text_seat_category.Text = null;
            text_bottomid.Text = null;
            text_jianpiao.Text = null;
            text_che.Text = null;
            text_hao.Text = null;
        }
        private void TrainTicketsInfoView_SelectedIndexChanged(object sender, EventArgs e)
        {

                // MessageBox.Show(TrainTicketsInfoView.SelectedItem.ToString(), "信息", MessageBoxButtons.OK);
            if (TrainTicketsInfoView.SelectedItem == null)
            {
                TrainTicketsInfoView.ClearSelected();
                return;
            }

            var logid = TrainTicketsInfoView.SelectedItem.ToString();
            NowSlectTickets = TrainTicket.GetTrainTicket(logid);

            text_ticket_num.Text = NowSlectTickets.ticket_num;
            text_train_num.Text = NowSlectTickets.train_num;
            text_ticket_rates.Text = NowSlectTickets.ticket_rates;
            text_starting_station.Text = NowSlectTickets.starting_station;
            text_destination_station.Text = NowSlectTickets.destination_station;
            text_ID.Text = NowSlectTickets.ID;
            text_name.Text = NowSlectTickets.name;
            text_date.Text = NowSlectTickets.date;
            text_starttime.Text = NowSlectTickets.train_starttime;
            text_seat_category.Text = NowSlectTickets.seat_category;
            text_bottomid.Text = NowSlectTickets.bottomid;
            text_jianpiao.Text = NowSlectTickets.jianpiao;
            text_che.Text = NowSlectTickets.train_che;
            text_hao.Text = NowSlectTickets.train_hao;

            if (TrainTicket.TrainTickets_Image.ContainsKey(logid))
            {
                var findimage = TrainTicket.GetTrainTicketImage(logid);
                var trimvalue = 222;
                if (findimage == null)
                {
                    MessageBox.Show("由于没有模板文件，车票无法制作成功", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                TicketPictureBox.Image = TicketImageTool.shrinkTo(findimage, new Size((findimage.Width+ trimvalue) / 3, (findimage.Height + trimvalue) / 3), false);
            }
            else
            {
                UpateTicketPictureBoxImage(TrainTicketsInfoView.SelectedItem.ToString());
            }
            if (Width < OpenWidth)
            {
                ISOpen = true;
                FormOpentimer.Enabled = true;
            }

        }



        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TrainTicketsInfoView.Items.Count<=0 || TrainTicketsInfoView.SelectedIndex == -1)
            {
                MessageBox.Show("您并没有选择任何车票", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NowSlectTickets.ticket_num = text_ticket_num.Text;
            NowSlectTickets.train_num= text_train_num.Text;
            NowSlectTickets.ticket_rates = text_ticket_rates.Text;
            NowSlectTickets.starting_station= text_starting_station.Text;
            NowSlectTickets.destination_station= text_destination_station.Text;
            NowSlectTickets.ID= text_ID.Text;
            NowSlectTickets.name= text_name.Text;
            NowSlectTickets.date= text_date.Text;
            NowSlectTickets.train_starttime=text_starttime.Text;
            NowSlectTickets.seat_category= text_seat_category.Text;
            NowSlectTickets.bottomid= text_bottomid.Text;
            NowSlectTickets.jianpiao= text_jianpiao.Text;
            NowSlectTickets.train_che= text_che.Text;
            NowSlectTickets.train_hao= text_hao.Text;
            TrainTicket.ChangeTrainTicketInfo(NowSlectTickets);

            if (TrainTicketsInfoView.SelectedItem == null)
                return;

            UpateTicketPictureBoxImage(TrainTicketsInfoView.SelectedItem.ToString());
            MessageBox.Show("保存成功:", "保存信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void UpateTicketPictureBoxImage(string number)
        {
            var Tickets = TrainTicket.GetTrainTicket(number);
            if (TrainTicket.TrainTickets_Image.ContainsKey(number))
            {
                TrainTicket.TrainTickets_Image.Remove(number);
            }
            TrainTicket.TrainTickets_Image.Add(number, TicketImageTool.MakeTrainTickImage(Tickets));
            NowSlectTickets = TrainTicket.GetTrainTicket(number);
            var findimage = TrainTicket.GetTrainTicketImage(number);
            var trimvalue = 222;
            if (findimage == null)
            {
                MessageBox.Show("由于没有模板文件，车票无法制作成功", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TicketPictureBox.Image = TicketImageTool.shrinkTo(findimage, new Size((findimage.Width + trimvalue) / 3, (findimage.Height + trimvalue) / 3), false);
        }
        void UpateTicketPictureBoxImage(string number,bool isshow)
        {
            var Tickets = TrainTicket.GetTrainTicket(number);
            if (TrainTicket.TrainTickets_Image.ContainsKey(number))
            {
                TrainTicket.TrainTickets_Image.Remove(number);
            }
            TrainTicket.TrainTickets_Image.Add(number, TicketImageTool.MakeTrainTickImage(Tickets));
            NowSlectTickets = TrainTicket.GetTrainTicket(number);
            if (!isshow)
                return;
              var findimage = TrainTicket.GetTrainTicketImage(number);
            var trimvalue = 222;
            if (findimage == null)
            {
                MessageBox.Show("由于没有模板文件，车票无法制作成功", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TicketPictureBox.Image = TicketImageTool.shrinkTo(findimage, new Size((findimage.Width + trimvalue) / 3, (findimage.Height + trimvalue) / 3), false);
        }
        private void TrainTicketsInfoView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void TrainTicketsInfoView_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            List<Image> loudimages = new List<Image>() ;
            if (fileNames.Length > 0)
            {
                foreach (var item in fileNames)
                {
                    try
                    {
                    loudimages.Add(Image.FromFile(item));
                    }
                    catch
                    {
                        MessageBox.Show("错误！拖入的:" + item+ "不是有效的图片文件", "图片加载", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //
                }
                if (loudimages.Count > 0)
                {
                    foreach (var item in loudimages)
                    {
                        TrainTicket.AI_TrainTicket(item);
                    }
                }
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            _S.Opacity += 0.025;
            if (_S.Opacity >= 1.0)  //当Form完全显示时，停止计时
            {
                _S.timer1.Enabled = false;
            }
        }

        public void RemoveTrainTicket(string logid)
        {
            if (TrainTicket.TrainTickets_Info.Count <= 0)
            {
                MessageBox.Show("你还没导入任何车票呢！\n你删除个鬼啊？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TrainTicketsInfoView.SelectedIndex == -1)
            {
                MessageBox.Show("车票都没选......\n你让我删啥玩意？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var iscontinue=  MessageBox.Show("确定要删除车票\n" + logid, "车票识别系统", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if (iscontinue == DialogResult.No)
            {
                return;
            }
            TrainTicket.TrainTickets_Info.Remove(TrainTicket.GetTrainTicket(logid));
            TrainTicketsInfoView.Items.Remove(logid);
            TrainTicket.TrainTickets_Image.Remove(logid);
            ClearTicketPictureBoxImage();
            ClearTickText();
            if (Width > OrinWidth)
            {
                ISOpen = false;
                FormOpentimer.Enabled = true;
            }
            MessageBox.Show("成功删除车票:"+logid, "删除车票", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ToolStripMenuItem_InputAll_Click(object sender, EventArgs e)
        {
            string EMPTYinfo = null;
            if (TrainTicketsInfoView.Items.Count > 0 || TrainTicket.TrainTickets_Info.Count > 0)
            {
                EMPTYinfo = "这样做会清空已经加载的车票数据";
            }
            var iscontinue = MessageBox.Show("确定要进行车票导入并识别？\n" + EMPTYinfo, "车票识别系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iscontinue == DialogResult.No)
            {
                // MessageBox.Show("操作已取消", "车票识别系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TrainTicket.BaseTicketImage == null || TrainTicket.BaseTicketImage.Count <= 0)
            {
                MessageBox.Show("没有车票模板文件\n请先放入模板文件再进行车票识别操作", "车票识别系统", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(TrainTicket.BaseTickfilePath);
                return;
            }
            MessageBox.Show("正在导入并识别车票中", "车票识别系统", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //test_TrainTickets();
            AI_LoadAllTrainTickets();
        }

        private void ToolStripMenuItem_OutputAll_Click(object sender, EventArgs e)
        {
            if (TrainTicket.TrainTickets_Image.Count <= 0)
            {
                MessageBox.Show("没有任何的车票可以导出:", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var item in TrainTicket.TrainTickets_Image)
            {
                item.Value.Save(TrainTicket.savePath + item.Key + ".jpg");
            }
            MessageBox.Show("导出成功:" + TrainTicket.TrainTickets_Image.Count + "张车票", "保存信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(TrainTicket.savePath);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AboutBox.ShowDialog();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting.ShowDialog();
        }

        private void 火车票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTrainTicket();
        }

        private void 清除当前选中车票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TrainTicket.TrainTickets_Info.Count <= 0)
            {
                MessageBox.Show("你还没导入任何车票呢！\n你删除个鬼啊？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TrainTicketsInfoView.SelectedIndex == -1)
            {
                MessageBox.Show("车票都没选......\n你让我删啥玩意？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            RemoveTrainTicket(TrainTicketsInfoView.SelectedItem.ToString());
        }

        private void 火车票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTrainTicket();
        }

        private void 新建火车票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTrainTicket();
        }

        private void FormOpentimer_Tick(object sender, EventArgs e)
        {
            int Speed = Width/15;
            if (ISOpen)
            {
                Width += Speed;
                if (Width >= OpenWidth)
                {
                    Width = OpenWidth;
                    FormOpentimer.Enabled = false;
                }
            }
            else
            {
                Width -= Speed;
                if (Width <= OrinWidth)
                {
                    Width = OrinWidth;
                    FormOpentimer.Enabled = false;
                }
            }

        }

        private void 清除所有车票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TrainTicket.TrainTickets_Info.Count <= 0)
            {
                MessageBox.Show("你还没导入任何车票呢！\n你删除个鬼啊？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var iscontinue = MessageBox.Show("确定要删除所有导入的车票？", "删除操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iscontinue == DialogResult.No)
            {
                return;
            }
            TrainTicket.TrainTickets_Info.Clear();
            TrainTicketsInfoView.Items.Clear();
            TrainTicket.TrainTickets_Image.Clear();
            MessageBox.Show("清理成功！", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TrainTicket.TrainTickets_Info.Count <= 0)
            {
                MessageBox.Show("你还没导入任何车票呢！\n你删除个鬼啊？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TrainTicketsInfoView.SelectedIndex == -1)
            {
                MessageBox.Show("车票都没选......\n你让我删啥玩意？", "删除操作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            RemoveTrainTicket(TrainTicketsInfoView.SelectedItem.ToString());
        }

        private void 导入ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG文件|*.jpg|PNG文件|*.png";
            Image loudimage=null;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                loudimage = Image.FromFile(dlg.FileName);
                if (loudimage != null)
                {
                    TrainTicket.AI_TrainTicket(loudimage);
                }
            }

        }

        private void 导出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TrainTicketsInfoView.SelectedIndex == -1)
            {
             var dialogresult=   MessageBox.Show("车票都没选。。。要不我导出一个空气给你？", "导出车票错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    MessageBox.Show("你还真的。。。。、\n脸皮厚。。。没车票导出个鬼啊！！！", "导出车票错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }
            if (TrainTicketsInfoView.Items.Count <= 0)
            {
                MessageBox.Show("一张车票都没有，导出啥玩意？", "导出车票错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            var logid = TrainTicketsInfoView.SelectedItem.ToString();
           TrainTicket.GetTrainTicketImage(logid).Save(TrainTicket.savePath+logid+".jpg");
            MessageBox.Show("车票"+logid+"导出成功", "导出车票成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(TrainTicket.savePath);
        }
    }

}

