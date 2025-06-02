using BloodSugarClassLibrary.Data;
using BloodSugarClassLibrary.Models;
using BloodSugarClassLibrary.Repositories;

namespace BloodSugarDiary
{
    public partial class PatientDataForm : Form
    {
        private int _userId;
        private readonly UserContext _context = new UserContext();
        private PatientRepository _patientRepo;

        public PatientDataForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _patientRepo = new PatientRepository(_context);
        }

        private void PatientDataForm_Load(object sender, EventArgs e)
        {
            var patient = _patientRepo.GetPatientByUserId(_userId);

            if (patient != null)
            {
                nameTextBox.Text = patient.Name;
                addressTextBox.Text = patient.Address;
                phoneNumberTextBox.Text = patient.PhoneNumber;

                if (patient.DateOfBirth.HasValue)
                {
                    birthDateTimePicker.Value = patient.DateOfBirth.Value;
                    birthDateTimePicker.Checked = true;
                }
                else
                {
                    birthDateTimePicker.Checked = false;
                    birthDateTimePicker.Value = DateTime.Today; // Alapértelmezett dátum
                }
            }
        }

        private void patientDataSaveChanges_Click(object sender, EventArgs e)
        {
            // 1. Megpróbáljuk lekérni a meglévő pácienst
            var patient = _patientRepo.GetPatientByUserId(_userId);

            // 2. Ha nem létezik, létrehozunk egy újat (mert csak akkor hozunk létre páciens táblát a felhasználóhoz ha szükség van rá, mert ha már regisztrációnál létrehoznánk akkor azt próbálná üresen elmenteni és errort dobna)
            if (patient == null)
            {
                patient = new Patient
                {
                    UserId = _userId,
                    Name = nameTextBox.Text,
                    Address = addressTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                    DateOfBirth = birthDateTimePicker.Checked ? birthDateTimePicker.Value : (DateTime?)null
                };
                _patientRepo.AddPatient(patient);
            }
            // 3. Ha létezik, frissítjük
            else
            {
                patient.Name = nameTextBox.Text;
                patient.Address = addressTextBox.Text;
                patient.PhoneNumber = phoneNumberTextBox.Text;
                patient.DateOfBirth = birthDateTimePicker.Checked ? birthDateTimePicker.Value : null;
                _patientRepo.UpdatePatient(patient);
            }

            infoLabel.Text = "Data successfully saved";
            DiaryForm diaryform = new DiaryForm(_userId);
            this.Hide();
            diaryform.FormClosed += (s, args) => this.Close();
            diaryform.Show();
        }

        private void patientDataCancelButton_Click(object sender, EventArgs e)
        {
            DiaryForm diaryform = new DiaryForm(_userId);
            this.Hide();
            diaryform.FormClosed += (s, args) => this.Close();
            diaryform.Show();
        }
    }
}