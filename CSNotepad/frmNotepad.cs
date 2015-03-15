using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSNotepad.Properties;
using System.IO;

namespace CSNotepad
{

    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        //Create New Document
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Note note0 = new Note();
                //Show Dialog (for saving files)
                saveFileDialog1.ShowDialog();

                //Set FileNamePath;
                note0.fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(note0.fileName, notePadField0.Text);

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: File not found, please select a different file.");
            }



        }

        // Each time user changes the text field.
        private void notePadField0_TextChanged(object sender, EventArgs e)
        {
            Note note0 = new Note();
            note0.fileModified = true;


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note note0 = new Note();
            openFileDialog1.ShowDialog();
            note0.fileName = openFileDialog1.FileName;
            noteTab1.Text = note0.fileName;


            try
            {
                StreamReader sr = new StreamReader(note0.fileName);
                String line = sr.ReadToEnd();
                notePadField0.Text = line;



            }
            catch (IOException)
            {


            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

    }




}