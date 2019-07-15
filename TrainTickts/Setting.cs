using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsBase;

namespace TrainTickts
{
    public partial class Setting : Form
    {
       // public static Setting _S;
        public Setting()
        {
           // _S = this;
            InitializeComponent();
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            textBox_Orinticketpath.Text = TrainTicket.LoudTicketsPath;
            textBox_Baseticketpath.Text = TrainTicket.BaseTickfilePath;
            textBox_Saveticketpath.Text = TrainTicket.savePath;
            textBox_Setpath.Text = TrainTicket.SetPath;
            TrainTicket.OnPeopIDUpdated += UpdatePeopIDView;
            UpdatePeopIDView();
            PanelIsDisplay(1);


        }



        private void UpdatePeopIDView()
        {
            listBox_Name.Items.Clear();
            listBox_ID.Items.Clear();
            foreach (var item in TrainTicket.People_ID)
            {
                if (item != null)
                {
                    listBox_Name.Items.Add(item.name);
                    listBox_ID.Items.Add(item.id);
                }

            }
        }

        private void Button_ChooseOrinTicketsFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TrainTicket.LoudTicketsPath = dialog.SelectedPath;
                MessageBox.Show("已选择原始车票文件夹:" + TrainTicket.LoudTicketsPath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_Orinticketpath.Text = TrainTicket.LoudTicketsPath;
        }

        private void Button_OpenOrinTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.LoudTicketsPath);
        }

        private void Button_OrinTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.LoudTicketsPath = TrainTicket.Orin_LoudTicketsPath;
            MessageBox.Show("原始车票目录已还原为:" + TrainTicket.LoudTicketsPath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_Orinticketpath.Text = TrainTicket.LoudTicketsPath;
        }

        private void Button_ChooseBaseTicketsFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TrainTicket.BaseTickfilePath = dialog.SelectedPath;
                MessageBox.Show("已选择模板车票文件夹:" + TrainTicket.BaseTickfilePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_Baseticketpath.Text = TrainTicket.BaseTickfilePath;
        }

        private void Button_OpenBaseTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.BaseTickfilePath);
        }

        private void Button_BaseTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.BaseTickfilePath = TrainTicket.Orin_BaseTickfilePath;
            MessageBox.Show("模板车票目录已还原为:" + TrainTicket.BaseTickfilePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_Baseticketpath.Text = TrainTicket.BaseTickfilePath;
        }

        private void Button_ChooseFinishTicketsFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TrainTicket.savePath = dialog.SelectedPath;
                MessageBox.Show("已选择导出车票文件夹:" + TrainTicket.savePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_Saveticketpath.Text = TrainTicket.savePath;
        }

        private void Button_OpenFinishTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.savePath);
        }

        private void Button_FinishTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.savePath = TrainTicket.Orin_savePath;
            MessageBox.Show("导出车票目录已还原为:" + TrainTicket.savePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_Saveticketpath.Text = TrainTicket.savePath;
        }

        private void TextBox_Orinticketpath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_Orinticketpath.Text))
            {
                TrainTicket.LoudTicketsPath = textBox_Orinticketpath.Text;
            }
            else
            {
                MessageBox.Show("不存在目录:" + textBox_Orinticketpath.Text, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // sender
            textBox_Orinticketpath.Text = TrainTicket.LoudTicketsPath;
        }

        private void TextBox_Baseticketpath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_Baseticketpath.Text))
            {
                TrainTicket.LoudTicketsPath = textBox_Baseticketpath.Text;
            }
            else
            {
                MessageBox.Show("不存在目录:" + textBox_Baseticketpath.Text, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // sender
            textBox_Baseticketpath.Text = TrainTicket.BaseTickfilePath;
        }

        private void TextBox_Saveticketpath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_Saveticketpath.Text))
            {
                TrainTicket.LoudTicketsPath = textBox_Saveticketpath.Text;
            }
            else
            {
                MessageBox.Show("不存在目录:" + textBox_Saveticketpath.Text, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // sender
            textBox_Saveticketpath.Text = TrainTicket.savePath;
        }

        private void TextBox_Setpath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_Setpath.Text))
            {
                TrainTicket.SetPath = textBox_Setpath.Text;
            }
            else
            {
                MessageBox.Show("不存在目录:" + textBox_Setpath.Text, "配置目录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // sender
            textBox_Setpath.Text = TrainTicket.SetPath;
        }

        private void Button_ChooseSetFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TrainTicket.SetPath = dialog.SelectedPath;
                MessageBox.Show("已选择配置文件文件夹:" + TrainTicket.SetPath, "配置文件目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_Setpath.Text = TrainTicket.SetPath;
        }

        private void Button_OpenSetFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.SetPath);
        }

        private void Button_SetOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.SetPath = TrainTicket.Orin_SetPath;
            MessageBox.Show("配置文件目录已还原为:" + TrainTicket.SetPath, "配置文件目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_Setpath.Text = TrainTicket.SetPath;
        }

        private void Label_SetFile_Click(object sender, EventArgs e)
        {
            PanelIsDisplay(1);
        }

        private void LabelIDSET_Click(object sender, EventArgs e)
        {
            PanelIsDisplay(2);
        }

        private void Label_SkinSet_Click(object sender, EventArgs e)
        {
           // PanelIsDisplay(3);
        }
        public void LoadIDinfo()
        {

        }
        private void PanelIsDisplay(int p)
        {
            //设置panel显示界面 (IE\Word\回收站\U盘\电脑\文件粉碎)
            panel_FileSet.Visible = false;
            panel_IDSet.Visible = false;
            //anel_SkinSet.Visible = false;
            switch (p)
            {
                case 1:  //显示"清除IE"
                    {
                        panel_FileSet.Visible = true;
                    }
                    break;
                case 2:  //显示"清除Word"
                    {
                        panel_IDSet.Visible = true;
                    }
                    break;
                case 3:  //显示"清空回收站"
                    {
                       // panel_SkinSet.Visible = true;
                    }
                    break;
                default:
                    {
                    }
                    break;
            }
        }

        private void ListBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_ID.SelectedIndex = listBox_Name.SelectedIndex;
            if (listBox_Name.SelectedIndex == -1)
            {
                textBox_Name.Text = null;
                return;
            }
            textBox_Name.Text =listBox_Name.SelectedItem.ToString();
            SlectName = textBox_Name.Text;
            button_Caozuo.Text = "修改";
        }

        private void ListBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Name.SelectedIndex = listBox_ID.SelectedIndex;
            if (listBox_ID.SelectedIndex == -1)
            {
                textBox_ID.Text = null;
                return;
            }
            textBox_ID.Text = listBox_ID.SelectedItem.ToString();
            SlectID = textBox_ID.Text;
            button_Caozuo.Text = "修改";
        }

        private void ListBox_Name_MouseClick(object sender, MouseEventArgs e)
        {
            var index = listBox_Name.IndexFromPoint(e.X, e.Y);
            listBox_Name.SelectedIndex = index;
            if (index == -1)
            {
                listBox_Name.ClearSelected();
                button_Caozuo.Text = "添加";
                textBox_ID.Text = null;
                textBox_Name.Text = null;
            }

        }
        private void ListBox_ID_MouseClick(object sender, MouseEventArgs e)
        {
            var index = listBox_ID.IndexFromPoint(e.X, e.Y);
            listBox_ID.SelectedIndex = index;
            if (index == -1)
            {
                listBox_ID.ClearSelected();
                button_Caozuo.Text = "添加";
                textBox_ID.Text = null;
                textBox_Name.Text = null;
            }
        }

        private void Button_Caozuo_Click(object sender, EventArgs e)
        {
            if (button_Caozuo.Text == "添加")
            {
                CreatePeopleID(textBox_Name.Text, textBox_ID.Text);

            }
            else if(button_Caozuo.Text == "修改")
            {

                ChangePeopleID(textBox_Name.Text, textBox_ID.Text);
            }       
        }
       string SlectName=null;
        string SlectID = null;
        public void ChangePeopleID(string Name,string ID)
        {
            if (SlectName == null || SlectID == null)
                return;
            if (String.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (String.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("身份证不能为空");
                return;
            }
            var GetInfo = TrainTicket.GetPeopleID(SlectName);
            //object id = ID;
            GetInfo.id= ID;
            GetInfo.name =  (Name);

           // TrainTicket.People_ID.Add(info);
            TrainTicket.SavePeopID();
            TrainTicket.UpdatePeopID();
        }
        public void CreatePeopleID(string Name, string ID)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (String.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("身份证不能为空");
                return;
            }
            if (TrainTicket.GetPeopleID(Name)!=null)
            {
                MessageBox.Show("你已经创建了此这货的身份证了");
                listBox_Name.SelectedItem = Name;
                return;
            }
            TrainTicket.People_ID.Add(new IDinfo
            {
                id=ID,
                name=Name
            });

            TrainTicket.SavePeopID();
            TrainTicket.UpdatePeopID();
            textBox_ID.Text = null;
            textBox_Name.Text = null;
        }
        public void DeletePeopleID()
        {
            if (String.IsNullOrWhiteSpace(SlectName))
            {
                MessageBox.Show("选都没选，删个鬼？");
                return;
            }
           TrainTicket.People_ID.Remove(TrainTicket.GetPeopleID(SlectName));
            TrainTicket.SavePeopID();
            TrainTicket.UpdatePeopID();
            button_Caozuo.Text = "添加";
            textBox_Name.Text = null;
            textBox_ID.Text = null;
        }

        private void Button_DeletePeopleID_Click(object sender, EventArgs e)
        {
            DeletePeopleID();
            if (listBox_ID.Items.Count <= 0 || listBox_Name.Items.Count <= 0)
            {
                button_Caozuo.Text = "添加";
                textBox_Name.Text = null;
                textBox_ID.Text = null;
            }
        }
    }
   
}
