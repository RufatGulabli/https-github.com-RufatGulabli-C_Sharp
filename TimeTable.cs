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
        DataBase schedule = new DataBase();

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

        private void TimeTable_Load(object sender, EventArgs e)
        {
            labelItinerary.ForeColor = Color.White;
            labelItinerary.Text = Form1.from.ToString() + " - " + Form1.to.ToString() + " : "
                + Form1.departure.ToShortDateString();
            if(Form1.OWorRT != null)
            {
                labelReturn.ForeColor = Color.White;
                labelReturn.Text = Form1.to.ToString() + " - " + Form1.from.ToString() + " : "
                + Form1.arrival.ToShortDateString();
            }
            if (Form1.OWorRT.Equals("One Way"))
            {
                splitContainer2.Visible = false;
                panel2.Visible = false;

                var list = schedule.GetSchedule(Form1.from, Form1.to, Form1.departure);
                if (list.Count > 0)
                {
                    dataGridViewOutbound.DataSource = ConvertToDataTable(list, Form1.from, Form1.to);
                    labelTrainNumber.Text = dataGridViewOutbound.SelectedRows[0].Cells[1].Value.ToString();
                    labelItin.Text = dataGridViewOutbound.SelectedRows[0].Cells[0].Value.ToString();
                    labelDepTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[4].Value.ToString();
                    labelArriveTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[5].Value.ToString();
                }
                
            }
            else
            {
                var listOutbound = schedule.GetSchedule(Form1.from, Form1.to, Form1.departure);
                if (listOutbound.Count > 0)
                {
                    dataGridViewOutbound.DataSource = ConvertToDataTable(listOutbound, Form1.from, Form1.to);
                    labelTrainNumber.Text = dataGridViewOutbound.SelectedRows[0].Cells[1].Value.ToString();
                    labelItin.Text = dataGridViewOutbound.SelectedRows[0].Cells[0].Value.ToString();
                    labelDepTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[4].Value.ToString();
                    labelArriveTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[5].Value.ToString();
                }


                var listInbound = schedule.GetSchedule(Form1.to, Form1.from, Form1.arrival);
                if(listInbound.Count > 0)
                {
                    dataGridViewInbound.DataSource = ConvertToDataTable(listInbound, Form1.to, Form1.from);
                    labelTrainNoreturn.Text = dataGridViewInbound.SelectedRows[0].Cells[1].Value.ToString();
                    labelItinReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[0].Value.ToString();
                    labelDepReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[4].Value.ToString();
                    labelArrReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[5].Value.ToString();
                }

            }
        }

        public DataTable ConvertToDataTable(List<Train> list, Stations from, Stations to)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Train Name", typeof(string)));
            table.Columns.Add(new DataColumn("Train Number", typeof(int)));
            table.Columns.Add(new DataColumn("Seats Left", typeof(int)));
            table.Columns.Add(new DataColumn("Total Wagons", typeof(int)));
            table.Columns.Add(new DataColumn("Departs", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Arrives", typeof(DateTime)));
            foreach (Train item in list)
            {
                var StartRoute = item.Stopovers.Keys.FirstOrDefault(x => x.From == from);
                var EndRoute = item.Stopovers.Keys.FirstOrDefault(x => x.To == to);
                int seatsLeft = item.Stopovers.Values.Min();
                DataRow row = table.NewRow();
                row["Train Name"] = item.TrainName;
                row["Train Number"] = item.TrainNo;
                row["Seats Left"] = seatsLeft;
                row["Total Wagons"] = item.Wagon;
                row["Departs"] = StartRoute.Departure.ToString();
                row["Arrives"] = EndRoute.Arrival.ToString();
                table.Rows.Add(row);
            }
            return table;
        }

        private void dataGridViewInbound_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewInbound.SelectedRows.Count > 0)
            {
                labelTrainNoreturn.Text = dataGridViewInbound.SelectedRows[0].Cells[1].Value.ToString();
                labelItinReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[0].Value.ToString();
                labelDepReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[4].Value.ToString();
                labelArrReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridViewInbound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInbound.SelectedRows.Count > 0)
            {
                labelTrainNoreturn.Text = dataGridViewInbound.SelectedRows[0].Cells[1].Value.ToString();
                labelItinReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[0].Value.ToString();
                labelDepReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[4].Value.ToString();
                labelArrReturn.Text = dataGridViewInbound.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridViewOutbound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOutbound.SelectedRows.Count > 0)
            {
                labelTrainNumber.Text = dataGridViewOutbound.SelectedRows[0].Cells[1].Value.ToString();
                labelItin.Text = dataGridViewOutbound.SelectedRows[0].Cells[0].Value.ToString();
                labelDepTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[4].Value.ToString();
                labelArriveTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void dataGridViewOutbound_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOutbound.SelectedRows.Count > 0)
            {
                labelTrainNumber.Text = dataGridViewOutbound.SelectedRows[0].Cells[1].Value.ToString();
                labelItin.Text = dataGridViewOutbound.SelectedRows[0].Cells[0].Value.ToString();
                labelDepTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[4].Value.ToString();
                labelArriveTime.Text = dataGridViewOutbound.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Add(PassengersControl.GetInstance);
            PassengersControl.GetInstance.BringToFront();
        }
    }
}
