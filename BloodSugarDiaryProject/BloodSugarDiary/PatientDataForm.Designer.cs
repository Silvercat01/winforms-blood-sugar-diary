namespace BloodSugarDiary
{
    partial class PatientDataForm
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
            patientDataSaveChanges = new Button();
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateOfBirthTextBox = new Label();
            birthDateTimePicker = new DateTimePicker();
            infoLabel = new Label();
            patientDataCancelButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // patientDataSaveChanges
            // 
            patientDataSaveChanges.BackColor = Color.FromArgb(255, 224, 192);
            patientDataSaveChanges.Location = new Point(227, 336);
            patientDataSaveChanges.Name = "patientDataSaveChanges";
            patientDataSaveChanges.Size = new Size(141, 29);
            patientDataSaveChanges.TabIndex = 0;
            patientDataSaveChanges.Text = "Save changes";
            patientDataSaveChanges.UseVisualStyleBackColor = false;
            patientDataSaveChanges.Click += patientDataSaveChanges_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(97, 130);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(454, 130);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(250, 27);
            addressTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(97, 230);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(250, 27);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 95);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 95);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 195);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone number";
            // 
            // dateOfBirthTextBox
            // 
            dateOfBirthTextBox.AutoSize = true;
            dateOfBirthTextBox.Location = new Point(454, 195);
            dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            dateOfBirthTextBox.Size = new Size(94, 20);
            dateOfBirthTextBox.TabIndex = 8;
            dateOfBirthTextBox.Text = "Date of birth";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(454, 230);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.ShowCheckBox = true;
            birthDateTimePicker.Size = new Size(250, 27);
            birthDateTimePicker.TabIndex = 9;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(377, 383);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(13, 20);
            infoLabel.TabIndex = 10;
            infoLabel.Text = " ";
            // 
            // patientDataCancelButton
            // 
            patientDataCancelButton.BackColor = Color.FromArgb(255, 224, 192);
            patientDataCancelButton.Location = new Point(424, 336);
            patientDataCancelButton.Name = "patientDataCancelButton";
            patientDataCancelButton.Size = new Size(141, 29);
            patientDataCancelButton.TabIndex = 11;
            patientDataCancelButton.Text = "Cancel";
            patientDataCancelButton.UseVisualStyleBackColor = false;
            patientDataCancelButton.Click += patientDataCancelButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Green;
            label4.Location = new Point(639, 195);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 12;
            label4.Text = "optional";
            // 
            // PatientDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(patientDataCancelButton);
            Controls.Add(infoLabel);
            Controls.Add(birthDateTimePicker);
            Controls.Add(dateOfBirthTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(patientDataSaveChanges);
            Name = "PatientDataForm";
            Text = "PatientDataForm";
            Load += PatientDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button patientDataSaveChanges;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label dateOfBirthTextBox;
        private DateTimePicker birthDateTimePicker;
        private Label infoLabel;
        private Button patientDataCancelButton;
        private Label label4;
    }
}