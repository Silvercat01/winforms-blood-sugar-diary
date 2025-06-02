using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BloodSugarClassLibrary.Data;
using BloodSugarClassLibrary.Models;
using BloodSugarClassLibrary.Repositories;

namespace BloodSugarDiary
{
    public partial class EditMeasurementForm : Form
    {
        private readonly int _userId;
        private readonly int? _measurementId;
        private readonly UserContext _context;
        private readonly MeasurementRepo _repo;

        public EditMeasurementForm(int userId, int? measurementId = null)
        {
            InitializeComponent();

            _userId = userId;
            _measurementId = measurementId;
            _context = new UserContext();
            _repo = new MeasurementRepo(_context);

            // ComboBox-ok feltöltése
            timeComboBox.DataSource = Enum.GetValues(typeof(Measurements.Time));
            unitComboBox.DataSource = Enum.GetValues(typeof(Measurements.Unit));

            if (_measurementId.HasValue)
            {
                var measurement = _repo.GetMeasurementById(_measurementId.Value); // Javítva!
                if (measurement != null)
                {
                    datePicker.Value = measurement.MeasurementDate;
                    timeComboBox.SelectedItem = measurement.MeasurementTime;
                    valueTextBox.Text = measurement.BloodSugarLevel.ToString();
                    unitComboBox.SelectedItem = measurement.MeasurementUnit;
                    notesRichTextBox.Text = measurement.Notes;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(valueTextBox.Text, out var bloodSugarLevel))
            {
                infoLabel.Text = "Please enter a valid number";
                return;
            }

            var measurement = _repo.GetMeasurementById(_measurementId ?? -1);
            if (measurement == null)
            {
                measurement = new Measurements();
            }
            measurement.UserId = _userId;
            measurement.MeasurementDate = datePicker.Value;
            measurement.MeasurementTime = (Measurements.Time)timeComboBox.SelectedItem;
            measurement.BloodSugarLevel = bloodSugarLevel;
            measurement.MeasurementUnit = (Measurements.Unit)unitComboBox.SelectedItem;
            measurement.Notes = notesRichTextBox.Text;

            if (_measurementId.HasValue)
            {
                _repo.UpdateMeasurement(measurement);
            }
            else
            {
                _repo.AddMeasurement(measurement);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
