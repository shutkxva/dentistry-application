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
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "Doctor")
            {
                Doctor foorm = new Doctor();
                foorm.FormClosed += (s, args) => Show();
                foorm.Show();
                Hide();
            }
            else if (password.Text == "Registr")
            {
                Registr form = new Registr();
                form.FormClosed += (s, args) => Show();
                form.Show();
                Hide();
            }
            else
                message.Text = "Неверный пароль";
        }
    }
}
