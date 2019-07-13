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
        public TrainTicketMainForm()
        {
            InitializeComponent();
            _S = this;
        }

        TrainTicketInfo NowSlectTickets;
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
            Control.CheckForIllegalCrossThreadCalls = false;
            _S.Opacity = 0;
            _S.timer1.Enabled = true;
            _S.Text = String.Format("AI智能火车票识别修改系统      版本:{0}", Application.ProductVersion);
            var tick = new TrainTicketInfo();
            //初始化车票信息
            {
                Random ran = new Random();
                int n = ran.Next(10, 24);
                int n2 = ran.Next(10, 24);
                tick.train_starttime = n + ":" + n2;
                int n3 = ran.Next(1, 9);
                tick.train_che = "0" + n3;
                int n4 = ran.Next(1, 9);
                tick.logid = "123456789";
                tick.train_hao = "0" + n4 + "B";
                tick.ticket_num = "Z19W051789";
                tick.date = "2019年06月29日";
                tick.destination_station = "杭州站";
                tick.starting_station = "绍兴站";
                tick.seat_category = "二等座";
                tick.train_num = "G1505";
                tick.ticket_rates = "￥10.0元";
                tick.name = "王雅美";
                tick.ID = "384951990042215674";
                tick.bottomid = TrainTicket.GetRandombottomid();
                tick.jianpiao = String.Format("检票:{0}", TrainTicket.GetRandomLetter().ToString() + new Random().Next(0, 9).ToString());
            }
            var tick2 = new TrainTicketInfo();
            //初始化车票信息
            {
                Random ran = new Random();
                int n = ran.Next(10, 24);
                int n2 = ran.Next(10, 24);
                tick2.train_starttime = n + ":" + n2;
                int n3 = ran.Next(1, 9);
                tick2.train_che = "0" + n3;
                int n4 = ran.Next(1, 9);
                tick2.logid = "869422238";
                tick2.train_hao = "0" + n4 + "B";
                tick2.ticket_num = "Z19W051789";
                tick2.date = "2019年06月29日";
                tick2.destination_station = "衢州站";
                tick2.starting_station = "绍兴站";
                tick2.seat_category = "二等座";
                tick2.train_num = "G1505";
                tick2.ticket_rates = "￥10.0元";
                tick2.name = "王雅美";
                tick2.ID = "384951990042215674";
                tick2.bottomid = TrainTicket.GetRandombottomid();
                tick2.jianpiao = String.Format("检票:{0}", TrainTicket.GetRandomLetter().ToString() + new Random().Next(0, 9).ToString());
            }
            //var ticket = TrainTicket.AI_TrainTicket(TicketImageTool.LoadAllTrainTicketsImage()[0]);
          //  TrainTicket.TrainTickets_Info.Add(ticket);
            TrainTicket.TrainTickets_Info.Add(tick2);
            TrainTicket.TrainTickets_Info.Add(tick);
        }

        private void Button_InputTickets_Click(object sender, EventArgs e)
        {
            string EMPTYinfo=null;
            if (TrainTicketsInfoView.Items.Count > 0||TrainTicket.TrainTickets_Info.Count>0)
            {
                EMPTYinfo = "这样做会清空已经加载的车票数据";
            }
          var iscontinue=  MessageBox.Show("确定要进行车票导入并识别？\n"+ EMPTYinfo, "车票识别系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            var All_TrainTicketsimage=  TicketImageTool.LoadAllTrainTicketsImage();
            foreach (var item in All_TrainTicketsimage)
            {
             // TrainTicket.TrainTickets_Info.Add(TrainTicket.AI_TrainTicket(item));
            }

           // test_TrainTickets();
            AI_LoadAllTrainTickets();

        }
        void AI_LoadAllTrainTickets()
        {
            TrainTicketsInfoView.Items.Clear();
            TrainTicket.TrainTickets_Info.Clear();
            var AllTrainticketimage = TicketImageTool.LoadAllTrainTicketsImage();
            foreach (var item in AllTrainticketimage)
            {
                TrainTicket.AI_TrainTicket(item);
            }
        }
        public void UpdateTrainTicketView(TrainTicketInfo ticketInfo)
        {
            TrainTicketsInfoView.Items.Add(ticketInfo.logid);
            UpateTicketPictureBoxImage(ticketInfo.logid, false);
            MessageBox.Show(String.Format("成功导入车票!\nID:{0}\n车票号码:{1}\n姓名:{2}\n出发站:{3}\n到达站:{4}", ticketInfo.logid,ticketInfo.ticket_num,ticketInfo.name,ticketInfo.starting_station,ticketInfo.destination_station), "车票识别系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void test_TrainTickets()
        {
            TrainTicketsInfoView.Items.Clear();
            foreach (var item in TrainTicket.TrainTickets_Info)
            {
                TrainTicketsInfoView.Items.Add(item.logid);
                UpateTicketPictureBoxImage(item.logid, false);
            }
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
        }



        private void Button_Save_Click(object sender, EventArgs e)
        {

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
        private void Output_TrainTickets_Click(object sender, EventArgs e)
        {
            if (TrainTicket.TrainTickets_Image.Count <= 0)
            {
                MessageBox.Show("没有任何的车票可以导出:", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var item in TrainTicket.TrainTickets_Image)
            {
                item.Value.Save(TrainTicket.savePath+item.Key+".jpg");
            }
            MessageBox.Show("导出成功:"+ TrainTicket.TrainTickets_Image.Count +"张车票", "保存信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(TrainTicket.savePath);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            _S.Opacity += 0.025;
            if (_S.Opacity >= 1.0)  //当Form完全显示时，停止计时
            {
                _S.timer1.Enabled = false;
            }
        }

        private void Button_Setting_Click(object sender, EventArgs e)
        {
            Form_Setting.ShowDialog();
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            Form_AboutBox.ShowDialog();
        }
    }

}

