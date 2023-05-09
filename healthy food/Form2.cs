using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace healthy_food
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Form3();
            login.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=True";
        }
    }
}
