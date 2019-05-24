using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] SList = new string[]{"홍차", "녹차", "루이보스차" ,"국화차"};
        int count = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (comboBox.Text=="홍차")
            {
                count = 60 * 2;
                this.timer.Enabled = true;
            }
            if (comboBox.Text == "녹차")
            {
                count = 60 * 3;
                this.timer.Enabled = true;
            }
            if (comboBox.Text == "루이보스차")
            {
                count = 60 * 5;
                this.timer.Enabled = true;
            }
            if (comboBox.Text == "국화차")
            {
                count = 60 * 2;
                this.timer.Enabled = true;
            }
            else
            {
                this.comboBox.Text = "";
                this.comboBox.Focus();
            }

        }

        private void Form_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SList.Length; i++)
            {
                this.comboBox.Items.Add(SList[i]);
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (count < 1)
            {
                this.timer.Enabled = false;
                this.comboBox.Text = "";
                MessageBox.Show("티백을 건지세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox.Focus();
            }
            else
            {
                this.count--;
                this.textBox.Text = Convert.ToString((count/60) + "분" + (count%60) + "초 남았습니다.");
            }
        }
    }
}
