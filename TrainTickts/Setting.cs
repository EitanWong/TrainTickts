using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void Button_OpenOrinTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.LoudTicketsPath);
        }

        private void Button_OrinTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.LoudTicketsPath = TrainTicket.Orin_LoudTicketsPath;
            MessageBox.Show("原始车票目录已还原为:" + TrainTicket.LoudTicketsPath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void Button_OpenBaseTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.BaseTickfilePath);
        }

        private void Button_BaseTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.BaseTickfilePath = TrainTicket.Orin_BaseTickfilePath;
            MessageBox.Show("模板车票目录已还原为:" + TrainTicket.BaseTickfilePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void Button_OpenFinishTicketsFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TrainTicket.savePath);
        }

        private void Button_FinishTicketsOrinFile_Click(object sender, EventArgs e)
        {
            TrainTicket.savePath = TrainTicket.Orin_savePath;
            MessageBox.Show("导出车票目录已还原为:" + TrainTicket.savePath, "车票目录", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
