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

namespace CSNotepad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int[] NoteTabProperties = {1};
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        //Create New Document
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // if changed, prompt user if they want to loose all changes, then clear.
            notePadField0.Text = ""; // Clear notepad field

        }


        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void notePadField0_TextChanged(object sender, EventArgs e)
        {
            string fileName = saveFileDialog1.FileName;


            var SaveNoteProc = new Note<int>(0, "default0.txt", "1");

        }


    
    
    
    }
}
