using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stomatologiyaDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Client frm = new Client();
            frm.FormClosed += (s, args) => Show();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auth forrm = new auth();
            forrm.FormClosed += (s, args) => Show();
            forrm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auth foorm = new auth();
            foorm.FormClosed += (s, args) => Show();
            foorm.Show();
            Hide();
        }
    }
}
