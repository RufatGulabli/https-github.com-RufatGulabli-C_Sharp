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
        public InfantAddingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPassport.Text = "";
            foreach (Citizenship item in Enum.GetValues(typeof(Citizenship)))
            {
                comboBox4.Items.Add(item);
            }
        }

        private static InfantAddingForm instance;

        public static InfantAddingForm GetInstance()
        {
            if (instance == null)
            {
                instance = new InfantAddingForm();
                return instance;
            }
            else
                return instance;
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
            if (btn_Male.BackColor == Color.RoyalBlue)
            {
                btn_Male.BackColor = Color.Transparent;
                btn_Male.ForeColor = SystemColors.Highlight;
            }
        }
    }
}
