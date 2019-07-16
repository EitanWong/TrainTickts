using System;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainTicketMainForm));
            this.TicketPictureBox = new System.Windows.Forms.PictureBox();
            this.TrainTicketsInfoView = new System.Windows.Forms.ListBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新疆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.火车票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_InputAll = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OutputAll = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除所有车票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除当前选中车票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建火车票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FormOpentimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketPictureBox
            // 
            this.TicketPictureBox.InitialImage = null;
            this.TicketPictureBox.Location = new System.Drawing.Point(493, 45);
            this.TicketPictureBox.Name = "TicketPictureBox";
            this.TicketPictureBox.Size = new System.Drawing.Size(548, 349);
            this.TicketPictureBox.TabIndex = 9;
            this.TicketPictureBox.TabStop = false;
            // 
            // TrainTicketsInfoView
            // 
            this.TrainTicketsInfoView.AllowDrop = true;
            this.TrainTicketsInfoView.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TrainTicketsInfoView.FormattingEnabled = true;
            this.TrainTicketsInfoView.ItemHeight = 25;
            this.TrainTicketsInfoView.Location = new System.Drawing.Point(12, 45);
            this.TrainTicketsInfoView.Name = "TrainTicketsInfoView";
            this.TrainTicketsInfoView.Size = new System.Drawing.Size(419, 629);
            this.TrainTicketsInfoView.TabIndex = 0;
            this.TrainTicketsInfoView.SelectedIndexChanged += new System.EventHandler(this.TrainTicketsInfoView_SelectedIndexChanged);
            this.TrainTicketsInfoView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TrainTicketsInfoView_DragDrop);
            this.TrainTicketsInfoView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TrainTicketsInfoView_DragEnter);
            this.TrainTicketsInfoView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrainTicketsInfoView_MouseDown);
            // 
            // text_ticket_num
            // 
            this.text_ticket_num.Location = new System.Drawing.Point(469, 420);
            this.text_ticket_num.Name = "text_ticket_num";
            this.text_ticket_num.Size = new System.Drawing.Size(181, 25);
            this.text_ticket_num.TabIndex = 14;
            this.text_ticket_num.Text = "车票号";
            // 
            // text_starting_station
            // 
            this.text_starting_station.Location = new System.Drawing.Point(469, 464);
            this.text_starting_station.Name = "text_starting_station";
            this.text_starting_station.Size = new System.Drawing.Size(181, 25);
            this.text_starting_station.TabIndex = 15;
            this.text_starting_station.Text = "始发站";
            // 
            // text_train_num
            // 
            this.text_train_num.Location = new System.Drawing.Point(677, 464);
            this.text_train_num.Name = "text_train_num";
            this.text_train_num.Size = new System.Drawing.Size(181, 25);
            this.text_train_num.TabIndex = 16;
            this.text_train_num.Text = "车次号";
            // 
            // text_destination_station
            // 
            this.text_destination_station.Location = new System.Drawing.Point(880, 464);
            this.text_destination_station.Name = "text_destination_station";
            this.text_destination_station.Size = new System.Drawing.Size(181, 25);
            this.text_destination_station.TabIndex = 17;
            this.text_destination_station.Text = "到达站";
            // 
            // text_date
            // 
            this.text_date.Location = new System.Drawing.Point(469, 510);
            this.text_date.Name = "text_date";
            this.text_date.Size = new System.Drawing.Size(181, 25);
            this.text_date.TabIndex = 18;
            this.text_date.Text = "出发日期";
            // 
            // text_ticket_rates
            // 
            this.text_ticket_rates.Location = new System.Drawing.Point(469, 553);
            this.text_ticket_rates.Name = "text_ticket_rates";
            this.text_ticket_rates.Size = new System.Drawing.Size(181, 25);
            this.text_ticket_rates.TabIndex = 19;
            this.text_ticket_rates.Text = "车票金额";
            // 
            // text_seat_category
            // 
            this.text_seat_category.Location = new System.Drawing.Point(880, 553);
            this.text_seat_category.Name = "text_seat_category";
            this.text_seat_category.Size = new System.Drawing.Size(181, 25);
            this.text_seat_category.TabIndex = 20;
            this.text_seat_category.Text = "席别";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(677, 598);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(181, 25);
            this.text_name.TabIndex = 21;
            this.text_name.Text = "乘客姓名";
            // 
            // text_starttime
            // 
            this.text_starttime.Location = new System.Drawing.Point(677, 509);
            this.text_starttime.Name = "text_starttime";
            this.text_starttime.Size = new System.Drawing.Size(181, 25);
            this.text_starttime.TabIndex = 22;
            this.text_starttime.Text = "出发时间";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(469, 598);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(181, 25);
            this.text_ID.TabIndex = 23;
            this.text_ID.Text = "身份证号";
            // 
            // text_bottomid
            // 
            this.text_bottomid.Location = new System.Drawing.Point(469, 642);
            this.text_bottomid.Name = "text_bottomid";
            this.text_bottomid.Size = new System.Drawing.Size(389, 25);
            this.text_bottomid.TabIndex = 24;
            this.text_bottomid.Text = "底部编号";
            // 
            // text_che
            // 
            this.text_che.Location = new System.Drawing.Point(880, 510);
            this.text_che.Name = "text_che";
            this.text_che.Size = new System.Drawing.Size(69, 25);
            this.text_che.TabIndex = 25;
            this.text_che.Text = "车";
            // 
            // text_hao
            // 
            this.text_hao.Location = new System.Drawing.Point(1002, 510);
            this.text_hao.Name = "text_hao";
            this.text_hao.Size = new System.Drawing.Size(59, 25);
            this.text_hao.TabIndex = 26;
            this.text_hao.Text = "号";
            // 
            // text_jianpiao
            // 
            this.text_jianpiao.Location = new System.Drawing.Point(880, 420);
            this.text_jianpiao.Name = "text_jianpiao";
            this.text_jianpiao.Size = new System.Drawing.Size(181, 25);
            this.text_jianpiao.TabIndex = 27;
            this.text_jianpiao.Text = "检票";
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Save.Location = new System.Drawing.Point(880, 600);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(170, 66);
            this.button_Save.TabIndex = 28;
            this.button_Save.Text = "保存更改";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新疆ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新疆ToolStripMenuItem
            // 
            this.新疆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.火车票ToolStripMenuItem});
            this.新疆ToolStripMenuItem.Name = "新疆ToolStripMenuItem";
            this.新疆ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.新疆ToolStripMenuItem.Text = "新建";
            // 
            // 火车票ToolStripMenuItem
            // 
            this.火车票ToolStripMenuItem.Name = "火车票ToolStripMenuItem";
            this.火车票ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.火车票ToolStripMenuItem.Text = "火车票";
            this.火车票ToolStripMenuItem.Click += new System.EventHandler(this.火车票ToolStripMenuItem_Click);
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_InputAll});
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // ToolStripMenuItem_InputAll
            // 
            this.ToolStripMenuItem_InputAll.Name = "ToolStripMenuItem_InputAll";
            this.ToolStripMenuItem_InputAll.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_InputAll.Text = "导入全部";
            this.ToolStripMenuItem_InputAll.Click += new System.EventHandler(this.ToolStripMenuItem_InputAll_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OutputAll});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // ToolStripMenuItem_OutputAll
            // 
            this.ToolStripMenuItem_OutputAll.Name = "ToolStripMenuItem_OutputAll";
            this.ToolStripMenuItem_OutputAll.Size = new System.Drawing.Size(152, 26);
            this.ToolStripMenuItem_OutputAll.Text = "导出全部";
            this.ToolStripMenuItem_OutputAll.Click += new System.EventHandler(this.ToolStripMenuItem_OutputAll_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除所有车票ToolStripMenuItem,
            this.清除当前选中车票ToolStripMenuItem});
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 清除所有车票ToolStripMenuItem
            // 
            this.清除所有车票ToolStripMenuItem.Name = "清除所有车票ToolStripMenuItem";
            this.清除所有车票ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.清除所有车票ToolStripMenuItem.Text = "删除所有导入的车票";
            this.清除所有车票ToolStripMenuItem.Click += new System.EventHandler(this.清除所有车票ToolStripMenuItem_Click);
            // 
            // 清除当前选中车票ToolStripMenuItem
            // 
            this.清除当前选中车票ToolStripMenuItem.Name = "清除当前选中车票ToolStripMenuItem";
            this.清除当前选中车票ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.清除当前选中车票ToolStripMenuItem.Text = "删除当前选中车票";
            this.清除当前选中车票ToolStripMenuItem.Click += new System.EventHandler(this.清除当前选中车票ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建火车票ToolStripMenuItem,
            this.导入ToolStripMenuItem1,
            this.导出ToolStripMenuItem1,
            this.删除ToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(154, 100);
            // 
            // 新建火车票ToolStripMenuItem
            // 
            this.新建火车票ToolStripMenuItem.Name = "新建火车票ToolStripMenuItem";
            this.新建火车票ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.新建火车票ToolStripMenuItem.Text = "新建火车票";
            this.新建火车票ToolStripMenuItem.Click += new System.EventHandler(this.新建火车票ToolStripMenuItem_Click);
            // 
            // 导入ToolStripMenuItem1
            // 
            this.导入ToolStripMenuItem1.Name = "导入ToolStripMenuItem1";
            this.导入ToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.导入ToolStripMenuItem1.Text = "导入火车票";
            this.导入ToolStripMenuItem1.Click += new System.EventHandler(this.导入ToolStripMenuItem1_Click);
            // 
            // 导出ToolStripMenuItem1
            // 
            this.导出ToolStripMenuItem1.Name = "导出ToolStripMenuItem1";
            this.导出ToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.导出ToolStripMenuItem1.Text = "导出火车票";
            this.导出ToolStripMenuItem1.Click += new System.EventHandler(this.导出ToolStripMenuItem1_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.删除ToolStripMenuItem1.Text = "删除火车票";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // FormOpentimer
            // 
            this.FormOpentimer.Interval = 1;
            this.FormOpentimer.Tick += new System.EventHandler(this.FormOpentimer_Tick);
            // 
            // TrainTicketMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 702);
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
            this.Controls.Add(this.TrainTicketsInfoView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "TrainTicketMainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TrainTicketMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public  System.Windows.Forms.ListBox TrainTicketsInfoView;
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
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 新疆ToolStripMenuItem;
        private ToolStripMenuItem 导入ToolStripMenuItem;
        private ToolStripMenuItem 导出ToolStripMenuItem;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 火车票ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_InputAll;
        private ToolStripMenuItem ToolStripMenuItem_OutputAll;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private ToolStripMenuItem 清除所有车票ToolStripMenuItem;
        private ToolStripMenuItem 清除当前选中车票ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem 新建火车票ToolStripMenuItem;
        private ToolStripMenuItem 导入ToolStripMenuItem1;
        private ToolStripMenuItem 导出ToolStripMenuItem1;
        private ToolStripMenuItem 删除ToolStripMenuItem1;
        private Timer FormOpentimer;
    }
}