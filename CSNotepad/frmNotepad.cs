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
    struct Notes
    {
        //https://msdn.microsoft.com/en-us/library/aa288471(v=vs.71).aspx

        private string fileNamePrivate; // includes path
        private string fileContentPrivate;
        DateTime fileModTimeStampPrivate;

        public string noteFileContent
        {
            get
            {
                return fileContentPrivate;
            }

            set
            {
                fileContentPrivate = value;
            }

        }

        public string fileName
        {
            get
            {
                return fileNamePrivate;
            }

            set
            {
                fileNamePrivate = value;
            }

        }

        public DateTime fileModTimeStamp
        {
            get
            {
                return fileModTimeStampPrivate;
            }

            set
            {
                fileModTimeStampPrivate = value;
            }

        }

    }

    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        //Create New Document
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Setup first note.
            Notes note0 = new Notes();
            
            if (DateTime.Now > note0.fileModTimeStamp)
            {
                //MessageBox.Show("Current date IS greater than stored date." + note0.fileModTimeStamp);
                DialogResult newNoteFile = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if(newNoteFile == DialogResult.Yes)
                {
                    //Save changes to file


                }
                else if (DialogResult == DialogResult.No)
                {
                    // Discard any changes and start a new file.
                    note0.fileModTimeStamp = DateTime.Now;
                    notePadField0.Text = ""; //clear text field

                }else
                {


                }




            }


        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                Notes note0 = new Notes();

                //Show Dialog (for saving files)
                saveFileDialog1.ShowDialog();

                //Set FileNamePath;
                note0.fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(note0.fileName, notePadField0.Text);

            }catch (FileNotFoundException)
            {
                MessageBox.Show("Error: File not found, please select a different file.");
            }



        }

        // Each time user changes the text field.
        private void notePadField0_TextChanged(object sender, EventArgs e)
        {
            //Notes note0;
            //note0.fileContent = notePadField0.Text;
           

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }
    
    }

}
