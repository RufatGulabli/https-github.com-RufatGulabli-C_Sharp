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
    public partial class TimeTable : UserControl
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        private static TimeTable Instance;

        public static TimeTable GetInstance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new TimeTable();
                    return Instance;
                }
                return Instance;
            }
        }
    }
}
