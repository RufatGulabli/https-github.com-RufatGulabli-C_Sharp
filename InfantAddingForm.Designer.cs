namespace TrainReservationWinForms
{
    partial class InfantAddingForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(463, 224);
            this.panel4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_addInfant1
            // 
            this.btn_addInfant1.BackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addInfant1.FlatAppearance.BorderSize = 0;
            this.btn_addInfant1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addInfant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addInfant1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addInfant1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addInfant1.Location = new System.Drawing.Point(190, 190);
            this.btn_addInfant1.Name = "btn_addInfant1";
            this.btn_addInfant1.Size = new System.Drawing.Size(77, 31);
            this.btn_addInfant1.TabIndex = 7;
            this.btn_addInfant1.Text = "OK";
            this.btn_addInfant1.UseVisualStyleBackColor = false;
            this.btn_addInfant1.Click += new System.EventHandler(this.btn_addInfant1_Click);
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
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Infant";
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
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btn_Male.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Male_MouseUp_1);
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
            // InfantAddingForm
            // 
            this.AcceptButton = this.btn_addInfant1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 226);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InfantAddingForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_addInfant1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_female;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btn_Male;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}