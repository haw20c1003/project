using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthy_food
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if(radioButton2.Checked)
            {
                Form7 form7 = new Form7();
                form7.Show();
            }
            else
            {
                Form9 form9 = new Form9();
                form9.Show();
            }
            this.Hide();

             






        }

        private void True(object sender, EventArgs e)
        {

        }
    }
}
