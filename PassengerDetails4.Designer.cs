namespace TrainReservationWinForms
{
    partial class PassengerDetails4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerDetails4));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_addInfant3 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_addInfant4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addInfant2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_addInfant1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_female = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btn_Male = new System.Windows.Forms.Button();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(159, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.ForeColor = System.Drawing.Color.Black;
            this.textBoxSurname.Location = new System.Drawing.Point(159, 64);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(274, 23);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.btn_addInfant3);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 222);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = " ";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(159, 159);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(226, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 21);
            this.label24.TabIndex = 3;
            this.label24.Text = "Passenger 3";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(15, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 21);
            this.label19.TabIndex = 3;
            this.label19.Text = "PASSPORT NUMBER";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button9.Location = new System.Drawing.Point(356, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 35);
            this.button9.TabIndex = 6;
            this.button9.Text = "FEMALE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.GenderButtonClick);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
            // 
            // btn_addInfant3
            // 
            this.btn_addInfant3.BackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addInfant3.BackgroundImage")));
            this.btn_addInfant3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addInfant3.FlatAppearance.BorderSize = 0;
            this.btn_addInfant3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addInfant3.Location = new System.Drawing.Point(159, 188);
            this.btn_addInfant3.Name = "btn_addInfant3";
            this.btn_addInfant3.Size = new System.Drawing.Size(32, 34);
            this.btn_addInfant3.TabIndex = 7;
            this.btn_addInfant3.UseVisualStyleBackColor = false;
            this.btn_addInfant3.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(159, 36);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(274, 23);
            this.textBox10.TabIndex = 0;
            this.textBox10.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(159, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(274, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(55, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 21);
            this.label20.TabIndex = 3;
            this.label20.Text = "NATIONALITY";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(159, 65);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(274, 23);
            this.textBox12.TabIndex = 1;
            this.textBox12.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(81, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 21);
            this.label21.TabIndex = 3;
            this.label21.Text = "SURNAME";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(103, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 21);
            this.label23.TabIndex = 3;
            this.label23.Text = "NAME";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(159, 94);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(274, 23);
            this.textBox11.TabIndex = 2;
            this.textBox11.Leave += new System.EventHandler(this.RegexForPassportNumber);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(63, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 21);
            this.label22.TabIndex = 3;
            this.label22.Text = "BIRTHDATE";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(290, 153);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 35);
            this.button7.TabIndex = 5;
            this.button7.Text = "MALE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.GenderButtonClick);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button7_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_addInfant4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(461, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 222);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = " ";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(154, 159);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker4.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(221, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "Passenger 4";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(351, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "FEMALE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.GenderButtonClick);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // btn_addInfant4
            // 
            this.btn_addInfant4.BackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addInfant4.BackgroundImage")));
            this.btn_addInfant4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addInfant4.FlatAppearance.BorderSize = 0;
            this.btn_addInfant4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addInfant4.Location = new System.Drawing.Point(154, 188);
            this.btn_addInfant4.Name = "btn_addInfant4";
            this.btn_addInfant4.Size = new System.Drawing.Size(32, 34);
            this.btn_addInfant4.TabIndex = 7;
            this.btn_addInfant4.UseVisualStyleBackColor = false;
            this.btn_addInfant4.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(154, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(274, 23);
            this.textBox8.TabIndex = 1;
            this.textBox8.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(98, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "NAME";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(58, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "BIRTHDATE";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(285, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "MALE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.GenderButtonClick);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(154, 94);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(274, 23);
            this.textBox7.TabIndex = 2;
            this.textBox7.Leave += new System.EventHandler(this.RegexForPassportNumber);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(76, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "SURNAME";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(50, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "NATIONALITY";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(154, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(274, 23);
            this.textBox5.TabIndex = 0;
            this.textBox5.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(10, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "PASSPORT NUMBER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_addInfant2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(461, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 221);
            this.panel3.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " ";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 158);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(221, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Passenger 2";
            // 
            // btn_addInfant2
            // 
            this.btn_addInfant2.BackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addInfant2.BackgroundImage")));
            this.btn_addInfant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addInfant2.FlatAppearance.BorderSize = 0;
            this.btn_addInfant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addInfant2.Location = new System.Drawing.Point(154, 187);
            this.btn_addInfant2.Name = "btn_addInfant2";
            this.btn_addInfant2.Size = new System.Drawing.Size(32, 34);
            this.btn_addInfant2.TabIndex = 7;
            this.btn_addInfant2.UseVisualStyleBackColor = false;
            this.btn_addInfant2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(154, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(58, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "BIRTHDATE";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(154, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Leave += new System.EventHandler(this.RegexForPassportNumber);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(50, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "NATIONALITY";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(10, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "PASSPORT NUMBER";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(154, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 23);
            this.textBox4.TabIndex = 0;
            this.textBox4.Leave += new System.EventHandler(this.RegexForNameSurnameBoxes);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(76, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "SURNAME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(285, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "MALE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GenderButtonClick);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(98, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "NAME";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(351, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "FEMALE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.GenderButtonClick);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.btn_addInfant1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_female);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.btn_Male);
            this.panel4.Controls.Add(this.textBoxName);
            this.panel4.Controls.Add(this.textBoxPassport);
            this.panel4.Controls.Add(this.textBoxSurname);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 221);
            this.panel4.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btn_addInfant1
            // 
            this.btn_addInfant1.BackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addInfant1.BackgroundImage")));
            this.btn_addInfant1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addInfant1.FlatAppearance.BorderSize = 0;
            this.btn_addInfant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addInfant1.Location = new System.Drawing.Point(159, 187);
            this.btn_addInfant1.Name = "btn_addInfant1";
            this.btn_addInfant1.Size = new System.Drawing.Size(32, 34);
            this.btn_addInfant1.TabIndex = 7;
            this.btn_addInfant1.UseVisualStyleBackColor = false;
            this.btn_addInfant1.Visible = false;
            this.btn_addInfant1.Click += new System.EventHandler(this.button_AddInfant);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(63, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "BIRTHDATE";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "NATIONALITY";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSPORT NUMBER";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(81, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "SURNAME";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(226, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Passenger 1";
            // 
            // btn_female
            // 
            this.btn_female.BackColor = System.Drawing.Color.Transparent;
            this.btn_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_female.FlatAppearance.BorderSize = 0;
            this.btn_female.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_female.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_female.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_female.Location = new System.Drawing.Point(356, 152);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(77, 35);
            this.btn_female.TabIndex = 6;
            this.btn_female.Text = "FEMALE";
            this.btn_female.UseVisualStyleBackColor = false;
            this.btn_female.Click += new System.EventHandler(this.GenderButtonClick);
            this.btn_female.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_female_MouseUp);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(159, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(274, 24);
            this.comboBox4.TabIndex = 3;
            // 
            // btn_Male
            // 
            this.btn_Male.BackColor = System.Drawing.Color.Transparent;
            this.btn_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Male.FlatAppearance.BorderSize = 0;
            this.btn_Male.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Male.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Male.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Male.Location = new System.Drawing.Point(290, 152);
            this.btn_Male.Name = "btn_Male";
            this.btn_Male.Size = new System.Drawing.Size(60, 35);
            this.btn_Male.TabIndex = 5;
            this.btn_Male.Text = "MALE";
            this.btn_Male.UseVisualStyleBackColor = false;
            this.btn_Male.Click += new System.EventHandler(this.GenderButtonClick);
            this.btn_Male.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Male_MouseUp);
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassport.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassport.Location = new System.Drawing.Point(159, 93);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(274, 23);
            this.textBoxPassport.TabIndex = 2;
            this.textBoxPassport.Leave += new System.EventHandler(this.RegexForPassportNumber);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.button11);
            this.panel5.Location = new System.Drawing.Point(0, 445);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(919, 45);
            this.panel5.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.MintCream;
            this.button11.Location = new System.Drawing.Point(795, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "NEXT";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // PassengerDetails4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PassengerDetails4";
            this.Size = new System.Drawing.Size(919, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addInfant1;
        private System.Windows.Forms.Button btn_female;
        private System.Windows.Forms.Button btn_Male;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_addInfant3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_addInfant4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_addInfant2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button11;
    }
}
