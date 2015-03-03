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

        //Create New Document
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // if changed, prompt user if they want to loose all changes, then clear
            notePadField0.Text = ""; // Clear notepad field
            

        }


        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }


        // Each time user changes the text field.
        private void notePadField0_TextChanged(object sender, EventArgs e)
        {
          string NoteFileContent = notePadField0.Text;

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }
    
    }


    public class Node<T>
    {
        public T NoteFileName
        {
            get { return NoteFileName; }
            set { NoteFileName = value; }
        }
            






    }


}
