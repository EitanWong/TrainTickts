namespace TrainTickets
{
    partial class TrainTicketMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TicketPictureBox = new System.Windows.Forms.PictureBox();
            this.TrainTicketsInfoView = new System.Windows.Forms.ListBox();
            this.button_InputTickets = new System.Windows.Forms.Button();
            this.text_ticket_num = new System.Windows.Forms.TextBox();
            this.text_starting_station = new System.Windows.Forms.TextBox();
            this.text_train_num = new System.Windows.Forms.TextBox();
            this.text_destination_station = new System.Windows.Forms.TextBox();
            this.text_date = new System.Windows.Forms.TextBox();
            this.text_ticket_rates = new System.Windows.Forms.TextBox();
            this.text_seat_category = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_starttime = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_bottomid = new System.Windows.Forms.TextBox();
            this.text_che = new System.Windows.Forms.TextBox();
            this.text_hao = new System.Windows.Forms.TextBox();
            this.text_jianpiao = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.Output_TrainTickets = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Setting = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketPictureBox
            // 
            this.TicketPictureBox.InitialImage = null;
            this.TicketPictureBox.Location = new System.Drawing.Point(476, 12);
            this.TicketPictureBox.Name = "TicketPictureBox";
            this.TicketPictureBox.Size = new System.Drawing.Size(548, 349);
            this.TicketPictureBox.TabIndex = 9;
            this.TicketPictureBox.TabStop = false;
            // 
            // TrainTicketsInfoView
            // 
            this.TrainTicketsInfoView.FormattingEnabled = true;
            this.TrainTicketsInfoView.ItemHeight = 15;
            this.TrainTicketsInfoView.Location = new System.Drawing.Point(12, 12);
            this.TrainTicketsInfoView.Name = "TrainTicketsInfoView";
            this.TrainTicketsInfoView.Size = new System.Drawing.Size(419, 349);
            this.TrainTicketsInfoView.TabIndex = 0;
            this.TrainTicketsInfoView.SelectedIndexChanged += new System.EventHandler(this.TrainTicketsInfoView_SelectedIndexChanged);
            // 
            // button_InputTickets
            // 
            this.button_InputTickets.Location = new System.Drawing.Point(104, 377);
            this.button_InputTickets.Name = "button_InputTickets";
            this.button_InputTickets.Size = new System.Drawing.Size(225, 74);
            this.button_InputTickets.TabIndex = 1;
            this.button_InputTickets.Text = "导入所有原始车票";
            this.button_InputTickets.UseVisualStyleBackColor = true;
            this.button_InputTickets.Click += new System.EventHandler(this.Button_InputTickets_Click);
            // 
            // text_ticket_num
            // 
            this.text_ticket_num.Location = new System.Drawing.Point(453, 382);
            this.text_ticket_num.Name = "text_ticket_num";
            this.text_ticket_num.Size = new System.Drawing.Size(181, 25);
            this.text_ticket_num.TabIndex = 14;
            this.text_ticket_num.Text = "车票号";
            // 
            // text_starting_station
            // 
            this.text_starting_station.Location = new System.Drawing.Point(453, 426);
            this.text_starting_station.Name = "text_starting_station";
            this.text_starting_station.Size = new System.Drawing.Size(181, 25);
            this.text_starting_station.TabIndex = 15;
            this.text_starting_station.Text = "始发站";
            // 
            // text_train_num
            // 
            this.text_train_num.Location = new System.Drawing.Point(661, 426);
            this.text_train_num.Name = "text_train_num";
            this.text_train_num.Size = new System.Drawing.Size(181, 25);
            this.text_train_num.TabIndex = 16;
            this.text_train_num.Text = "车次号";
            // 
            // text_destination_station
            // 
            this.text_destination_station.Location = new System.Drawing.Point(864, 426);
            this.text_destination_station.Name = "text_destination_station";
            this.text_destination_station.Size = new System.Drawing.Size(181, 25);
            this.text_destination_station.TabIndex = 17;
            this.text_destination_station.Text = "到达站";
            // 
            // text_date
            // 
            this.text_date.Location = new System.Drawing.Point(453, 472);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(181, 25);
            this.text_date.TabIndex = 18;
            this.text_date.Text = "出发日期";
            // 
            // text_ticket_rates
            // 
            this.text_ticket_rates.Location = new System.Drawing.Point(453, 515);
            this.text_ticket_rates.Name = "text_ticket_rates";
            this.text_ticket_rates.Size = new System.Drawing.Size(181, 25);
            this.text_ticket_rates.TabIndex = 19;
            this.text_ticket_rates.Text = "车票金额";
            // 
            // text_seat_category
            // 
            this.text_seat_category.Location = new System.Drawing.Point(864, 515);
            this.text_seat_category.Name = "text_seat_category";
            this.text_seat_category.Size = new System.Drawing.Size(181, 25);
            this.text_seat_category.TabIndex = 20;
            this.text_seat_category.Text = "席别";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(661, 560);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(181, 25);
            this.text_name.TabIndex = 21;
            this.text_name.Text = "乘客姓名";
            // 
            // text_starttime
            // 
            this.text_starttime.Location = new System.Drawing.Point(661, 471);
            this.text_starttime.Name = "text_starttime";
            this.text_starttime.Size = new System.Drawing.Size(181, 25);
            this.text_starttime.TabIndex = 22;
            this.text_starttime.Text = "出发时间";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(453, 560);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(181, 25);
            this.text_ID.TabIndex = 23;
            this.text_ID.Text = "身份证号";
            // 
            // text_bottomid
            // 
            this.text_bottomid.Location = new System.Drawing.Point(453, 604);
            this.text_bottomid.Name = "text_bottomid";
            this.text_bottomid.Size = new System.Drawing.Size(389, 25);
            this.text_bottomid.TabIndex = 24;
            this.text_bottomid.Text = "底部编号";
            // 
            // text_che
            // 
            this.text_che.Location = new System.Drawing.Point(864, 472);
            this.text_che.Name = "text_che";
            this.text_che.Size = new System.Drawing.Size(69, 25);
            this.text_che.TabIndex = 25;
            this.text_che.Text = "车";
            // 
            // text_hao
            // 
            this.text_hao.Location = new System.Drawing.Point(986, 472);
            this.text_hao.Name = "text_hao";
            this.text_hao.Size = new System.Drawing.Size(59, 25);
            this.text_hao.TabIndex = 26;
            this.text_hao.Text = "号";
            // 
            // text_jianpiao
            // 
            this.text_jianpiao.Location = new System.Drawing.Point(864, 382);
            this.text_jianpiao.Name = "text_jianpiao";
            this.text_jianpiao.Size = new System.Drawing.Size(181, 25);
            this.text_jianpiao.TabIndex = 27;
            this.text_jianpiao.Text = "检票";
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Save.Location = new System.Drawing.Point(864, 562);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(170, 66);
            this.button_Save.TabIndex = 28;
            this.button_Save.Text = "保存更改";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Output_TrainTickets
            // 
            this.Output_TrainTickets.Location = new System.Drawing.Point(104, 464);
            this.Output_TrainTickets.Name = "Output_TrainTickets";
            this.Output_TrainTickets.Size = new System.Drawing.Size(225, 76);
            this.Output_TrainTickets.TabIndex = 29;
            this.Output_TrainTickets.Text = "导出所有车票";
            this.Output_TrainTickets.UseVisualStyleBackColor = true;
            this.Output_TrainTickets.Click += new System.EventHandler(this.Output_TrainTickets_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button_Setting
            // 
            this.button_Setting.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Setting.Location = new System.Drawing.Point(13, 587);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(75, 51);
            this.button_Setting.TabIndex = 30;
            this.button_Setting.Text = "设置";
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.Button_Setting_Click);
            // 
            // button_About
            // 
            this.button_About.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_About.Location = new System.Drawing.Point(94, 585);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(76, 54);
            this.button_About.TabIndex = 31;
            this.button_About.Text = "关于";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // TrainTicketMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 653);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Setting);
            this.Controls.Add(this.Output_TrainTickets);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.text_jianpiao);
            this.Controls.Add(this.text_hao);
            this.Controls.Add(this.text_che);
            this.Controls.Add(this.text_bottomid);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.text_starttime);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_seat_category);
            this.Controls.Add(this.text_ticket_rates);
            this.Controls.Add(this.text_date);
            this.Controls.Add(this.text_destination_station);
            this.Controls.Add(this.text_train_num);
            this.Controls.Add(this.text_starting_station);
            this.Controls.Add(this.text_ticket_num);
            this.Controls.Add(this.TicketPictureBox);
            this.Controls.Add(this.button_InputTickets);
            this.Controls.Add(this.TrainTicketsInfoView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TrainTicketMainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI智能火车票识别修改系统 ";
            this.Load += new System.EventHandler(this.TrainTicketMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.ListBox TrainTicketsInfoView;
        private System.Windows.Forms.Button button_InputTickets;
        public System.Windows.Forms.PictureBox TicketPictureBox;
        private System.Windows.Forms.TextBox text_ticket_num;
        private System.Windows.Forms.TextBox text_starting_station;
        private System.Windows.Forms.TextBox text_train_num;
        private System.Windows.Forms.TextBox text_destination_station;
        private System.Windows.Forms.TextBox text_date;
        private System.Windows.Forms.TextBox text_ticket_rates;
        private System.Windows.Forms.TextBox text_seat_category;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_starttime;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_bottomid;
        private System.Windows.Forms.TextBox text_che;
        private System.Windows.Forms.TextBox text_hao;
        private System.Windows.Forms.TextBox text_jianpiao;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button Output_TrainTickets;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Button button_About;
    }
}