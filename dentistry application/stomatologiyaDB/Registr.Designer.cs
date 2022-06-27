
namespace stomatologiyaDB
{
    partial class Registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registr));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resultAddClient = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.emailClient = new System.Windows.Forms.TextBox();
            this.fioPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mailPatient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.resPerOsm = new System.Windows.Forms.Label();
            this.datePriem = new System.Windows.Forms.DateTimePicker();
            this.fioDoctor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fiooPatient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clients = new System.Windows.Forms.DataGridView();
            this.кодпациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пациентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.стоматологияDataSet = new stomatologiyaDB.СтоматологияDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.resultFindC = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.пациентTableAdapter = new stomatologiyaDB.СтоматологияDataSetTableAdapters.ПациентTableAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.resultAddClient);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateBirth);
            this.tabPage1.Controls.Add(this.emailClient);
            this.tabPage1.Controls.Add(this.fioPatient);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление пациента";
            // 
            // resultAddClient
            // 
            this.resultAddClient.Font = new System.Drawing.Font("Pribambas", 15F);
            this.resultAddClient.ForeColor = System.Drawing.Color.Red;
            this.resultAddClient.Location = new System.Drawing.Point(6, 231);
            this.resultAddClient.Name = "resultAddClient";
            this.resultAddClient.Size = new System.Drawing.Size(555, 23);
            this.resultAddClient.TabIndex = 11;
            this.resultAddClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(134, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "Добавление нового пациента";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F);
            this.button1.Location = new System.Drawing.Point(184, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(230, 92);
            this.dateBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(200, 22);
            this.dateBirth.TabIndex = 8;
            // 
            // emailClient
            // 
            this.emailClient.Location = new System.Drawing.Point(289, 135);
            this.emailClient.Name = "emailClient";
            this.emailClient.Size = new System.Drawing.Size(225, 22);
            this.emailClient.TabIndex = 7;
            // 
            // fioPatient
            // 
            this.fioPatient.Location = new System.Drawing.Point(253, 51);
            this.fioPatient.Name = "fioPatient";
            this.fioPatient.Size = new System.Drawing.Size(225, 22);
            this.fioPatient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите адрес электронной почты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите дату рождения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ФИО нового пациента:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.mailPatient);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.resPerOsm);
            this.tabPage2.Controls.Add(this.datePriem);
            this.tabPage2.Controls.Add(this.fioDoctor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.fiooPatient);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 9F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запись на первичный осмотр";
            // 
            // mailPatient
            // 
            this.mailPatient.Location = new System.Drawing.Point(200, 96);
            this.mailPatient.Name = "mailPatient";
            this.mailPatient.Size = new System.Drawing.Size(178, 22);
            this.mailPatient.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label12.Location = new System.Drawing.Point(5, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Введите почту пациента:";
            // 
            // resPerOsm
            // 
            this.resPerOsm.AutoSize = true;
            this.resPerOsm.Font = new System.Drawing.Font("Pribambas", 15F);
            this.resPerOsm.ForeColor = System.Drawing.Color.Red;
            this.resPerOsm.Location = new System.Drawing.Point(207, 218);
            this.resPerOsm.Name = "resPerOsm";
            this.resPerOsm.Size = new System.Drawing.Size(0, 20);
            this.resPerOsm.TabIndex = 11;
            // 
            // datePriem
            // 
            this.datePriem.Location = new System.Drawing.Point(198, 172);
            this.datePriem.MaxDate = new System.DateTime(2040, 1, 1, 0, 0, 0, 0);
            this.datePriem.Name = "datePriem";
            this.datePriem.Size = new System.Drawing.Size(183, 22);
            this.datePriem.TabIndex = 10;
            // 
            // fioDoctor
            // 
            this.fioDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fioDoctor.FormattingEnabled = true;
            this.fioDoctor.Items.AddRange(new object[] {
            "Коногорова В.А.",
            "Виноградов В.Е.",
            "Аглямов А.Э.",
            "Васейкин В.И.",
            "Рогатов А.В.",
            "Николаева А.Ю.",
            "Шуткова А.В.",
            "Шумский А.В."});
            this.fioDoctor.Location = new System.Drawing.Point(200, 132);
            this.fioDoctor.Name = "fioDoctor";
            this.fioDoctor.Size = new System.Drawing.Size(178, 22);
            this.fioDoctor.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(97, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(411, 27);
            this.label11.TabIndex = 8;
            this.label11.Text = "Запись пациента на первичный осмотр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label6.Location = new System.Drawing.Point(85, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введите дату:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F);
            this.button2.Location = new System.Drawing.Point(38, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Записать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fiooPatient
            // 
            this.fiooPatient.Location = new System.Drawing.Point(200, 60);
            this.fiooPatient.Name = "fiooPatient";
            this.fiooPatient.Size = new System.Drawing.Size(178, 22);
            this.fiooPatient.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label5.Location = new System.Drawing.Point(44, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введите ФИО врача:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите ФИО пациента:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.clients);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.resultFindC);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 10F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(582, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Просмотр и удаление клиентов";
            // 
            // clients
            // 
            this.clients.AllowUserToAddRows = false;
            this.clients.AllowUserToDeleteRows = false;
            this.clients.AutoGenerateColumns = false;
            this.clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпациентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn});
            this.clients.DataSource = this.пациентBindingSource1;
            this.clients.Location = new System.Drawing.Point(8, 31);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(568, 150);
            this.clients.TabIndex = 11;
            // 
            // кодпациентаDataGridViewTextBoxColumn
            // 
            this.кодпациентаDataGridViewTextBoxColumn.DataPropertyName = "Код_пациента";
            this.кодпациентаDataGridViewTextBoxColumn.HeaderText = "Код пациента";
            this.кодпациентаDataGridViewTextBoxColumn.Name = "кодпациентаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // пациентBindingSource1
            // 
            this.пациентBindingSource1.DataMember = "Пациент";
            this.пациентBindingSource1.DataSource = this.стоматологияDataSet;
            // 
            // стоматологияDataSet
            // 
            this.стоматологияDataSet.DataSetName = "СтоматологияDataSet";
            this.стоматологияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(280, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 31);
            this.button6.TabIndex = 10;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // resultFindC
            // 
            this.resultFindC.AutoSize = true;
            this.resultFindC.Font = new System.Drawing.Font("Pribambas", 15F);
            this.resultFindC.ForeColor = System.Drawing.Color.Red;
            this.resultFindC.Location = new System.Drawing.Point(363, 210);
            this.resultFindC.Name = "resultFindC";
            this.resultFindC.Size = new System.Drawing.Size(0, 20);
            this.resultFindC.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(186, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(199, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 24);
            this.textBox6.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label9.Location = new System.Drawing.Point(218, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Введите ФИО:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(27, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сортировать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(428, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Показать все";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pribambas", 15F);
            this.label8.Location = new System.Drawing.Point(22, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Сортировать по фио:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pribambas", 20F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(185, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Список пациентов:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Pribambas", 15F);
            this.radioButton2.Location = new System.Drawing.Point(100, 206);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "От я до а";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Pribambas", 15F);
            this.radioButton1.Location = new System.Drawing.Point(8, 206);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "От а до я";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.стоматологияDataSet;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT * FROM fullTableClient()";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=SHUTKXVALAPTOP;Initial Catalog=Стоматология;User ID=sa;Password=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT * FROM findClient(@fio)";
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "messageClient";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConnection1;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 50),
            new System.Data.SqlClient.SqlParameter("@text", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "insertClient";
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 60),
            new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@birth", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@text", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "deleteClient";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idPa", System.Data.SqlDbType.SmallInt),
            new System.Data.SqlClient.SqlParameter("@text", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = "insClientPerOsm";
            this.sqlCommand6.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand6.Connection = this.sqlConnection1;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fiooPatient", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@mailPatient", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@fioDoctor", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@datePriem", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@message", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 315);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работник регистратуры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registr_FormClosing);
            this.Load += new System.EventHandler(this.Registr_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоматологияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.TextBox emailClient;
        private System.Windows.Forms.TextBox fioPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiooPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private СтоматологияDataSet стоматологияDataSet;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private СтоматологияDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Label resultFindC;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label resultAddClient;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button button6;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox fioDoctor;
        private System.Windows.Forms.DateTimePicker datePriem;
        private System.Windows.Forms.Label resPerOsm;
        private System.Windows.Forms.TextBox mailPatient;
        private System.Windows.Forms.Label label12;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Windows.Forms.DataGridView clients;
        private System.Windows.Forms.BindingSource пациентBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
    }
}