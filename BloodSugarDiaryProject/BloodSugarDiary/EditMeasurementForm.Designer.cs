namespace BloodSugarDiary
{
    partial class EditMeasurementForm
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
            datePicker = new DateTimePicker();
            timeComboBox = new ComboBox();
            valueTextBox = new TextBox();
            unitComboBox = new ComboBox();
            notesRichTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            infoLabel = new Label();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(79, 91);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(300, 27);
            datePicker.TabIndex = 0;
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Location = new Point(440, 91);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(275, 28);
            timeComboBox.TabIndex = 1;
            // 
            // valueTextBox
            // 
            valueTextBox.Location = new Point(79, 178);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(122, 27);
            valueTextBox.TabIndex = 2;
            // 
            // unitComboBox
            // 
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(257, 177);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(122, 28);
            unitComboBox.TabIndex = 3;
            // 
            // notesRichTextBox
            // 
            notesRichTextBox.Location = new Point(440, 178);
            notesRichTextBox.Name = "notesRichTextBox";
            notesRichTextBox.Size = new Size(275, 219);
            notesRichTextBox.TabIndex = 4;
            notesRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 59);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 5;
            label1.Text = "Date of measurement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 145);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 7;
            label3.Text = "Measured value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 145);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 145);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "Notes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Green;
            label7.Location = new Point(650, 145);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 11;
            label7.Text = "optional";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(255, 224, 192);
            saveButton.Location = new Point(79, 368);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(122, 29);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 224, 192);
            cancelButton.Location = new Point(257, 368);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 29);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(83, 236);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(13, 20);
            infoLabel.TabIndex = 15;
            infoLabel.Text = " ";
            // 
            // EditMeasurementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(infoLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(notesRichTextBox);
            Controls.Add(unitComboBox);
            Controls.Add(valueTextBox);
            Controls.Add(timeComboBox);
            Controls.Add(datePicker);
            Name = "EditMeasurementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePicker;
        private ComboBox timeComboBox;
        private TextBox valueTextBox;
        private ComboBox unitComboBox;
        private RichTextBox notesRichTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button saveButton;
        private Button cancelButton;
        private Label infoLabel;
    }
}