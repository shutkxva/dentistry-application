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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand3.ExecuteReader());
            uslugi.DataSource = temp;
            sqlConnection1.Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            this.стоматологTableAdapter.Fill(this.стоматологияDataSet.Стоматолог);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand2.ExecuteReader());
            doctors.DataSource = temp;
            sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@post"].Value = comboBox1.Text;
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand1.ExecuteReader());
            doctors.DataSource = temp;
            sqlConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usluga.Text == "")
                message.Text = "Введите название услуги!";
            else
            {
                sqlCommand4.Parameters["@usluga"].Value = usluga.Text;
                sqlCommand5.Parameters["@usluga"].Value = usluga.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand4.ExecuteReader());
                sqlCommand5.ExecuteReader();
                uslugi.DataSource = temp;
                string res = sqlCommand5.Parameters["@text"].Value.ToString();
                message.Text = res;
                sqlConnection1.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (priceTo.Text == "" && priceFrom.Text == "")
                message.Text = "Введите данные!";
            else
            {
                MessageBox.Show("В таблице представлены цены на услуги стоматологии, однако после первичного осмотра стоимость услуги может выйти другой",
        "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (priceTo.Text != "" && priceFrom.Text == "")
                {
                    sqlCommand7.Parameters["@priceTo"].Value = Convert.ToInt32(priceTo.Text);
                    sqlConnection1.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommand7.ExecuteReader());
                    uslugi.DataSource = temp;
                    sqlConnection1.Close();

                }
                else if (priceFrom.Text != "" && priceTo.Text == "")
                {
                    sqlCommand8.Parameters["@priceFrom"].Value = Convert.ToInt32(priceFrom.Text);
                    sqlConnection1.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommand8.ExecuteReader());
                    uslugi.DataSource = temp;
                    sqlConnection1.Close();
                }
                else if (priceTo.Text != "" && priceFrom.Text != "")
                {
                    sqlCommand9.Parameters["@priceFrom"].Value = Convert.ToInt32(priceFrom.Text);
                    sqlCommand9.Parameters["@priceTo"].Value = Convert.ToInt32(priceTo.Text);
                    sqlConnection1.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommand9.ExecuteReader());
                    uslugi.DataSource = temp;
                    sqlConnection1.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand3.ExecuteReader());
            uslugi.DataSource = temp;
            sqlConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fio.Text == "" || pochta.Text == "")
                text.Text = "Введены не все данные!";
            else
            {
                sqlCommand10.Parameters["@fio"].Value = fio.Text;
                sqlCommand10.Parameters["@pochta"].Value = pochta.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand10.ExecuteReader());
                uslugiPa.DataSource = temp;
                sqlConnection1.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fio.Text == "" || pochta.Text == "" || uslugaa.Text == "")
                text.Text = "Введены не все данные!";
            else
            {
                sqlCommand11.Parameters["@fio"].Value = fio.Text;
                sqlCommand12.Parameters["@fio"].Value = fio.Text;
                sqlCommand11.Parameters["@pochta"].Value = pochta.Text;
                sqlCommand12.Parameters["@pochta"].Value = pochta.Text;
                sqlCommand11.Parameters["@usluga"].Value = uslugaa.Text;
                sqlCommand12.Parameters["@usluga"].Value = uslugaa.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand11.ExecuteReader());
                uslugiPa.DataSource = temp;
                sqlCommand12.ExecuteReader();
                string res = sqlCommand12.Parameters["@text"].Value.ToString();
                text.Text = res;
                sqlConnection1.Close();
            }
        }

        private void priceFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
       }

        private void priceTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
