using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            switch (a)
            {
                case 1:
                    MessageBox.Show("a is 1");
                    break;
                case 2:
                    MessageBox.Show("a is 2");
                    break;
                case 3:
                    MessageBox.Show("a is 3");
                    break;
                default:
                    MessageBox.Show("it is a default");
                    break;
            }
        }
    }
}
