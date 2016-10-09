using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int i;
            int j;
            if (hScrollBar1.Value > hScrollBar2.Value)
            {
                i = hScrollBar2.Value;
                j = hScrollBar1.Value;
            }
            else { i = hScrollBar1.Value; j = hScrollBar2.Value; }
            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = hScrollBar2.Value.ToString();
            label4.Text = "MIN : " + i.ToString();
            label3.Text = "MAX : " + j.ToString();
            DateTime DoT = DateTime.Today;
            dateTimePicker1.MinDate = DoT;
            dateTimePicker1.MaxDate = new DateTime(DoT.Year + (j - i), DoT.Month, DoT.Day);
        }
    }
}
