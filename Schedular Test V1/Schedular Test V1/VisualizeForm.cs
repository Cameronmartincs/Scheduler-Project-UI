using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular_Test_V1
{
    public partial class VisualizeForm : Form
    {
        public VisualizeForm()
        {
            InitializeComponent();
        }
        DateTime toDayPlus3 = DateTime.Today.AddDays(3);
        DateTime toDayMinus3 = DateTime.Today.AddDays(-3);
        DateTime now = DateTime.Now;
        DateTime m = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        DateTime s = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday + 6);
        private void VisualizeForm_Load(object sender, EventArgs e)
        {
            


            SourceGrid.Planning.IAppointment appointment1 = new SourceGrid.Planning.AppointmentBase("Dentist",
                                    new DateTime(now.Year, now.Month, now.Day, 9, 0, 0),
                                    new DateTime(now.Year, now.Month, now.Day, 11, 30, 0));
            SourceGrid.Planning.IAppointment appointment2 = new SourceGrid.Planning.AppointmentBase("Appointment 1",
                                    new DateTime(now.Year, now.Month, now.Day, 16, 0, 0),
                                    new DateTime(now.Year, now.Month, now.Day, 16, 45, 0));
            planningGrid1.Appointments.Add(appointment1);
            planningGrid1.Appointments.Add(appointment2);
            LoadPlanning();
        }
        private void LoadPlanning()
        {
            //toDayMinus3.Year,  toDayMinus3.Month, 8, 0, 0
            try
            {
                planningGrid1.Appointments.Clear();
                foreach (SourceGrid.Planning.AppointmentBase a in planningGrid1.Appointments)
                {
                    planningGrid1.Appointments.Add(a);
                }
               /* planningGrid1.LoadPlanning(new DateTime(toDayMinus3.Year, toDayMinus3.Month, toDayMinus3.Day, 0, 0, 0),
                                           new DateTime(toDayPlus3.Year, toDayPlus3.Month, toDayPlus3.Day, 23, 0, 0), 15);*/

                planningGrid1.LoadPlanning(new DateTime(m.Year, m.Month, m.Day, 0, 0, 0),
                                          new DateTime(s.Year, s.Month, s.Day, 23, 0, 0), 15);


            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "Error");
            }
        }
    }
}
