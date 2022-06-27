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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            date.MinDate = DateTime.Now;
            birth.MaxDate = DateTime.Today.AddDays(-2190);
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand2.ExecuteReader());
            priem.DataSource = temp;
            sqlConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.usluga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            if (usluga.Text == "Первичный осмотр")
                cost.Text = "200";
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.стоматологияDataSet.Услуга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Перечень". При необходимости она может быть перемещена или удалена.
            this.переченьTableAdapter.Fill(this.стоматологияDataSet.Перечень);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Прием". При необходимости она может быть перемещена или удалена.
            this.приемTableAdapter.Fill(this.стоматологияDataSet.Прием);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Услуга". При необходимости она может быть перемещена или удалена.
            this.услугаTableAdapter.Fill(this.стоматологияDataSet.Услуга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Перечень". При необходимости она может быть перемещена или удалена.
            this.переченьTableAdapter.Fill(this.стоматологияDataSet.Перечень);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Прием". При необходимости она может быть перемещена или удалена.
            this.приемTableAdapter.Fill(this.стоматологияDataSet.Прием);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cost.Text == "" || usluga.Text == "" || name.Text == "" || mail.Text == "" || numt.Text == "" || codeD.Text == "")
                resultAddClient.Text = "Введены не все данные!";
            else
            {

                sqlCommand1.Parameters["@date"].Value = date.Value;
                sqlCommand1.Parameters["@cost"].Value = cost.Text;
                sqlCommand1.Parameters["@usluga"].Value = usluga.Text;
                sqlCommand1.Parameters["@name"].Value = name.Text;
                sqlCommand1.Parameters["@mail"].Value = mail.Text;
                sqlCommand1.Parameters["@birth"].Value = birth.Value;
                sqlCommand1.Parameters["@numt"].Value = numt.Text;
                sqlCommand1.Parameters["@codeD"].Value = codeD.Text;
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                string res = (string)sqlCommand1.Parameters["@text"].Value;
                resultAddClient.Text = Convert.ToString(res);
            }
        }

        private void codeD_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.codeD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand2.ExecuteReader());
            priem.DataSource = temp;
            sqlConnection1.Close();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Int32 selectedRowsCount = priem.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount > 0)
            {
                for (int i = 0; i < selectedRowsCount; i++)
                {
                    var fioD = priem.SelectedRows[i].Cells[0].Value.ToString();
                    var fioP = priem.SelectedRows[i].Cells[2].Value.ToString();
                    var pochta = priem.SelectedRows[i].Cells[3].Value.ToString();
                    var date = priem.SelectedRows[i].Cells[4].Value.ToString();
                    sqlCommand3.Parameters["@fioD"].Value = fioD;
                    sqlCommand3.Parameters["@fioP"].Value = fioP;
                    sqlCommand3.Parameters["@pochta"].Value = pochta;
                    sqlCommand3.Parameters["@date"].Value = DateTime.Parse(date);
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection1.Close();
                    string res = (string)sqlCommand3.Parameters["@text"].Value;
                    message.Text = Convert.ToString(res);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (fioClient.Text == "")
                    message.Text = "Введите ФИО!";
                else
                {
                    sqlCommand4.Parameters["@fio"].Value = fioClient.Text;
                    sqlCommand7.Parameters["@fio"].Value = fioClient.Text;
                    sqlConnection1.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommand4.ExecuteReader());
                    sqlCommand7.ExecuteReader();
                    priem.DataSource = temp;
                    string res = sqlCommand7.Parameters["@text"].Value.ToString();
                    message.Text = res;
                    sqlConnection1.Close();
                }
            }
            if (checkBox2.Checked)
            {
                sqlCommand5.Parameters["@dateP"].Value = datePriem.Text;
                sqlCommand8.Parameters["@dateP"].Value = datePriem.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand5.ExecuteReader());
                priem.DataSource = temp;
                sqlCommand8.ExecuteReader();
                string res = sqlCommand8.Parameters["@text"].Value.ToString();
                message.Text = res;
                sqlConnection1.Close();
            }
            if (checkBox1.Checked & checkBox2.Checked)
            {
                if (fioClient.Text == "")
                    message.Text = "Введите ФИО!";
                else
                {
                    sqlCommand6.Parameters["@fio"].Value = fioClient.Text;
                    sqlCommand6.Parameters["@dateP"].Value = datePriem.Text;
                    sqlCommand8.Parameters["@dateP"].Value = datePriem.Text;
                    sqlConnection1.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommand6.ExecuteReader());
                    priem.DataSource = temp;
                    sqlCommand8.ExecuteReader();
                    string res = sqlCommand8.Parameters["@text"].Value.ToString();
                    message.Text = res;
                    sqlConnection1.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (idD.Text == "")
                resultID.Text = "Выберите ID!";
            else
            {
                resultID.Text = "";
                sqlCommand9.Parameters["@codeD"].Value = idD.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand9.ExecuteReader());
                usligi.DataSource = temp;
                sqlConnection1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idD.Text == "")
                resultID.Text = "Выберите ID!";
            else
            {
                if (uslugaInsDel.Text == "")
                    insdel.Text = "Введите название!";
                else
                {
                    sqlCommand10.Parameters["@codeD"].Value = idD.Text;
                    sqlCommand10.Parameters["@usluga"].Value = uslugaInsDel.Text;
                    sqlConnection1.Open();
                    sqlCommand10.ExecuteNonQuery();
                    sqlConnection1.Close();
                    string res = (string)sqlCommand10.Parameters["@text"].Value;
                    insdel.Text = Convert.ToString(res);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (idD.Text == "")
                resultID.Text = "Выберите ID!";
            else
            {
                if (uslugaInsDel.Text == "")
                    insdel.Text = "Введите название!";
                else
                {
                    sqlCommand11.Parameters["@codeD"].Value = idD.Text;
                    sqlCommand11.Parameters["@usluga"].Value = uslugaInsDel.Text;
                    sqlConnection1.Open();
                    sqlCommand11.ExecuteNonQuery();
                    sqlConnection1.Close();
                    string res = (string)sqlCommand11.Parameters["@text"].Value;
                    insdel.Text = Convert.ToString(res);
                }
            }
        }

        private void Doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Int32 selectedRowsCount = priemy.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowsCount > 0)
            {
                for (int i = 0; i < selectedRowsCount; i++)
                {
                    var fioD = priemy.SelectedRows[i].Cells[1].Value.ToString();
                    var fioP = priemy.SelectedRows[i].Cells[3].Value.ToString();
                    var pochta = priemy.SelectedRows[i].Cells[4].Value.ToString();
                    var date = priemy.SelectedRows[i].Cells[5].Value.ToString();
                    sqlCommand3.Parameters["@fioD"].Value = fioD;
                    sqlCommand3.Parameters["@fioP"].Value = fioP;
                    sqlCommand3.Parameters["@pochta"].Value = pochta;
                    sqlCommand3.Parameters["@date"].Value = DateTime.Parse(date);
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection1.Close();
                    string res = (string)sqlCommand3.Parameters["@text"].Value;
                    messageD.Text = Convert.ToString(res);
                }
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (idDD.Text == "")
                messageD.Text = "Выберите ID!";
            else
            {
                resultID.Text = "";
                sqlCommand12.Parameters["@idD"].Value = Convert.ToInt32(idDD.Text);
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand12.ExecuteReader());
                priemy.DataSource = temp;
                sqlConnection1.Close();
            }
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (costNew.Text == "")
                messageD.Text = "Ввведите данные!";
            else
            {
                Int32 selectedRowsCount = priemy.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowsCount > 0)
                {
                    for (int i = 0; i < selectedRowsCount; i++)
                    {
                        var idPr = priemy.SelectedRows[i].Cells[0].Value.ToString();
                        sqlCommand13.Parameters["@idPr"].Value = idPr;
                        sqlCommand13.Parameters["@ncost"].Value = Convert.ToInt32(costNew.Text);
                        sqlConnection1.Open();
                        sqlCommand13.ExecuteNonQuery();
                        string res = (string)sqlCommand13.Parameters["@text"].Value;
                        messageD.Text = Convert.ToString(res);
                        sqlConnection1.Close();
                    }
                }
            }
        }
    }
}