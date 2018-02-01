using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainReservationWinForms
{
    public partial class PassengersControl : UserControl
    {
        public Form1 form1;
        public PassengersControl(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private static PassengersControl instance;

        public static PassengersControl GetInstance(Form1 form)
        {
            if (instance == null)
            {
                instance = new PassengersControl(form);
                return instance;
            }
            else
                return instance;
        }

        private void textBoxBirth_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }
    }
}
