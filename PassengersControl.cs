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
        public PassengersControl()
        {
            InitializeComponent();
        }

        private static PassengersControl Instance;

        public static PassengersControl GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new PassengersControl();
                    return Instance;
                }
                else
                    return Instance;
            } 
        }
    }
}
