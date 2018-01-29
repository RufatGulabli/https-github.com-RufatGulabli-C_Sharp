using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            monthCalendar1.MaxDate = DateTime.Now.AddYears(1);
            monthCalendar2.MaxDate = DateTime.Now.AddYears(1);
            txtBoxDeparture.ForeColor = Color.DarkGray;
            txtBoxDeparture.Font = new Font("Century Gothic", 10f);
            txtBoxDeparture.Text = " - departure date - ";
            txtBoxReturn.Font = new Font("Century Gothic", 10f);
            txtBoxReturn.ForeColor = Color.DarkGray;
            txtBoxReturn.Text = " - return date - ";
            panelPassenger.Visible = false;
            btnMinusAdult.Enabled = false;
            btnMinusChild.Enabled = false;
            btnMinusInfant.Enabled = false;
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
            monthCalendar1.Location = new Point(17, 149);
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
            panelPassenger.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtBoxDeparture.ForeColor = Color.Black;
            txtBoxDeparture.Font = new Font("Century Gothic", 11f);
            txtBoxDeparture.Text = e.Start.ToShortDateString();
            monthCalendar1.Visible = false;
            monthCalendar2.MinDate = monthCalendar1.SelectionRange.Start;
            panelPassenger.Visible = false;
            txtBoxPassenger.Visible = true;
            label12.Visible = true;
        }

        private void btnCalendar2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Location = new Point(222, 149);
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = true;
            panelPassenger.Visible = false;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtBoxReturn.Font = new Font("Century Gothic", 11f);
            txtBoxReturn.ForeColor = Color.Black;
            txtBoxReturn.Text = e.Start.ToShortDateString();
            monthCalendar2.Visible = false;
            panelPassenger.Visible = false;
        }

        private void txtBoxDeparture_Leave(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            if(txtBoxDeparture.Text == "")
            {
                txtBoxDeparture.ForeColor = Color.DarkGray;
                txtBoxDeparture.Font = new Font("Century Gothic", 10f);
                txtBoxDeparture.Text = " - departure date - ";
            }

        }

        private void txtBoxReturn_Leave(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
            if (txtBoxReturn.Text == "")
            {
                txtBoxReturn.Font = new Font("Century Gothic", 10f);
                txtBoxReturn.ForeColor = Color.DarkGray;
                txtBoxReturn.Text = " - return date - ";
            }
        }

        private void txtBoxDeparture_Enter(object sender, EventArgs e)
        {
            if(txtBoxDeparture.Text.Equals(" - departure date - "))
            {
                txtBoxDeparture.Text = "";
                txtBoxDeparture.ForeColor = Color.Black;
                txtBoxDeparture.Font = new Font("Century Gothic", 11f);
            }
            panelPassenger.Visible = false;
        }

        private void txtBoxReturn_Enter(object sender, EventArgs e)
        {
            if (txtBoxReturn.Text.Equals(" - return date - "))
            {
                txtBoxReturn.Text = "";
                txtBoxReturn.ForeColor = Color.Black;
                txtBoxReturn.Font = new Font("Century Gothic", 11f);
            }
            panelPassenger.Visible = false;
        }

        private void ComboBoxLeave(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if(comboBox.Text.Contains(""))
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
            adult++;
            labelAdult.Text = adult.ToString();
            btnMinusAdult.Enabled = true;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void btnPlusChild_Click(object sender, EventArgs e)
        {
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
        }

        private void btnMinusChild_Click(object sender, EventArgs e)
        {
            children--;
            labelChild.Text = children.ToString();
            if (children == 0)
                btnMinusChild.Enabled = false;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void btnMinusInfant_Click(object sender, EventArgs e)
        {
            infant--;
            labelInfant.Text = infant.ToString();
            if (infant == 0)
                btnMinusInfant.Enabled = false;
            txtBoxPassenger.Text = (adult + children + infant).ToString();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
            panelPassenger.Visible = false;
            txtBoxPassenger.Visible = true;
            label12.Visible = true;
        }

        private void txtBoxPassenger_Click(object sender, EventArgs e)
        {
            panelPassenger.Visible = true;
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
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
            panelPassenger.Visible = false;
        }

        private void btnCalendar1_Leave(object sender, EventArgs e)
        {
            label12.Visible = true;
            txtBoxPassenger.Visible = true;
        }
    }

}
