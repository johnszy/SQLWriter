using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace SQLWriter
{
    public partial class Form1 : Form
    {
        Process p = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (totalRepsRadio.Checked == true)
                p.repsChosen = true;
            else
                p.repsChosen = false;
        }

        private void numReps_Click(object sender, EventArgs e)
        {

        }
    

        private void sessions_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p.numSession = Int32.Parse(sessions_textBox.Text);
            }
            catch (FormatException)
            {
                sessions_textBox.Text = "100";
            }
            p.numSession = Int32.Parse(sessions_textBox.Text);
        }

        private void totReps_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p.numReps = Int32.Parse(totReps_textBox.Text);
            }
            catch (FormatException)
            {
                totReps_textBox.Text = "5000";
            }
            p.numReps = Int32.Parse(totReps_textBox.Text);
        }

        private void genQuery_Click(object sender, EventArgs e)
        {
            string query = p.GenQuery();
            queryResult_textBox.Text = query;
        }

        private void saveFile_button_Click(object sender, EventArgs e)
        {
            p.SaveFile(queryResult_textBox.Text);
        }

        private  async void loadTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                //Open file dialog, allows you to select a txt file
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {

                            queryResult_textBox.Text = await sr.ReadToEndAsync();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consistRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (consistRadio.Checked == true)
                p.repsChosen = false;
            else
                p.repsChosen = true;

        }

        private void patientID_textBox_TextChanged(object sender, EventArgs e)
        {
            p.patientGuid = patientID_textBox.Text;
        }

        private void PatientID_Click(object sender, EventArgs e)
        {
            patientID_textBox.Text = "dedffe93-90f2-4d96-9710-6a715d37a788";
            p.patientGuid = patientID_textBox.Text;
        }

        private void days7_CheckedChanged(object sender, EventArgs e)
        {
            p.days7Chosen = days7.Checked;
        }

        private void days14_CheckedChanged(object sender, EventArgs e)
        {
            p.days14Chosen = days14.Checked;
        }

        private void days5by2_CheckedChanged(object sender, EventArgs e)
        {
            p.days5by2Chosen = days5by2.Checked;
        }

        private void days5by4_CheckedChanged(object sender, EventArgs e)
        {
            p.days5by4Chosen = days5by4.Checked;
        }

        private void days5by8_CheckedChanged(object sender, EventArgs e)
        {
            p.days5by8Chosen = days5by8.Checked;
        }

        private void days5by12_CheckedChanged(object sender, EventArgs e)
        {
            p.days5by12Chosen = days5by12.Checked;
        }
    }
}
