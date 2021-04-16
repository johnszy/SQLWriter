
namespace SQLWriter
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.totalRepsRadio = new System.Windows.Forms.RadioButton();
            this.consistRadio = new System.Windows.Forms.RadioButton();
            this.PatientID = new System.Windows.Forms.Label();
            this.sessions = new System.Windows.Forms.Label();
            this.numReps = new System.Windows.Forms.Label();
            this.consistencyGroup = new System.Windows.Forms.GroupBox();
            this.days5by12 = new System.Windows.Forms.RadioButton();
            this.days5by8 = new System.Windows.Forms.RadioButton();
            this.days5by4 = new System.Windows.Forms.RadioButton();
            this.days5by2 = new System.Windows.Forms.RadioButton();
            this.days14 = new System.Windows.Forms.RadioButton();
            this.days7 = new System.Windows.Forms.RadioButton();
            this.patientID_textBox = new System.Windows.Forms.TextBox();
            this.genQuery = new System.Windows.Forms.Button();
            this.queryResult_textBox = new System.Windows.Forms.TextBox();
            this.sessions_textBox = new System.Windows.Forms.TextBox();
            this.totReps_textBox = new System.Windows.Forms.TextBox();
            this.saveFile_button = new System.Windows.Forms.Button();
            this.loadTextFile = new System.Windows.Forms.Button();
            this.status_textBox = new System.Windows.Forms.TextBox();
            this.consistencyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(646, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // totalRepsRadio
            // 
            this.totalRepsRadio.AutoSize = true;
            this.totalRepsRadio.Checked = true;
            this.totalRepsRadio.Location = new System.Drawing.Point(80, 89);
            this.totalRepsRadio.Name = "totalRepsRadio";
            this.totalRepsRadio.Size = new System.Drawing.Size(77, 17);
            this.totalRepsRadio.TabIndex = 1;
            this.totalRepsRadio.TabStop = true;
            this.totalRepsRadio.Text = "Total Reps";
            this.totalRepsRadio.UseVisualStyleBackColor = true;
            this.totalRepsRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // consistRadio
            // 
            this.consistRadio.AutoSize = true;
            this.consistRadio.Location = new System.Drawing.Point(558, 89);
            this.consistRadio.Name = "consistRadio";
            this.consistRadio.Size = new System.Drawing.Size(121, 17);
            this.consistRadio.TabIndex = 2;
            this.consistRadio.TabStop = true;
            this.consistRadio.Text = "Weekly Consistency";
            this.consistRadio.UseVisualStyleBackColor = true;
            this.consistRadio.CheckedChanged += new System.EventHandler(this.consistRadio_CheckedChanged);
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Location = new System.Drawing.Point(80, 52);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(51, 13);
            this.PatientID.TabIndex = 3;
            this.PatientID.Text = "PatientID";
            this.PatientID.Click += new System.EventHandler(this.PatientID_Click);
            // 
            // sessions
            // 
            this.sessions.AutoSize = true;
            this.sessions.Location = new System.Drawing.Point(80, 141);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(49, 13);
            this.sessions.TabIndex = 4;
            this.sessions.Text = "Sessions";
            // 
            // numReps
            // 
            this.numReps.AutoSize = true;
            this.numReps.Location = new System.Drawing.Point(80, 175);
            this.numReps.Name = "numReps";
            this.numReps.Size = new System.Drawing.Size(59, 13);
            this.numReps.TabIndex = 5;
            this.numReps.Text = "Total Reps";
            this.numReps.Click += new System.EventHandler(this.numReps_Click);
            // 
            // consistencyGroup
            // 
            this.consistencyGroup.Controls.Add(this.days5by12);
            this.consistencyGroup.Controls.Add(this.days5by8);
            this.consistencyGroup.Controls.Add(this.days5by4);
            this.consistencyGroup.Controls.Add(this.days5by2);
            this.consistencyGroup.Controls.Add(this.days14);
            this.consistencyGroup.Controls.Add(this.days7);
            this.consistencyGroup.Location = new System.Drawing.Point(558, 127);
            this.consistencyGroup.Name = "consistencyGroup";
            this.consistencyGroup.Size = new System.Drawing.Size(288, 111);
            this.consistencyGroup.TabIndex = 6;
            this.consistencyGroup.TabStop = false;
            this.consistencyGroup.Text = "Consistency Case";
            // 
            // days5by12
            // 
            this.days5by12.AutoSize = true;
            this.days5by12.Location = new System.Drawing.Point(158, 76);
            this.days5by12.Name = "days5by12";
            this.days5by12.Size = new System.Drawing.Size(109, 17);
            this.days5by12.TabIndex = 5;
            this.days5by12.TabStop = true;
            this.days5by12.Text = "5 days/week 12X";
            this.days5by12.UseVisualStyleBackColor = true;
            this.days5by12.CheckedChanged += new System.EventHandler(this.days5by12_CheckedChanged);
            // 
            // days5by8
            // 
            this.days5by8.AutoSize = true;
            this.days5by8.Location = new System.Drawing.Point(158, 50);
            this.days5by8.Name = "days5by8";
            this.days5by8.Size = new System.Drawing.Size(103, 17);
            this.days5by8.TabIndex = 4;
            this.days5by8.TabStop = true;
            this.days5by8.Text = "5 days/week 8X";
            this.days5by8.UseVisualStyleBackColor = true;
            this.days5by8.CheckedChanged += new System.EventHandler(this.days5by8_CheckedChanged);
            // 
            // days5by4
            // 
            this.days5by4.AutoSize = true;
            this.days5by4.Location = new System.Drawing.Point(158, 25);
            this.days5by4.Name = "days5by4";
            this.days5by4.Size = new System.Drawing.Size(103, 17);
            this.days5by4.TabIndex = 3;
            this.days5by4.TabStop = true;
            this.days5by4.Text = "5 days/week 4X";
            this.days5by4.UseVisualStyleBackColor = true;
            this.days5by4.CheckedChanged += new System.EventHandler(this.days5by4_CheckedChanged);
            // 
            // days5by2
            // 
            this.days5by2.AutoSize = true;
            this.days5by2.Location = new System.Drawing.Point(15, 76);
            this.days5by2.Name = "days5by2";
            this.days5by2.Size = new System.Drawing.Size(103, 17);
            this.days5by2.TabIndex = 2;
            this.days5by2.TabStop = true;
            this.days5by2.Text = "5 days/week 2X";
            this.days5by2.UseVisualStyleBackColor = true;
            this.days5by2.CheckedChanged += new System.EventHandler(this.days5by2_CheckedChanged);
            // 
            // days14
            // 
            this.days14.AutoSize = true;
            this.days14.Location = new System.Drawing.Point(15, 51);
            this.days14.Name = "days14";
            this.days14.Size = new System.Drawing.Size(64, 17);
            this.days14.TabIndex = 1;
            this.days14.TabStop = true;
            this.days14.Text = "14 Days";
            this.days14.UseVisualStyleBackColor = true;
            this.days14.CheckedChanged += new System.EventHandler(this.days14_CheckedChanged);
            // 
            // days7
            // 
            this.days7.AutoSize = true;
            this.days7.Checked = true;
            this.days7.Location = new System.Drawing.Point(15, 25);
            this.days7.Name = "days7";
            this.days7.Size = new System.Drawing.Size(58, 17);
            this.days7.TabIndex = 0;
            this.days7.TabStop = true;
            this.days7.Text = "7 Days";
            this.days7.UseVisualStyleBackColor = true;
            this.days7.CheckedChanged += new System.EventHandler(this.days7_CheckedChanged);
            // 
            // patientID_textBox
            // 
            this.patientID_textBox.Location = new System.Drawing.Point(161, 49);
            this.patientID_textBox.Name = "patientID_textBox";
            this.patientID_textBox.Size = new System.Drawing.Size(243, 20);
            this.patientID_textBox.TabIndex = 7;
            this.patientID_textBox.Text = "dedffe93-90f2-4d96-9710-6a715d37a788";
            this.patientID_textBox.TextChanged += new System.EventHandler(this.patientID_textBox_TextChanged);
            // 
            // genQuery
            // 
            this.genQuery.Location = new System.Drawing.Point(790, 272);
            this.genQuery.Name = "genQuery";
            this.genQuery.Size = new System.Drawing.Size(121, 23);
            this.genQuery.TabIndex = 8;
            this.genQuery.Text = "Gen SQL Query";
            this.genQuery.UseVisualStyleBackColor = true;
            this.genQuery.Click += new System.EventHandler(this.genQuery_Click);
            // 
            // queryResult_textBox
            // 
            this.queryResult_textBox.Location = new System.Drawing.Point(34, 310);
            this.queryResult_textBox.Multiline = true;
            this.queryResult_textBox.Name = "queryResult_textBox";
            this.queryResult_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.queryResult_textBox.Size = new System.Drawing.Size(877, 146);
            this.queryResult_textBox.TabIndex = 9;
            this.queryResult_textBox.Text = "SQL Query String";
            this.queryResult_textBox.WordWrap = false;
            // 
            // sessions_textBox
            // 
            this.sessions_textBox.Location = new System.Drawing.Point(161, 138);
            this.sessions_textBox.Name = "sessions_textBox";
            this.sessions_textBox.Size = new System.Drawing.Size(36, 20);
            this.sessions_textBox.TabIndex = 10;
            this.sessions_textBox.Text = "100";
            this.sessions_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sessions_textBox.TextChanged += new System.EventHandler(this.sessions_textBox_TextChanged);
            // 
            // totReps_textBox
            // 
            this.totReps_textBox.Location = new System.Drawing.Point(161, 172);
            this.totReps_textBox.Name = "totReps_textBox";
            this.totReps_textBox.Size = new System.Drawing.Size(36, 20);
            this.totReps_textBox.TabIndex = 11;
            this.totReps_textBox.Text = "5000";
            this.totReps_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totReps_textBox.TextChanged += new System.EventHandler(this.totReps_textBox_TextChanged);
            // 
            // saveFile_button
            // 
            this.saveFile_button.Location = new System.Drawing.Point(743, 476);
            this.saveFile_button.Name = "saveFile_button";
            this.saveFile_button.Size = new System.Drawing.Size(168, 23);
            this.saveFile_button.TabIndex = 12;
            this.saveFile_button.Text = "Save SQL Query File";
            this.saveFile_button.UseVisualStyleBackColor = true;
            this.saveFile_button.Click += new System.EventHandler(this.saveFile_button_Click);
            // 
            // loadTextFile
            // 
            this.loadTextFile.Location = new System.Drawing.Point(412, 476);
            this.loadTextFile.Name = "loadTextFile";
            this.loadTextFile.Size = new System.Drawing.Size(127, 23);
            this.loadTextFile.TabIndex = 13;
            this.loadTextFile.Text = "Open Text File";
            this.loadTextFile.UseVisualStyleBackColor = true;
            this.loadTextFile.Click += new System.EventHandler(this.loadTextFile_Click);
            // 
            // status_textBox
            // 
            this.status_textBox.Location = new System.Drawing.Point(34, 476);
            this.status_textBox.Multiline = true;
            this.status_textBox.Name = "status_textBox";
            this.status_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status_textBox.Size = new System.Drawing.Size(321, 23);
            this.status_textBox.TabIndex = 14;
            this.status_textBox.Text = "Debug Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SQLWriter.Properties.Resources.SQLWriterBackground;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.status_textBox);
            this.Controls.Add(this.loadTextFile);
            this.Controls.Add(this.saveFile_button);
            this.Controls.Add(this.totReps_textBox);
            this.Controls.Add(this.sessions_textBox);
            this.Controls.Add(this.queryResult_textBox);
            this.Controls.Add(this.genQuery);
            this.Controls.Add(this.patientID_textBox);
            this.Controls.Add(this.consistencyGroup);
            this.Controls.Add(this.numReps);
            this.Controls.Add(this.sessions);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.consistRadio);
            this.Controls.Add(this.totalRepsRadio);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "SQL Writer";
            this.consistencyGroup.ResumeLayout(false);
            this.consistencyGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton totalRepsRadio;
        private System.Windows.Forms.RadioButton consistRadio;
        private System.Windows.Forms.Label PatientID;
        private System.Windows.Forms.Label sessions;
        private System.Windows.Forms.Label numReps;
        private System.Windows.Forms.GroupBox consistencyGroup;
        private System.Windows.Forms.RadioButton days5by12;
        private System.Windows.Forms.RadioButton days5by8;
        private System.Windows.Forms.RadioButton days5by4;
        private System.Windows.Forms.RadioButton days5by2;
        private System.Windows.Forms.RadioButton days14;
        private System.Windows.Forms.RadioButton days7;
        private System.Windows.Forms.TextBox patientID_textBox;
        private System.Windows.Forms.Button genQuery;
        private System.Windows.Forms.TextBox queryResult_textBox;
        private System.Windows.Forms.TextBox sessions_textBox;
        private System.Windows.Forms.TextBox totReps_textBox;
        private System.Windows.Forms.Button saveFile_button;
        private System.Windows.Forms.Button loadTextFile;
        private System.Windows.Forms.TextBox status_textBox;
    }
}

