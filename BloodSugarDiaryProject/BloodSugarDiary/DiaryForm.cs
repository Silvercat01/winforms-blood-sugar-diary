using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using BloodSugarClassLibrary.Data;
using BloodSugarClassLibrary.Models;
using BloodSugarClassLibrary.Repositories;
using BloodSugarDiary.Services;

namespace BloodSugarDiary
{
    public partial class DiaryForm : Form
    {
        private readonly int _userId;
        private readonly UserContext _context;
        private readonly MeasurementRepo _measurementsRepo;
        private readonly SaveFileDialog saveDialog;
        private List<Measurements> _allMeasurements = new List<Measurements>();

        public DiaryForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _context = new UserContext();
            _measurementsRepo = new MeasurementRepo(_context);
            this.Load += DiaryForm_Load;
            saveDialog = new SaveFileDialog
            {
                Filter = "XML fájlok (*.xml)|*.xml",
                Title = "Mérések exportálása XML-be"
            };
        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadMeasurements();

            measurementsDataGridView.CellFormatting += measurementsDataGridView_CellFormatting;
        }

        private void InitializeDataGridView()
        {
            // Töröljük az automatikusan generált oszlopokat (ha vannak)
            measurementsDataGridView.AutoGenerateColumns = false;
            measurementsDataGridView.Columns.Clear();

            // Oszlopok hozzáadása manuálisan
            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Visible = false
            });

            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Date",
                DataPropertyName = "MeasurementDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Time",
                HeaderText = "Time",
                DataPropertyName = "MeasurementTime",
                Width = 120
            });

            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BloodSugar",
                HeaderText = "Blood sugar",
                DataPropertyName = "BloodSugarLevel",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.0" },
                Width = 80
            });

            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Unit",
                HeaderText = "Unit",
                DataPropertyName = "MeasurementUnit",
                Width = 70
            });

            measurementsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Notes",
                HeaderText = "Notes",
                DataPropertyName = "Notes",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            measurementsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            measurementsDataGridView.EnableHeadersVisualStyles = false;
        }

        public void LoadMeasurements()
        {
            var measurements = _measurementsRepo.GetMeasurements(_userId);
            measurementsDataGridView.DataSource = measurements.ToList();
        }


        //cellák színezése
        private void measurementsDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                var row = measurementsDataGridView.Rows[e.RowIndex];
                double value = Convert.ToDouble(row.Cells[3].Value);
                var unit = (Measurements.Unit)Enum.Parse(typeof(Measurements.Unit), row.Cells[4].Value.ToString());

                // hipoglikémia
                if ((unit == BloodSugarClassLibrary.Models.Measurements.Unit.mmol_l && value < 4.0) ||
                    (unit == BloodSugarClassLibrary.Models.Measurements.Unit.mg_dl && value < 70.0))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.LightBlue;
                }
                // hiperglikémia
                else if ((unit == BloodSugarClassLibrary.Models.Measurements.Unit.mmol_l && value > 7.0) ||
                         (unit == BloodSugarClassLibrary.Models.Measurements.Unit.mg_dl && value > 125.0))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.PaleVioletRed;
                }
                else
                {
                    e.CellStyle.BackColor = System.Drawing.Color.White; // Alapértelmezett szín
                }
            }
        }

        private void editPatientDataButton_Click(object sender, EventArgs e)
        {
            PatientDataForm patientdataform = new PatientDataForm(LoginForm._userId);
            this.Hide();
            patientdataform.FormClosed += (s, args) => this.Close();
            patientdataform.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditMeasurementForm(_userId))
            {
                if (editForm.ShowDialog() == DialogResult.OK) // Figyeljük a visszatérési értéket
                {
                    LoadMeasurements(); // Kényszerített újratöltés
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (measurementsDataGridView.SelectedRows.Count == 0)
            {
                infoLabel.Text = "Please select a row to edit";
                return;
            }

            if (measurementsDataGridView.SelectedRows.Count > 1)
            {
                infoLabel.Text = "Please only select one row to edit";
                return;
            }

            int id = (int)measurementsDataGridView.SelectedRows[0].Cells["Id"].Value;
            using (var editForm = new EditMeasurementForm(_userId, id))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMeasurements();
                }
            }
        }


        // Kiválasztott mérés(ek) törlése
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (measurementsDataGridView.SelectedRows.Count == 0)
            {
                infoLabel.Text = "Please select a row to delete";
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the selected {measurementsDataGridView.SelectedRows.Count} measurement(s)?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            foreach (DataGridViewRow row in measurementsDataGridView.SelectedRows)
            {
                if (row.Cells["Id"].Value is int measurementId)
                {
                    _measurementsRepo.DeleteMeasurement(measurementId);
                }
            }
            LoadMeasurements();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // Mérési adatok megszerzése az adatforrásból
            var measurements = measurementsDataGridView.DataSource as List<Measurements>;

            if (measurements == null || measurements.Count == 0)
            {
                infoLabel.Text = "No data to export";
                return;
            }

            // SaveFileDialog megjelenítése a mentés helyének kiválasztásához
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (XmlExportService.TryExportMeasurementsToXml(measurements, saveDialog.FileName, out var error))
                {
                    infoLabel.Text = $"Successfully exported to {saveDialog.FileName}";
                }
                else
                {
                    infoLabel.Text = $"Export failed: {error}";
                }
            }
        }
    }
}
