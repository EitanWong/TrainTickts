using System;
using System.Windows.Forms;

namespace TrainTickts
{
    partial class Setting
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
            this.button_ChooseOrinTicketsFile = new System.Windows.Forms.Button();
            this.button_OpenOrinTicketsFile = new System.Windows.Forms.Button();
            this.button_OrinTicketsOrinFile = new System.Windows.Forms.Button();
            this.button_ChooseBaseTicketsFile = new System.Windows.Forms.Button();
            this.button_OpenBaseTicketsFile = new System.Windows.Forms.Button();
            this.button_BaseTicketsOrinFile = new System.Windows.Forms.Button();
            this.button_ChooseFinishTicketsFile = new System.Windows.Forms.Button();
            this.button_OpenFinishTicketsFile = new System.Windows.Forms.Button();
            this.button_FinishTicketsOrinFile = new System.Windows.Forms.Button();
            this.label_OrinTicket = new System.Windows.Forms.Label();
            this.textBox_Orinticketpath = new System.Windows.Forms.TextBox();
            this.textBox_Baseticketpath = new System.Windows.Forms.TextBox();
            this.label_BaseTicket = new System.Windows.Forms.Label();
            this.textBox_Saveticketpath = new System.Windows.Forms.TextBox();
            this.label_SaveTicket = new System.Windows.Forms.Label();
            this.button_SetOrinFile = new System.Windows.Forms.Button();
            this.button_OpenSetFile = new System.Windows.Forms.Button();
            this.button_ChooseSetFile = new System.Windows.Forms.Button();
            this.textBox_Setpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_FileSet = new System.Windows.Forms.Panel();
            this.panel_IDSet = new System.Windows.Forms.Panel();
            this.button_DeletePeopleID = new System.Windows.Forms.Button();
            this.listBox_ID = new System.Windows.Forms.ListBox();
            this.listBox_Name = new System.Windows.Forms.ListBox();
            this.button_Caozuo = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_SetFile = new System.Windows.Forms.Label();
            this.label_IDSET = new System.Windows.Forms.Label();
            this.panel_FileSet.SuspendLayout();
            this.panel_IDSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ChooseOrinTicketsFile
            // 
            this.button_ChooseOrinTicketsFile.Location = new System.Drawing.Point(581, 20);
            this.button_ChooseOrinTicketsFile.Name = "button_ChooseOrinTicketsFile";
            this.button_ChooseOrinTicketsFile.Size = new System.Drawing.Size(79, 71);
            this.button_ChooseOrinTicketsFile.TabIndex = 4;
            this.button_ChooseOrinTicketsFile.Text = "选择原始车票目录";
            this.button_ChooseOrinTicketsFile.UseVisualStyleBackColor = true;
            this.button_ChooseOrinTicketsFile.Click += new System.EventHandler(this.Button_ChooseOrinTicketsFile_Click);
            // 
            // button_OpenOrinTicketsFile
            // 
            this.button_OpenOrinTicketsFile.Location = new System.Drawing.Point(666, 20);
            this.button_OpenOrinTicketsFile.Name = "button_OpenOrinTicketsFile";
            this.button_OpenOrinTicketsFile.Size = new System.Drawing.Size(84, 71);
            this.button_OpenOrinTicketsFile.TabIndex = 5;
            this.button_OpenOrinTicketsFile.Text = "打开原始车票目录";
            this.button_OpenOrinTicketsFile.UseVisualStyleBackColor = true;
            this.button_OpenOrinTicketsFile.Click += new System.EventHandler(this.Button_OpenOrinTicketsFile_Click);
            // 
            // button_OrinTicketsOrinFile
            // 
            this.button_OrinTicketsOrinFile.Location = new System.Drawing.Point(756, 20);
            this.button_OrinTicketsOrinFile.Name = "button_OrinTicketsOrinFile";
            this.button_OrinTicketsOrinFile.Size = new System.Drawing.Size(85, 71);
            this.button_OrinTicketsOrinFile.TabIndex = 6;
            this.button_OrinTicketsOrinFile.Text = "还原默认原始车票目录";
            this.button_OrinTicketsOrinFile.UseVisualStyleBackColor = true;
            this.button_OrinTicketsOrinFile.Click += new System.EventHandler(this.Button_OrinTicketsOrinFile_Click);
            // 
            // button_ChooseBaseTicketsFile
            // 
            this.button_ChooseBaseTicketsFile.Location = new System.Drawing.Point(581, 97);
            this.button_ChooseBaseTicketsFile.Name = "button_ChooseBaseTicketsFile";
            this.button_ChooseBaseTicketsFile.Size = new System.Drawing.Size(79, 71);
            this.button_ChooseBaseTicketsFile.TabIndex = 8;
            this.button_ChooseBaseTicketsFile.Text = "选择模板车票目录";
            this.button_ChooseBaseTicketsFile.UseVisualStyleBackColor = true;
            this.button_ChooseBaseTicketsFile.Click += new System.EventHandler(this.Button_ChooseBaseTicketsFile_Click);
            // 
            // button_OpenBaseTicketsFile
            // 
            this.button_OpenBaseTicketsFile.Location = new System.Drawing.Point(666, 97);
            this.button_OpenBaseTicketsFile.Name = "button_OpenBaseTicketsFile";
            this.button_OpenBaseTicketsFile.Size = new System.Drawing.Size(84, 71);
            this.button_OpenBaseTicketsFile.TabIndex = 9;
            this.button_OpenBaseTicketsFile.Text = "打开模板车票目录";
            this.button_OpenBaseTicketsFile.UseVisualStyleBackColor = true;
            this.button_OpenBaseTicketsFile.Click += new System.EventHandler(this.Button_OpenBaseTicketsFile_Click);
            // 
            // button_BaseTicketsOrinFile
            // 
            this.button_BaseTicketsOrinFile.Location = new System.Drawing.Point(756, 97);
            this.button_BaseTicketsOrinFile.Name = "button_BaseTicketsOrinFile";
            this.button_BaseTicketsOrinFile.Size = new System.Drawing.Size(85, 71);
            this.button_BaseTicketsOrinFile.TabIndex = 10;
            this.button_BaseTicketsOrinFile.Text = "还原默认模板车票目录";
            this.button_BaseTicketsOrinFile.UseVisualStyleBackColor = true;
            this.button_BaseTicketsOrinFile.Click += new System.EventHandler(this.Button_BaseTicketsOrinFile_Click);
            // 
            // button_ChooseFinishTicketsFile
            // 
            this.button_ChooseFinishTicketsFile.Location = new System.Drawing.Point(581, 174);
            this.button_ChooseFinishTicketsFile.Name = "button_ChooseFinishTicketsFile";
            this.button_ChooseFinishTicketsFile.Size = new System.Drawing.Size(79, 71);
            this.button_ChooseFinishTicketsFile.TabIndex = 12;
            this.button_ChooseFinishTicketsFile.Text = "选择导出车票目录";
            this.button_ChooseFinishTicketsFile.UseVisualStyleBackColor = true;
            this.button_ChooseFinishTicketsFile.Click += new System.EventHandler(this.Button_ChooseFinishTicketsFile_Click);
            // 
            // button_OpenFinishTicketsFile
            // 
            this.button_OpenFinishTicketsFile.Location = new System.Drawing.Point(666, 174);
            this.button_OpenFinishTicketsFile.Name = "button_OpenFinishTicketsFile";
            this.button_OpenFinishTicketsFile.Size = new System.Drawing.Size(84, 71);
            this.button_OpenFinishTicketsFile.TabIndex = 13;
            this.button_OpenFinishTicketsFile.Text = "打开导出车票目录";
            this.button_OpenFinishTicketsFile.UseVisualStyleBackColor = true;
            this.button_OpenFinishTicketsFile.Click += new System.EventHandler(this.Button_OpenFinishTicketsFile_Click);
            // 
            // button_FinishTicketsOrinFile
            // 
            this.button_FinishTicketsOrinFile.Location = new System.Drawing.Point(756, 174);
            this.button_FinishTicketsOrinFile.Name = "button_FinishTicketsOrinFile";
            this.button_FinishTicketsOrinFile.Size = new System.Drawing.Size(85, 71);
            this.button_FinishTicketsOrinFile.TabIndex = 14;
            this.button_FinishTicketsOrinFile.Text = "还原默认导出车票目录";
            this.button_FinishTicketsOrinFile.UseVisualStyleBackColor = true;
            this.button_FinishTicketsOrinFile.Click += new System.EventHandler(this.Button_FinishTicketsOrinFile_Click);
            // 
            // label_OrinTicket
            // 
            this.label_OrinTicket.AutoSize = true;
            this.label_OrinTicket.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrinTicket.Location = new System.Drawing.Point(22, 50);
            this.label_OrinTicket.Name = "label_OrinTicket";
            this.label_OrinTicket.Size = new System.Drawing.Size(139, 20);
            this.label_OrinTicket.TabIndex = 15;
            this.label_OrinTicket.Text = "原始车票目录:";
            // 
            // textBox_Orinticketpath
            // 
            this.textBox_Orinticketpath.Location = new System.Drawing.Point(157, 45);
            this.textBox_Orinticketpath.Name = "textBox_Orinticketpath";
            this.textBox_Orinticketpath.Size = new System.Drawing.Size(395, 25);
            this.textBox_Orinticketpath.TabIndex = 16;
            this.textBox_Orinticketpath.TextChanged += new System.EventHandler(this.TextBox_Orinticketpath_TextChanged);
            // 
            // textBox_Baseticketpath
            // 
            this.textBox_Baseticketpath.Location = new System.Drawing.Point(157, 122);
            this.textBox_Baseticketpath.Name = "textBox_Baseticketpath";
            this.textBox_Baseticketpath.Size = new System.Drawing.Size(395, 25);
            this.textBox_Baseticketpath.TabIndex = 18;
            this.textBox_Baseticketpath.TextChanged += new System.EventHandler(this.TextBox_Baseticketpath_TextChanged);
            // 
            // label_BaseTicket
            // 
            this.label_BaseTicket.AutoSize = true;
            this.label_BaseTicket.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_BaseTicket.Location = new System.Drawing.Point(22, 127);
            this.label_BaseTicket.Name = "label_BaseTicket";
            this.label_BaseTicket.Size = new System.Drawing.Size(139, 20);
            this.label_BaseTicket.TabIndex = 17;
            this.label_BaseTicket.Text = "模板车票目录:";
            // 
            // textBox_Saveticketpath
            // 
            this.textBox_Saveticketpath.Location = new System.Drawing.Point(157, 199);
            this.textBox_Saveticketpath.Name = "textBox_Saveticketpath";
            this.textBox_Saveticketpath.Size = new System.Drawing.Size(395, 25);
            this.textBox_Saveticketpath.TabIndex = 20;
            this.textBox_Saveticketpath.TextChanged += new System.EventHandler(this.TextBox_Saveticketpath_TextChanged);
            // 
            // label_SaveTicket
            // 
            this.label_SaveTicket.AutoSize = true;
            this.label_SaveTicket.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SaveTicket.Location = new System.Drawing.Point(22, 204);
            this.label_SaveTicket.Name = "label_SaveTicket";
            this.label_SaveTicket.Size = new System.Drawing.Size(139, 20);
            this.label_SaveTicket.TabIndex = 19;
            this.label_SaveTicket.Text = "导出车票目录:";
            // 
            // button_SetOrinFile
            // 
            this.button_SetOrinFile.Location = new System.Drawing.Point(756, 251);
            this.button_SetOrinFile.Name = "button_SetOrinFile";
            this.button_SetOrinFile.Size = new System.Drawing.Size(85, 71);
            this.button_SetOrinFile.TabIndex = 24;
            this.button_SetOrinFile.Text = "还原默认配置文件目录";
            this.button_SetOrinFile.UseVisualStyleBackColor = true;
            this.button_SetOrinFile.Click += new System.EventHandler(this.Button_SetOrinFile_Click);
            // 
            // button_OpenSetFile
            // 
            this.button_OpenSetFile.Location = new System.Drawing.Point(666, 251);
            this.button_OpenSetFile.Name = "button_OpenSetFile";
            this.button_OpenSetFile.Size = new System.Drawing.Size(84, 71);
            this.button_OpenSetFile.TabIndex = 23;
            this.button_OpenSetFile.Text = "打开配置文件目录";
            this.button_OpenSetFile.UseVisualStyleBackColor = true;
            this.button_OpenSetFile.Click += new System.EventHandler(this.Button_OpenSetFile_Click);
            // 
            // button_ChooseSetFile
            // 
            this.button_ChooseSetFile.Location = new System.Drawing.Point(581, 251);
            this.button_ChooseSetFile.Name = "button_ChooseSetFile";
            this.button_ChooseSetFile.Size = new System.Drawing.Size(79, 71);
            this.button_ChooseSetFile.TabIndex = 22;
            this.button_ChooseSetFile.Text = "选择配置文件目录";
            this.button_ChooseSetFile.UseVisualStyleBackColor = true;
            this.button_ChooseSetFile.Click += new System.EventHandler(this.Button_ChooseSetFile_Click);
            // 
            // textBox_Setpath
            // 
            this.textBox_Setpath.Location = new System.Drawing.Point(157, 276);
            this.textBox_Setpath.Name = "textBox_Setpath";
            this.textBox_Setpath.Size = new System.Drawing.Size(395, 25);
            this.textBox_Setpath.TabIndex = 26;
            this.textBox_Setpath.TextChanged += new System.EventHandler(this.TextBox_Setpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "配置文件目录:";
            // 
            // panel_FileSet
            // 
            this.panel_FileSet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_FileSet.Controls.Add(this.textBox_Setpath);
            this.panel_FileSet.Controls.Add(this.label1);
            this.panel_FileSet.Controls.Add(this.button_SetOrinFile);
            this.panel_FileSet.Controls.Add(this.button_OpenSetFile);
            this.panel_FileSet.Controls.Add(this.button_ChooseSetFile);
            this.panel_FileSet.Controls.Add(this.textBox_Saveticketpath);
            this.panel_FileSet.Controls.Add(this.label_SaveTicket);
            this.panel_FileSet.Controls.Add(this.textBox_Baseticketpath);
            this.panel_FileSet.Controls.Add(this.label_BaseTicket);
            this.panel_FileSet.Controls.Add(this.textBox_Orinticketpath);
            this.panel_FileSet.Controls.Add(this.label_OrinTicket);
            this.panel_FileSet.Controls.Add(this.button_FinishTicketsOrinFile);
            this.panel_FileSet.Controls.Add(this.button_OpenFinishTicketsFile);
            this.panel_FileSet.Controls.Add(this.button_ChooseFinishTicketsFile);
            this.panel_FileSet.Controls.Add(this.button_BaseTicketsOrinFile);
            this.panel_FileSet.Controls.Add(this.button_OpenBaseTicketsFile);
            this.panel_FileSet.Controls.Add(this.button_ChooseBaseTicketsFile);
            this.panel_FileSet.Controls.Add(this.button_OrinTicketsOrinFile);
            this.panel_FileSet.Controls.Add(this.button_OpenOrinTicketsFile);
            this.panel_FileSet.Controls.Add(this.button_ChooseOrinTicketsFile);
            this.panel_FileSet.Location = new System.Drawing.Point(222, 0);
            this.panel_FileSet.Name = "panel_FileSet";
            this.panel_FileSet.Size = new System.Drawing.Size(865, 639);
            this.panel_FileSet.TabIndex = 27;
            // 
            // panel_IDSet
            // 
            this.panel_IDSet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_IDSet.Controls.Add(this.button_DeletePeopleID);
            this.panel_IDSet.Controls.Add(this.listBox_ID);
            this.panel_IDSet.Controls.Add(this.listBox_Name);
            this.panel_IDSet.Controls.Add(this.button_Caozuo);
            this.panel_IDSet.Controls.Add(this.label_ID);
            this.panel_IDSet.Controls.Add(this.label_Name);
            this.panel_IDSet.Controls.Add(this.textBox_ID);
            this.panel_IDSet.Controls.Add(this.textBox_Name);
            this.panel_IDSet.Location = new System.Drawing.Point(219, 0);
            this.panel_IDSet.Name = "panel_IDSet";
            this.panel_IDSet.Size = new System.Drawing.Size(865, 639);
            this.panel_IDSet.TabIndex = 31;
            // 
            // button_DeletePeopleID
            // 
            this.button_DeletePeopleID.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DeletePeopleID.Location = new System.Drawing.Point(664, 152);
            this.button_DeletePeopleID.Name = "button_DeletePeopleID";
            this.button_DeletePeopleID.Size = new System.Drawing.Size(180, 60);
            this.button_DeletePeopleID.TabIndex = 7;
            this.button_DeletePeopleID.Text = "删除";
            this.button_DeletePeopleID.UseVisualStyleBackColor = true;
            this.button_DeletePeopleID.Click += new System.EventHandler(this.Button_DeletePeopleID_Click);
            // 
            // listBox_ID
            // 
            this.listBox_ID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_ID.FormattingEnabled = true;
            this.listBox_ID.ItemHeight = 20;
            this.listBox_ID.Location = new System.Drawing.Point(256, 152);
            this.listBox_ID.Name = "listBox_ID";
            this.listBox_ID.Size = new System.Drawing.Size(373, 424);
            this.listBox_ID.TabIndex = 6;
            this.listBox_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_ID_MouseClick);
            this.listBox_ID.SelectedIndexChanged += new System.EventHandler(this.ListBox_ID_SelectedIndexChanged);
            // 
            // listBox_Name
            // 
            this.listBox_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_Name.FormattingEnabled = true;
            this.listBox_Name.ItemHeight = 20;
            this.listBox_Name.Location = new System.Drawing.Point(55, 152);
            this.listBox_Name.Name = "listBox_Name";
            this.listBox_Name.Size = new System.Drawing.Size(195, 424);
            this.listBox_Name.TabIndex = 5;
            this.listBox_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_Name_MouseClick);
            this.listBox_Name.SelectedIndexChanged += new System.EventHandler(this.ListBox_Name_SelectedIndexChanged);
            // 
            // button_Caozuo
            // 
            this.button_Caozuo.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Caozuo.Location = new System.Drawing.Point(664, 40);
            this.button_Caozuo.Name = "button_Caozuo";
            this.button_Caozuo.Size = new System.Drawing.Size(180, 60);
            this.button_Caozuo.TabIndex = 4;
            this.button_Caozuo.Text = "添加";
            this.button_Caozuo.UseVisualStyleBackColor = true;
            this.button_Caozuo.Click += new System.EventHandler(this.Button_Caozuo_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(36, 77);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(125, 25);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "身份证号:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name.Location = new System.Drawing.Point(86, 40);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(75, 25);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "姓名:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(180, 76);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(357, 25);
            this.textBox_ID.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(180, 43);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(163, 25);
            this.textBox_Name.TabIndex = 0;
            // 
            // label_SetFile
            // 
            this.label_SetFile.AutoSize = true;
            this.label_SetFile.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SetFile.Location = new System.Drawing.Point(12, 28);
            this.label_SetFile.Name = "label_SetFile";
            this.label_SetFile.Size = new System.Drawing.Size(177, 40);
            this.label_SetFile.TabIndex = 28;
            this.label_SetFile.Text = "文件目录";
            this.label_SetFile.Click += new System.EventHandler(this.Label_SetFile_Click);
            // 
            // label_IDSET
            // 
            this.label_IDSET.AutoSize = true;
            this.label_IDSET.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IDSET.Location = new System.Drawing.Point(52, 98);
            this.label_IDSET.Name = "label_IDSET";
            this.label_IDSET.Size = new System.Drawing.Size(137, 40);
            this.label_IDSET.TabIndex = 29;
            this.label_IDSET.Text = "身份证";
            this.label_IDSET.Click += new System.EventHandler(this.LabelIDSET_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 641);
            this.Controls.Add(this.label_IDSET);
            this.Controls.Add(this.label_SetFile);
            this.Controls.Add(this.panel_IDSet);
            this.Controls.Add(this.panel_FileSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel_FileSet.ResumeLayout(false);
            this.panel_FileSet.PerformLayout();
            this.panel_IDSet.ResumeLayout(false);
            this.panel_IDSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button_ChooseOrinTicketsFile;
        private System.Windows.Forms.Button button_OpenOrinTicketsFile;
        private System.Windows.Forms.Button button_OrinTicketsOrinFile;
        private System.Windows.Forms.Button button_ChooseBaseTicketsFile;
        private System.Windows.Forms.Button button_OpenBaseTicketsFile;
        private System.Windows.Forms.Button button_BaseTicketsOrinFile;
        private System.Windows.Forms.Button button_ChooseFinishTicketsFile;
        private System.Windows.Forms.Button button_OpenFinishTicketsFile;
        private System.Windows.Forms.Button button_FinishTicketsOrinFile;
        private System.Windows.Forms.Label label_OrinTicket;
        public System.Windows.Forms.TextBox textBox_Orinticketpath;
        public System.Windows.Forms.TextBox textBox_Baseticketpath;
        private System.Windows.Forms.Label label_BaseTicket;
        public System.Windows.Forms.TextBox textBox_Saveticketpath;
        private System.Windows.Forms.Label label_SaveTicket;
        private System.Windows.Forms.Button button_SetOrinFile;
        private System.Windows.Forms.Button button_OpenSetFile;
        private System.Windows.Forms.Button button_ChooseSetFile;
        public System.Windows.Forms.TextBox textBox_Setpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_FileSet;
        private System.Windows.Forms.Label label_SetFile;
        private System.Windows.Forms.Panel panel_IDSet;
        private System.Windows.Forms.Label label_IDSET;
        private System.Windows.Forms.Button button_DeletePeopleID;
        private System.Windows.Forms.ListBox listBox_ID;
        private System.Windows.Forms.ListBox listBox_Name;
        private System.Windows.Forms.Button button_Caozuo;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}