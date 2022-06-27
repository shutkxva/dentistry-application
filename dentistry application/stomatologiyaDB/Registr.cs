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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
            dateBirth.MaxDate = DateTime.Today.AddDays(-2190);
            datePriem.MinDate = DateTime.Now;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                resultFindC.Text = "Введите ФИО!";
            else
            {
                sqlCommand2.Parameters["@fio"].Value = textBox6.Text;
                sqlCommand3.Parameters["@fio"].Value = textBox6.Text;
                sqlConnection1.Open();
                var temp = new DataTable();
                temp.Load(sqlCommand2.ExecuteReader());
                sqlCommand3.ExecuteReader();
                clients.DataSource = temp;
                string res = sqlCommand3.Parameters["@text"].Value.ToString();
                resultFindC.Text = res;
                sqlConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand1.ExecuteReader());
            clients.DataSource = temp;
            sqlConnection1.Close();
        }

        private void Registr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.стоматологияDataSet.Пациент);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                clients.Sort(фИОDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending);
            else
                clients.Sort(фИОDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fioPatient.Text == "" || emailClient.Text == "")
                resultAddClient.Text = "Введены не все данные!";
            else
            {
                sqlCommand4.Parameters["@name"].Value = fioPatient.Text;
                sqlCommand4.Parameters["@birth"].Value = dateBirth.Value;
                sqlCommand4.Parameters["@email"].Value = emailClient.Text;
                sqlConnection1.Open();
                sqlCommand4.ExecuteNonQuery();
                sqlConnection1.Close();
                string res = (string)sqlCommand4.Parameters["@text"].Value;
                resultAddClient.Text = Convert.ToString(res);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("При удалении данных о пациенте удалятся так же все его приемы. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Int32 selectedRowsCount = clients.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowsCount > 0)
                {
                    for (int i = 0; i < selectedRowsCount; i++)
                    {
                        var kod = clients.SelectedRows[i].Cells[0].Value.ToString();
                        sqlCommand5.Parameters["@idPa"].Value = Convert.ToInt32(kod);
                        sqlConnection1.Open();
                        sqlCommand5.ExecuteNonQuery();
                        sqlConnection1.Close();
                        string res = (string)sqlCommand5.Parameters["@text"].Value;
                        resultFindC.Text = Convert.ToString(res);
                    }
                }
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fiooPatient.Text == "" || fioDoctor.Text == "" || mailPatient.Text == "")
                resPerOsm.Text = "Введены не все данные!";
            else
            {
                sqlCommand6.Parameters["@fiooPatient"].Value = fiooPatient.Text;
                sqlCommand6.Parameters["@mailPatient"].Value = mailPatient.Text;
                sqlCommand6.Parameters["@fioDoctor"].Value = fioDoctor.Text;
                sqlCommand6.Parameters["@datePriem"].Value = datePriem.Value;
                sqlConnection1.Open();
                sqlCommand6.ExecuteNonQuery();
                sqlConnection1.Close();
                string res = (string)sqlCommand6.Parameters["@message"].Value;
                resPerOsm.Text = Convert.ToString(res);
            }
        }

        private void Registr_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
