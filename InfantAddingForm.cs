using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainReservationWinForms
{
    public partial class InfantAddingForm : Form
    {
        string birthdate = "";

        public InfantAddingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            foreach (Citizenship item in Enum.GetValues(typeof(Citizenship)))
            {
                comboBox4.Items.Add(item);
            }
        }

        private void GenderButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.RoyalBlue;
                button.ForeColor = SystemColors.ButtonHighlight;
            }
            else
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = SystemColors.Highlight;
            }
        }

        private void RegexForNameSurnameBoxes(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
                textBox.ForeColor = Color.Black;
            if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z]{3,50}$"))
                textBox.ForeColor = Color.Red;
            else
                textBox.ForeColor = Color.Black;
        }

        private void RegexForPassportNumber(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z0-9]{3,50}$"))
                textBox.ForeColor = Color.Red;
            else
                textBox.ForeColor = Color.Black;
        }


        private void btn_female_MouseUp(object sender, MouseEventArgs e)
        {
            if (btn_Male.BackColor == Color.RoyalBlue)
            {
                btn_Male.BackColor = Color.Transparent;
                btn_Male.ForeColor = SystemColors.Highlight;
            }
        }

        private void btn_Male_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (btn_female.BackColor == Color.RoyalBlue)
            {
                btn_female.BackColor = Color.Transparent;
                btn_female.ForeColor = SystemColors.Highlight;
            }
        }

        private void btn_addInfant1_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel4.Controls.OfType<TextBox>().Any(x => x.ForeColor == Color.Red || x.Text == ""))
                    throw new Exception("Please fill all details correctly");
                if (comboBox4.SelectedIndex < 0)
                    throw new Exception("Please select nationality");
                var genderButton = panel4.Controls.OfType<Button>().FirstOrDefault(x => x.BackColor == Color.RoyalBlue);
                if (genderButton == null)
                    throw new Exception("Please choose Gender");
                int gender = (genderButton.Text == "MALE") ? 1 : 2;
                if (birthdate == "")
                    throw new Exception("Please fill Birthdate");
                Infant inf = new Infant((textBoxName.Text + " " + textBoxSurname.Text), textBoxPassport.Text,
                    (Citizenship)comboBox4.SelectedIndex, dateTimePicker1.Value, (Gender)gender);
                DataBase.InfantList.Add(inf);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            birthdate = dateTimePicker1.Value.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
    }
}
