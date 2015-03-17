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
        Note note0 = new Note();


        public frmNotepad()
        {
            InitializeComponent();
        }

        //Create New Document
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Check to see if text was modified.
            if (note0.fileModified == true)
            {
                DialogResult createNewFile = MessageBox.Show("Are you sure you wish to start a new file?", "Confirmation", MessageBoxButtons.YesNo);
                if (createNewFile == DialogResult.Yes)
                {
                    notePadField0.Text = "";
                    note0.fileModified = false;

                }else if(createNewFile == DialogResult.No)
                {
                    // Keep file
                }

            }else
            {
                //Do nothing, if false.
            }

        }


        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Catch empty path

            try
            {
                //Display save File Dialog
                saveFileDialog1.ShowDialog();
                saveFileDialog1.DefaultExt = "txt";

                //Set FileNamePath;
                note0.fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(note0.fileName, notePadField0.Text);
                note0.fileModified = false; //saved until next change
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: File not found, please select a different file.", "Error", MessageBoxButtons.OK);
            }

        }

        // Each time user changes the text field.
        private void notePadField0_TextChanged(object sender, EventArgs e)
        {
            note0.fileModified = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            note0.fileName = openFileDialog1.FileName;
            noteTab1.Text = note0.fileName; //Show filename in tab.


            try
            {
                StreamReader sr = new StreamReader(note0.fileName);
                String line = sr.ReadToEnd();
                notePadField0.Text = line;
                line = ""; //clear line from memory.

            }
            catch (IOException)
            {


            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //toggle sidebar visibility click.
             if(sidebarToolStripMenuItem.Checked == true)
            {
                sidebarToolStripMenuItem.Checked = false;
                tabControl1.Visible = false;

            }else if (sidebarToolStripMenuItem.Checked == false)
             {
                 sidebarToolStripMenuItem.Checked = true;
                 tabControl1.Visible = true;

             }
            

        }

    }




}