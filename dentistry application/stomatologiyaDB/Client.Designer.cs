
namespace stomatologiyaDB
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.message = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.priceTo = new System.Windows.Forms.TextBox();
            this.priceFrom = new System.Windows.Forms.TextBox();
            this.usluga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uslugi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.doctors = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоматологBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоматологияDataSet = new stomatologiyaDB.СтоматологияDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.text = new System.Windows.Forms.Label();
            this.uslugaa = new System.Windows.Forms.TextBox();
            this.pochta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uslugiPa = new System.Windows.Forms.DataGridView();
            this.стоматологTableAdapter = new stomatologiyaDB.СтоматологияDataSetTableAdapters.СтоматологTableAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand12 = new System.Data.SqlClient.SqlCommand();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiPa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.message);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.priceTo);
            this.tabPage1.Controls.Add(this.priceFrom);
            this.tabPage1.Controls.Add(this.usluga);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.uslugi);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 10F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр услуг";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Pribambas", 15F);
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(326, 265);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 20);
            this.message.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(151, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Список услуг клиники";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(217, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "Показать";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(423, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Показать все";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(37, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Искать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // priceTo
            // 
            this.priceTo.Location = new System.Drawing.Point(291, 232);
            this.priceTo.Name = "priceTo";
            this.priceTo.Size = new System.Drawing.Size(75, 24);
            this.priceTo.TabIndex = 7;
            this.priceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTo_KeyPress);
            // 
            // priceFrom
            // 
            this.priceFrom.Location = new System.Drawing.Point(291, 204);
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.Size = new System.Drawing.Size(75, 24);
            this.priceFrom.TabIndex = 6;
            this.priceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceFrom_KeyPress);
            // 
            // usluga
            // 
            this.usluga.Location = new System.Drawing.Point(10, 232);
            this.usluga.Name = "usluga";
            this.usluga.Size = new System.Drawing.Size(190, 24);
            this.usluga.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label5.Location = new System.Drawing.Point(217, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена до:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label4.Location = new System.Drawing.Point(217, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена от:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите название услуги:";
            // 
            // uslugi
            // 
            this.uslugi.AllowUserToAddRows = false;
            this.uslugi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F);
            this.uslugi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uslugi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uslugi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uslugi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uslugi.Location = new System.Drawing.Point(10, 34);
            this.uslugi.Name = "uslugi";
            this.uslugi.Size = new System.Drawing.Size(514, 163);
            this.uslugi.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.doctors);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Просмотр списка сотрудников";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(165, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Список сотрудников";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ортодонт",
            "Стоматолог-терапевт",
            "Стоматолог-хирург"});
            this.comboBox1.Location = new System.Drawing.Point(384, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(383, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать все";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(383, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label1.Location = new System.Drawing.Point(370, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите должность:";
            // 
            // doctors
            // 
            this.doctors.AllowUserToAddRows = false;
            this.doctors.AllowUserToDeleteRows = false;
            this.doctors.AutoGenerateColumns = false;
            this.doctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.doctors.DataSource = this.стоматологBindingSource;
            this.doctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.doctors.Location = new System.Drawing.Point(4, 40);
            this.doctors.Name = "doctors";
            this.doctors.Size = new System.Drawing.Size(366, 238);
            this.doctors.TabIndex = 0;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // стоматологBindingSource
            // 
            this.стоматологBindingSource.DataMember = "Стоматолог";
            this.стоматологBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // стоматологияDataSet
            // 
            this.стоматологияDataSet.DataSetName = "СтоматологияDataSet";
            this.стоматологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.text);
            this.tabPage3.Controls.Add(this.uslugaa);
            this.tabPage3.Controls.Add(this.pochta);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.fio);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.uslugiPa);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 10F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(539, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Просмотр полученных услуг";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Pribambas", 15F);
            this.text.ForeColor = System.Drawing.Color.Red;
            this.text.Location = new System.Drawing.Point(158, 273);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 20);
            this.text.TabIndex = 12;
            // 
            // uslugaa
            // 
            this.uslugaa.Location = new System.Drawing.Point(348, 224);
            this.uslugaa.Name = "uslugaa";
            this.uslugaa.Size = new System.Drawing.Size(180, 24);
            this.uslugaa.TabIndex = 11;
            // 
            // pochta
            // 
            this.pochta.Location = new System.Drawing.Point(3, 271);
            this.pochta.Name = "pochta";
            this.pochta.Size = new System.Drawing.Size(151, 24);
            this.pochta.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label10.Location = new System.Drawing.Point(3, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Введите вашу почту:";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(3, 224);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(151, 24);
            this.fio.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(192, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 33);
            this.button6.TabIndex = 7;
            this.button6.Text = "Показать все";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(400, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label7.Location = new System.Drawing.Point(5, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Введите ваше фио:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label6.Location = new System.Drawing.Point(331, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Введите название услуги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(21, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Здесь Вы можете видеть оказанные вам услуги";
            // 
            // uslugiPa
            // 
            this.uslugiPa.AllowUserToAddRows = false;
            this.uslugiPa.AllowUserToDeleteRows = false;
            this.uslugiPa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uslugiPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uslugiPa.Location = new System.Drawing.Point(16, 34);
            this.uslugiPa.Name = "uslugiPa";
            this.uslugiPa.Size = new System.Drawing.Size(512, 155);
            this.uslugiPa.TabIndex = 0;
            // 
            // стоматологTableAdapter
            // 
            this.стоматологTableAdapter.ClearBeforeFill = true;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT * FROM findPost(@post)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@post", System.Data.SqlDbType.VarChar, 30)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=SHUTKXVALAPTOP;Initial Catalog=Стоматология;User ID=sa;Password=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT * FROM fullTable()";
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "select * from fullUslugaP()";
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "select * from findUsluga(@usluga)";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@usluga", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "errUsluga";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@usluga", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@text", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = "select * from uslugaFrom(@priceFrom)";
            this.sqlCommand6.Connection = this.sqlConnection1;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priceFrom", System.Data.SqlDbType.Int)});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = "select * from uslugaTo(@priceTo)";
            this.sqlCommand7.Connection = this.sqlConnection1;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priceTo", System.Data.SqlDbType.Int)});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = "select * from uslugaFrom(@priceFrom)";
            this.sqlCommand8.Connection = this.sqlConnection1;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priceFrom", System.Data.SqlDbType.Int)});
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "select * from uslugaBetween (@priceFrom, @priceTo)";
            this.sqlCommand9.Connection = this.sqlConnection1;
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priceFrom", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@priceTo", System.Data.SqlDbType.Int)});
            // 
            // sqlCommand10
            // 
            this.sqlCommand10.CommandText = "select * from fullUslugaPatient(@fio, @pochta)";
            this.sqlCommand10.Connection = this.sqlConnection1;
            this.sqlCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@pochta", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlCommand11
            // 
            this.sqlCommand11.CommandText = "select * from fullUslugaPatientU(@fio, @pochta, @usluga)";
            this.sqlCommand11.Connection = this.sqlConnection1;
            this.sqlCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@pochta", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@usluga", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlCommand12
            // 
            this.sqlCommand12.CommandText = "errUslugaP";
            this.sqlCommand12.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand12.Connection = this.sqlConnection1;
            this.sqlCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@pochta", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@usluga", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@text", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 332);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiPa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView doctors;
        private СтоматологияDataSet стоматологияDataSet;
        private System.Windows.Forms.BindingSource стоматологBindingSource;
        private СтоматологияDataSetTableAdapters.СтоматологTableAdapter стоматологTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceTo;
        private System.Windows.Forms.TextBox priceFrom;
        private System.Windows.Forms.TextBox usluga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView uslugi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView uslugiPa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label message;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Windows.Forms.TextBox uslugaa;
        private System.Windows.Forms.TextBox pochta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fio;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Windows.Forms.Label text;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
        private System.Data.SqlClient.SqlCommand sqlCommand12;
    }
}