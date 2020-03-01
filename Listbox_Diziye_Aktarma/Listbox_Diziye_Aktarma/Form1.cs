using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Diziye_Aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] veriler1 = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                veriler1[i] = listBox1.Items[i].ToString();
            }
            label1.Text = veriler1[0];
            label2.Text = veriler1[1];
            label3.Text = veriler1[2];
        }
    }
}
