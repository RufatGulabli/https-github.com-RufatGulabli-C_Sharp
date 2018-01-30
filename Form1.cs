using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrainReservationWinForms
{


    public partial class Form1 : Form
    {
        int adult = 0;
        int children = 0;
        int infant = 0;

        public Form1()
        {
            InitializeComponent();

            comboBoxFrom.SelectedIndex = -1;
            comboBoxFrom.Text = " - select station - ";
            comboBoxTo.SelectedIndex = -1;
            comboBoxTo.Text = " - select station - ";
            panelPassenger.Visible = false;
            btnMinusAdult.Enabled = false;
            btnMinusChild.Enabled = false;
            btnMinusInfant.Enabled = false;
            foreach (Stations Stations in Enum.GetValues(typeof(Stations)))
            {
                comboBoxFrom.Items.Add(Stations);
                comboBoxTo.Items.Add(Stations);
            }
        }

        private void ClearText(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if ((sender as ComboBox).Text.Contains(" - select station - "))
            {
                comboBox.Text = "";
                comboBox.ForeColor = Color.Black;
                comboBox.Font = new Font("Verdana", 10f, FontStyle.Regular);
            }
            panelPassenger.Visible = false;
        }

        private void btnCalendar1_Click(object sender, EventArgs e)
        {
            txtBoxPassenger.Visible = false;
            label12.Visible = false;
            panelPassenger.Visible = false;
        }

        private void btnCalendar2_Click(object sender, EventArgs e)
        {
            panelPassenger.Visible = false;
        }

        private void ComboBoxLeave(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if(comboBox.Text.Equals(""))
            {
                comboBox.ForeColor = Color.DarkGray;
                comboBox.Text = " - select station - ";
            }
        }

        private void txtBoxPassenger_Enter(object sender, EventArgs e)
        {
            panelPassenger.Visible = true;
        }

        private void btnPlusAdult_Click(object sender, EventArgs e)
        {
            if (checkPassengerCount(sender)) return;
            adult++;
            labelAdult.Text = adult.ToString();
            btnMinusAdult.Enabled = true;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void btnPlusChild_Click(object sender, EventArgs e)
        {
            if (checkPassengerCount(sender)) return;
            children++;
            labelChild.Text = children.ToString();
            btnMinusChild.Enabled = true;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void btnPlusInfant_Click(object sender, EventArgs e)
        {
            if (infant >= adult)
            { 
                toolTip1.Show("Infants count can not exceed Adults count", labelInfant, 10, 10, 5000);
                return;
            }
            infant++;
            labelInfant.Text = infant.ToString();
            btnMinusInfant.Enabled = true;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void btnMinusAdult_Click(object sender, EventArgs e)
        {
            if (txtBoxPassenger.Text == "")
                return;
            if (adult == infant && adult != 0)
            {
                infant--;
                labelInfant.Text = infant.ToString();
            }
            adult--;
            labelAdult.Text = adult.ToString();
            if (adult == 0)
                btnMinusAdult.Enabled = false;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
            changeBTNEnableCondition();
        }

        private void btnMinusChild_Click(object sender, EventArgs e)
        {
            if (txtBoxPassenger.Text == "")
                return;
            children--;
            labelChild.Text = children.ToString();
            if (children == 0)
                btnMinusChild.Enabled = false;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
            changeBTNEnableCondition();
        }

        private void btnMinusInfant_Click(object sender, EventArgs e)
        {
            if (txtBoxPassenger.Text == "")
                return;
            labelInfant.Text = infant.ToString();
            if (infant == 0)
            {
                btnMinusInfant.Enabled = false;
                return;
            }
            infant--;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
            changeBTNEnableCondition();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panelPassenger.Visible = false;
            txtBoxPassenger.Visible = true;
            label12.Visible = true;
        }

        private void txtBoxPassenger_Click(object sender, EventArgs e)
        {
            panelPassenger.Visible = true;
        }

        private void panelPassenger_Leave(object sender, EventArgs e)
        {
            panelPassenger.Visible = false;
        }

        private void txtBoxPassenger_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPassenger.Text))
            {
                adult = children = infant = 0;
                labelAdult.Text = labelChild.Text = labelInfant.Text = "0";
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            try
            {
                panelPassenger.Visible = false;
                if (panel8.Controls.OfType<ComboBox>().Any(x => x.Text.Contains("select")) ||
                    !panel8.Controls.OfType<RadioButton>().Any(x => x.Checked) ||
                    checkBox1.CheckState == CheckState.Unchecked ||
                    panel8.Controls.OfType<TextBox>().Any(x => x.Text is null || x.Text.Equals("DD/MM/YYYY")))
                    throw new Exception("Please fill all details");

                var instance = TimeTable.GetInstance;
                Controls.Add(instance);
                instance.Location = new Point(0, 111);
                panel2.BackColor = Color.ForestGreen;
                TimeTable.GetInstance.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private bool checkPassengerCount(object sender)
        {
            var button = sender as Button;
            if (adult + children >= 4)
            {
                button.Enabled = false;
                toolTip2.Show("Passenger count must not exceed 4", panelPassenger, 200, 10, 3000);
                return true;
            }
            return false;
        }

        private void changeBTNEnableCondition()
        {
            if(adult + children < 4)
            {
                btnPlusAdult.Enabled = true;
                btnPlusChild.Enabled = true;
            }
        }

    }

}
