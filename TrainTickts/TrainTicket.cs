using System;
using System.Collections.Generic;
using System.IO;
using Baidu;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace TicketsBase
{
    public struct TrainTicketInfo
    {
        TrainTicketInfo(string[] info)
        {
            logid = info[0];
            date = info[1];
            destination_station = info[2];
            name = info[3];
            seat_category = info[4];
            starting_station = info[5];
            ticket_num = info[6];
            ticket_rates = info[7];
            train_num = info[8];
            train_starttime = info[9];
            train_che = info[10];
            train_hao = info[11];
            ID = info[12];
            bottomid = info[13];
            jianpiao = info[14];
        }
        public string logid;
        public string date;
        public string destination_station;
        public string name; 
        public string seat_category;
        public string starting_station;
        public string ticket_num;
        public string ticket_rates;
        public string train_num;
        public string train_starttime;
        public string train_che;
        public string train_hao;
        public string ID;
        public string bottomid;
        public string jianpiao;
    }


    public static class TrainTicket
    {
        public static string LoudTicketsPath = AppDomain.CurrentDomain.BaseDirectory + "OrinTickets\\";
        public static string BaseTickfilePath = AppDomain.CurrentDomain.BaseDirectory + "BaseTickets\\";
        public static string savePath = AppDomain.CurrentDomain.BaseDirectory + "FinishTickets\\";


        public static readonly string Orin_LoudTicketsPath = AppDomain.CurrentDomain.BaseDirectory + "OrinTickets\\";
        public static readonly string Orin_BaseTickfilePath = AppDomain.CurrentDomain.BaseDirectory + "BaseTickets\\";
        public static readonly string Orin_savePath = AppDomain.CurrentDomain.BaseDirectory + "FinishTickets\\";

        public static Dictionary<string, string> People_ID = new Dictionary<string, string>();
        public static List<TrainTicketInfo> TrainTickets_Info=new List<TrainTicketInfo>();
        public static  Dictionary<string,Image> TrainTickets_Image = new Dictionary<string, Image>();
        public static List<Image> BaseTicketImage = new List<Image>();

        public static void InitPeople_ID()
        {
            People_ID.Add("邹正芳", "362301998123457130");

        }
        public static string filePath;
        public static Baidu.Aip.Ocr.Ocr client;
        public static void TrainTicketDemo()
        {
            var image = File.ReadAllBytes(filePath);
            // 调用火车票识别
            try
            {
                var result = client.TrainTicket(image);
                Console.WriteLine(result);
                Console.WriteLine(result["words_result"]["name"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

         static byte[] Imageinfo;
       static Action callback;
        public static void AI_TrainTicket(Image image)
        {
            
            Imageinfo= TicketImageTool.imageToByte(image);
            Thread thread_TrainTickets = new Thread(new ThreadStart(TrainTickets));
            thread_TrainTickets.Start();
        }
       public static Action<TrainTicketInfo> OnTrainTicketMaked;
        public static void TrainTickets()
        {
            JObject result = null;
            try
            {
                result = client.TrainTicket(Imageinfo);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("识别车票错误\n错误信息{0}", e), "车票识别", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          var Tickinfo = new TrainTicketInfo
            {
                logid = (string)result["log_id"],
                ticket_num = (string)result["words_result"]["ticket_num"],
                date = (string)result["words_result"]["date"],
                name = FixName((string)result["words_result"]["name"]),
                seat_category = (string)result["words_result"]["seat_category"],
                starting_station = (string)result["words_result"]["starting_station"],
                destination_station = (string)result["words_result"]["destination_station"],
                train_num = (string)result["words_result"]["train_num"],
                ticket_rates = (string)result["words_result"]["ticket_rates"],
                jianpiao = String.Format("检票:{0}", TrainTicket.GetRandomLetter().ToString() + new Random().Next(0, 9).ToString())
            };
            Random ran = new Random();
            int n = ran.Next(10, 24);
            int n2 = ran.Next(10, 24);
            Tickinfo.train_starttime = n + ":" + n2;
            int n3 = ran.Next(1, 9);
            Tickinfo.train_che = "0" + n3;
            int n4 = ran.Next(1, 9);
            Tickinfo.train_hao = "0" + n4 + "B";
            Tickinfo.ID = "362301998123457130";
            if (People_ID.ContainsKey(Tickinfo.name))
            {
                Tickinfo.ID = People_ID[Tickinfo.name];
            }
            Tickinfo.bottomid = GetRandombottomid();
            TrainTicket.TrainTickets_Info.Add(Tickinfo);
            OnTrainTicketMaked(Tickinfo);

            return ;
        }
        public static TrainTicketInfo AI_TrainTicket(string  path)
        {
            var Imageinfo = File.ReadAllBytes(path);
            var result = client.TrainTicket(Imageinfo);
            TrainTicketInfo Tickinfo = new TrainTicketInfo();
            Tickinfo.logid = (string)result["log_id"];
            Tickinfo.ticket_num = (string)result["words_result"]["ticket_num"];
            Tickinfo.date = (string)result["words_result"]["date"];
            Tickinfo.name = FixName((string)result["words_result"]["name"]);
            Tickinfo.seat_category = (string)result["words_result"]["seat_category"];
            Tickinfo.starting_station = (string)result["words_result"]["starting_station"];
            Tickinfo.destination_station = (string)result["words_result"]["destination_station"];
            Tickinfo.train_num = (string)result["words_result"]["train_num"];
            Tickinfo.ticket_rates = (string)result["words_result"]["ticket_rates"];
            Tickinfo.jianpiao = String.Format("检票:{0}", TrainTicket.GetRandomLetter().ToString() + new Random().Next(0, 9).ToString());
            Random ran = new Random();
            int n = ran.Next(10, 24);
            int n2 = ran.Next(10, 24);
            Tickinfo.train_starttime = n + ":" + n2;
            int n3 = ran.Next(1, 9);
            Tickinfo.train_che = "0" + n3;
            int n4 = ran.Next(1, 9);
            Tickinfo.train_hao = "0" + n4 + "B";
            Tickinfo.ID = "384951990042215674";
            if (People_ID.ContainsKey(Tickinfo.name))
            {
                Tickinfo.ID = People_ID[Tickinfo.name];
            }
            else
            {
                Tickinfo.ID = "请手动输入";
            }
            Tickinfo.bottomid = GetRandombottomid();
            return Tickinfo;
        }
        public static string GetRandombottomid()
        {
            string result = null;
            string addvalue = "0";
            for (int i = 0; i < 21; i++)
            {

                if (i == 15)
                {
                    addvalue = GetRandomLetter().ToString();
                }
                else
                {
                    addvalue = GetRandomNumber().ToString();
                }
                result += addvalue;
            }
            return result;
        }

        public static int GetRandomTime()
        {
            Thread.Sleep(10);
            return new Random().Next(10);
        }

        public static int GetRandomNumber()
        {
             Thread.Sleep(GetRandomTime());
            return new Random().Next(9);
        }
        public static string FixName(string name)
        {
            string result = null;
            for (int i = 0; i < name.Length; i++)
            {
                try
                {
                    int.Parse(name[i].ToString());
                }
                catch
                {
                    result += name[i];
                }
               
            }
            return result;
        }
        public static TrainTicketInfo GetTrainTicket(string Ticket_logid)
        {
            TrainTicketInfo ticketInfo = new TrainTicketInfo();
            foreach (var item in TrainTickets_Info)
            {
                if(item.logid==Ticket_logid)
                {
                    ticketInfo = item;
                }
            }
            return ticketInfo;
        }
        public static Image GetTrainTicketImage(string Ticket_Num)
        {

            if (!TrainTickets_Image.ContainsKey(Ticket_Num))
                return null;

            return TrainTickets_Image[Ticket_Num];
        }
        public static Letter GetRandomLetter()
        {
            return (Letter)(new Random().Next(0, 25));
        }
        public static void ChangeTrainTicketInfo(TrainTicketInfo ticketInfo)
        {
            foreach (var item in TrainTickets_Info)
            {
                if (item.logid == ticketInfo.logid)
                {
                    TrainTickets_Info.Remove(item);
                    TrainTickets_Info.Add(ticketInfo);
                    return;
                }
            }
        }
    }
    public enum Letter
    {
        A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z
    }
}
