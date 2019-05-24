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
        string[] cblist = new string[]{"홍차", "녹차", "루이보스차" ,"국화차"};
        public Form()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
