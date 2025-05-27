
namespace DentalClinicForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStat = new System.Windows.Forms.Button();
            this.comboPatient = new System.Windows.Forms.ComboBox();
            this.comboDentist = new System.Windows.Forms.ComboBox();
            this.dateAppointmentPicker = new System.Windows.Forms.DateTimePicker();
            this.numDurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.btnReserveAppointment = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDentist = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(576, 317);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(166, 88);
            this.btnStat.TabIndex = 0;
            this.btnStat.Text = "\'Basic Statistics";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click_1);
            // 
            // comboPatient
            // 
            this.comboPatient.FormattingEnabled = true;
            this.comboPatient.Location = new System.Drawing.Point(127, 150);
            this.comboPatient.Name = "comboPatient";
            this.comboPatient.Size = new System.Drawing.Size(121, 21);
            this.comboPatient.TabIndex = 1;
            this.comboPatient.SelectedIndexChanged += new System.EventHandler(this.comboPatient_SelectedIndexChanged);
            // 
            // comboDentist
            // 
            this.comboDentist.FormattingEnabled = true;
            this.comboDentist.Location = new System.Drawing.Point(441, 149);
            this.comboDentist.Name = "comboDentist";
            this.comboDentist.Size = new System.Drawing.Size(121, 21);
            this.comboDentist.TabIndex = 2;
            // 
            // dateAppointmentPicker
            // 
            this.dateAppointmentPicker.Location = new System.Drawing.Point(127, 220);
            this.dateAppointmentPicker.Name = "dateAppointmentPicker";
            this.dateAppointmentPicker.Size = new System.Drawing.Size(200, 20);
            this.dateAppointmentPicker.TabIndex = 3;
            // 
            // numDurationMinutes
            // 
            this.numDurationMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDurationMinutes.Location = new System.Drawing.Point(441, 220);
            this.numDurationMinutes.Name = "numDurationMinutes";
            this.numDurationMinutes.Size = new System.Drawing.Size(120, 20);
            this.numDurationMinutes.TabIndex = 4;
            this.numDurationMinutes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numMinutes
            // 
            this.numMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinutes.Location = new System.Drawing.Point(233, 271);
            this.numMinutes.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(37, 20);
            this.numMinutes.TabIndex = 5;
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(127, 271);
            this.numHour.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numHour.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(37, 20);
            this.numHour.TabIndex = 6;
            this.numHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnReserveAppointment
            // 
            this.btnReserveAppointment.Location = new System.Drawing.Point(127, 317);
            this.btnReserveAppointment.Name = "btnReserveAppointment";
            this.btnReserveAppointment.Size = new System.Drawing.Size(132, 51);
            this.btnReserveAppointment.TabIndex = 7;
            this.btnReserveAppointment.Text = "\'Reserve Appointment";
            this.btnReserveAppointment.UseVisualStyleBackColor = true;
            this.btnReserveAppointment.Click += new System.EventHandler(this.btnReserveAppointment_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(124, 134);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 8;
            this.lblPatient.Text = "Patient";
            // 
            // lblDentist
            // 
            this.lblDentist.AutoSize = true;
            this.lblDentist.Location = new System.Drawing.Point(438, 133);
            this.lblDentist.Name = "lblDentist";
            this.lblDentist.Size = new System.Drawing.Size(40, 13);
            this.lblDentist.TabIndex = 9;
            this.lblDentist.Text = "Dentist";
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(124, 204);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(66, 13);
            this.lblAppointment.TabIndex = 10;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(438, 204);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 13);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Expected duration:";
            this.lblDuration.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(567, 227);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 12;
            this.lblMinutes.Text = "minutes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblDentist);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnReserveAppointment);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.numDurationMinutes);
            this.Controls.Add(this.dateAppointmentPicker);
            this.Controls.Add(this.comboDentist);
            this.Controls.Add(this.comboPatient);
            this.Controls.Add(this.btnStat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numDurationMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.ComboBox comboPatient;
        private System.Windows.Forms.ComboBox comboDentist;
        private System.Windows.Forms.DateTimePicker dateAppointmentPicker;
        private System.Windows.Forms.NumericUpDown numDurationMinutes;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Button btnReserveAppointment;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDentist;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMinutes;
    }
}

