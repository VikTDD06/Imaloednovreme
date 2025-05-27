using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLib;

namespace DentalClinicForm
{
    public partial class Form1 : Form
    {
        private BusinessClass business = new BusinessClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {


        }


        private void btnStat_Click_1(object sender, EventArgs e)
        {
            string caption = "Basic Statistics";
            string message = "";
            message += "Working dentists count = " + business.GetDentistsCount() + "\n";
            message += "Registered patients count = " + business.GetPatientsCount() + "\n";
            message += "Exams done  =  " + business.GetDoneExamsCount() + "\n";
            message += "Future appointments = " + business.GetFutureExamsCount() + "\n";
            MessageBoxButtons btns = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, btns);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            business.GetAllPatients();
            comboPatient.DataSource = business.PatientNames;
            business.GetAllDentists();
            comboDentist.DataSource = business.DentistNames;
            comboPatient_SelectedIndexChanged(sender, e);
        }

        private void comboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dentID = business.PatientDentistIDs[comboPatient.SelectedIndex];
            int dentIdx = business.DentistIDs.IndexOf(dentID);
            if (dentIdx != -1)
                comboDentist.SelectedIndex = dentIdx;

        }

        private void btnReserveAppointment_Click(object sender, EventArgs e)
        {
            DateTime dt = dateAppointmentPicker.Value;
            dt = dt.Date;  // gets date part only, zeroes the time -> hh:mm:ss to 00:00:00
            dt = dt.AddHours((double)numHour.Value);
            dt = dt.AddMinutes((double)numMinutes.Value);
            string appointmentStart = dt.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime dte = dt.AddMinutes((double)numDurationMinutes.Value);
            string appointmentEnd = dte.ToString("yyyy-MM-dd HH:mm:ss");
            long collisions = business.CheckAppointmentForCollisions(
                business.DentistIDs[comboDentist.SelectedIndex],
                appointmentStart, appointmentEnd);
            if (collisions != 0)
            {
                MessageBox.Show("ERROR: Appointment collides with another one. \n Try a different day or hour.",
                    "ERROR: Appointmen failed", MessageBoxButtons.OK);
            }
            else
            {
                int added = business.AddAppointment(
                   business.PatientIDs[comboPatient.SelectedIndex],
                   business.DentistIDs[comboDentist.SelectedIndex],
                   appointmentStart, appointmentEnd);
                if (added == 1)
                    MessageBox.Show("New appointment successfuly added.",
                                    "Success", MessageBoxButtons.OK);

            }
        }
    }
}
