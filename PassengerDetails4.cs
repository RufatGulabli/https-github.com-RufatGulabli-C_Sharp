using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TrainReservationWinForms
{
    public partial class PassengerDetails4 : UserControl
    {
        public Form1 form1;
        public PassengerDetails4(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker2.Format = DateTimePickerFormat.Custom;
            //dateTimePicker3.Format = DateTimePickerFormat.Custom;
            //dateTimePicker4.Format = DateTimePickerFormat.Custom;
            foreach (Citizenship item in Enum.GetValues(typeof(Citizenship)))
            {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
                comboBox3.Items.Add(item);
                comboBox4.Items.Add(item);
            }
            switch (Form1.infant)
            {
                case 1:
                    {
                        btn_addInfant1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        btn_addInfant1.Visible = true;
                        btn_addInfant2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        btn_addInfant1.Visible = true;
                        btn_addInfant2.Visible = true;
                        btn_addInfant3.Visible = true;
                        break;
                    }
                case 4:
                    {
                        btn_addInfant1.Visible = true;
                        btn_addInfant2.Visible = true;
                        btn_addInfant3.Visible = true;
                        btn_addInfant4.Visible = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private static PassengerDetails4 instance;

        public static PassengerDetails4 GetInstance(Form1 form)
        {
            if (instance == null)
            {
                instance = new PassengerDetails4(form);
                return instance;
            }
            else
                return instance;
        }

        private void RegexForNameSurnameBoxes(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if(textBox.Text == "")
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

        private void btn_Male_MouseUp(object sender, MouseEventArgs e)
        {
            if(btn_female.BackColor == Color.RoyalBlue)
            {
                btn_female.BackColor = Color.Transparent;
                btn_female.ForeColor = SystemColors.Highlight;
            }
                
        }

        private void btn_female_MouseUp(object sender, MouseEventArgs e)
        {
            if (btn_Male.BackColor == Color.RoyalBlue)
            {
                btn_Male.BackColor = Color.Transparent;
                btn_Male.ForeColor = SystemColors.Highlight;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (button2.BackColor == Color.RoyalBlue)
            {
                button2.BackColor = Color.Transparent;
                button2.ForeColor = SystemColors.Highlight;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (button1.BackColor == Color.RoyalBlue)
            {
                button1.BackColor = Color.Transparent;
                button1.ForeColor = SystemColors.Highlight;
            }
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            if (button9.BackColor == Color.RoyalBlue)
            {
                button9.BackColor = Color.Transparent;
                button9.ForeColor = SystemColors.Highlight;
            }
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            if (button7.BackColor == Color.RoyalBlue)
            {
                button7.BackColor = Color.Transparent;
                button7.ForeColor = SystemColors.Highlight;
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (button4.BackColor == Color.RoyalBlue)
            {
                button4.BackColor = Color.Transparent;
                button4.ForeColor = SystemColors.Highlight;
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (button5.BackColor == Color.RoyalBlue)
            {
                button5.BackColor = Color.Transparent;
                button5.ForeColor = SystemColors.Highlight;
            }
        }

        private void button_AddInfant(object sender, EventArgs e)
        {
            var btn = sender as Button;
            InfantAddingForm.GetInstance().ShowDialog();
            
        }
    }
}
