namespace BloodSugarDiary
{
    partial class DiaryForm
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
            editPatientDataButton = new Button();
            tabControl1 = new TabControl();
            Measurements = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exportButton = new Button();
            addButton = new Button();
            editButton = new Button();
            infoLabel = new Label();
            deleteButton = new Button();
            measurementsDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            Measurements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)measurementsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // editPatientDataButton
            // 
            editPatientDataButton.Location = new Point(7, 383);
            editPatientDataButton.Name = "editPatientDataButton";
            editPatientDataButton.Size = new Size(145, 29);
            editPatientDataButton.TabIndex = 0;
            editPatientDataButton.Text = "Edit Patient Data";
            editPatientDataButton.UseVisualStyleBackColor = true;
            editPatientDataButton.Click += editPatientDataButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Measurements);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 451);
            tabControl1.TabIndex = 1;
            // 
            // Measurements
            // 
            Measurements.Controls.Add(label3);
            Measurements.Controls.Add(label2);
            Measurements.Controls.Add(label1);
            Measurements.Controls.Add(exportButton);
            Measurements.Controls.Add(addButton);
            Measurements.Controls.Add(editButton);
            Measurements.Controls.Add(infoLabel);
            Measurements.Controls.Add(deleteButton);
            Measurements.Controls.Add(measurementsDataGridView);
            Measurements.Controls.Add(editPatientDataButton);
            Measurements.Location = new Point(4, 29);
            Measurements.Name = "Measurements";
            Measurements.Padding = new Padding(3);
            Measurements.Size = new Size(792, 418);
            Measurements.TabIndex = 0;
            Measurements.Text = "Measurements";
            Measurements.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(680, 390);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 9;
            label3.Text = "hypoglycemia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleVioletRed;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(568, 390);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 8;
            label2.Text = "hyperglycemia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 390);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "color codes:";
            // 
            // exportButton
            // 
            exportButton.Location = new Point(158, 383);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(271, 29);
            exportButton.TabIndex = 6;
            exportButton.Text = "Export measurements to XML";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(489, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(589, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(184, 13);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(13, 20);
            infoLabel.TabIndex = 3;
            infoLabel.Text = " ";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(689, 6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // measurementsDataGridView
            // 
            measurementsDataGridView.BackgroundColor = Color.White;
            measurementsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            measurementsDataGridView.GridColor = Color.Gray;
            measurementsDataGridView.Location = new Point(7, 41);
            measurementsDataGridView.Name = "measurementsDataGridView";
            measurementsDataGridView.RowHeadersWidth = 51;
            measurementsDataGridView.Size = new Size(776, 336);
            measurementsDataGridView.TabIndex = 1;
            // 
            // DiaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "DiaryForm";
            Text = "DiaryForm";
            tabControl1.ResumeLayout(false);
            Measurements.ResumeLayout(false);
            Measurements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)measurementsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goToPatientDataButton;
        private Button deleteButton;
        private Button editPatientDataButton;
        private TabControl tabControl1;
        private TabPage Measurements;
        private TabPage tabPage2;
        private DataGridView measurementsDataGridView;
        private Label infoLabel;
        private Button editButton;
        private Button addButton;
        private Button exportButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox timeIntervalGroupBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private ComboBox diagramTypeComboBox;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}