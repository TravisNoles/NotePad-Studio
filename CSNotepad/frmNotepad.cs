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
using System.Dynamic;

//Changes:
// Wordwrap, copy and pasting, opening file, saving file.


namespace CSNotepad
{
    public partial class frmNotepad : Form
    {
        //Create new instance of file class.
        //File filehandler = new File();
        //Tab tabhandler = new Tab();

        //Tab Dictionary: tabIndex, TabData(TabName, TabText);
        //Dictionary<int, List<string>> TabStor = new Dictionary<int, List<string>>();
        //File dictionary: index, FileData(FileName, FilePath, FileText, ismodified)


        public frmNotepad()
        {
            InitializeComponent();
        }


        //Create new text file in a new tab.
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Create the FileName (randomize)
            string fileName = System.IO.Path.GetRandomFileName();

            StreamWriter newtext = new StreamWriter(fileName);
            
            newtext.WriteLine(""); //Write new file (blank)
            
            //Create TextBox & Set Properties
            RichTextBox newTextBox = new RichTextBox(); //Create new instance of richtextbox and setup
            newTextBox.Name = "textArea" + tabControl2.TabCount; //increase the total by 1, to create the tab on the right.
            MessageBox.Show(newTextBox.Name, "test", MessageBoxButtons.OK);
            newTextBox.Multiline = true;
            newTextBox.WordWrap = wordWrapToolStripMenuItem.Checked; //if checked is true, sets wordwrap of new text file to true as well. extracts the bool value.
            newTextBox.Dock = DockStyle.Fill; // Fill dock to tab a new tab.

            // Add new tab.
            tabControl2.TabPages.Add("test");
            //tabControl2.TabPages[tabControl2.TabPages.Count - 1].Text = "New Text" + " " + tabControl2.TabPages.Count;
            tabControl2.TabPages[tabControl2.TabPages.Count - 1].Text = fileName;
            this.tabControl2.TabPages[tabControl2.TabPages.Count - 1].Controls.Add(newTextBox); //Place textbox in new tab. (.count subroutine is returning from index 1 and not index 0)
            

            // http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically


        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Find textbox in current tab, and store new instance of it in txtname.

            string currenttab = (tabControl2.SelectedIndex).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currenttab, true)[0];


            //Display savefile dialog to user.
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;


            //Prevents empty path (causing an empty path exception)
            if (filename != "")
            {
                StreamWriter newtextfile = new StreamWriter(filename);
                //Save file to user specified folder.
                newtextfile.WriteLine(txtname.Text);
                newtextfile.Close();

            }

            
        }

        // Each time user changes the text field.
        private void textArea0_TextChanged(object sender, EventArgs e)
        {
            //filehandler.setFilePropertyModified(tabControl2.SelectedIndex, true); // Change selected tab for file to modified.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filenamepath;
            int selectedtab = tabControl2.SelectedIndex;
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + selectedtab, true)[0]; //Reference textbox for currently selected tab.


            //Open file manager for file selection
            openFileDialog1.ShowDialog();
            filenamepath = openFileDialog1.FileName;

            StreamReader openTxt = new StreamReader(filenamepath);
            txtname.Text = openTxt.ReadToEnd();
            tabControl2.TabPages[selectedtab].Text = Path.GetFileName(filenamepath);






        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        //Change visibility of sidebar when clicking.
        private void sidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle sidebar visibility click.
            if(sidebarToolStripMenuItem.Checked == true)
            {
                //sidebarToolStripMenuItem.Checked = true;
                tabControl1.Visible = true;
            }


            if (sidebarToolStripMenuItem.Checked == false)
            {
                 //sidebarToolStripMenuItem.Checked = true;
                 tabControl1.Visible = false;

            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textArea0.SelectedText);
        }

        // Paste text into textbox area (from clipboard)
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.GetText();
            textArea0.Paste();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //toggle wordwrap toggling
            if (sidebarToolStripMenuItem.Checked == true)
            {
                textArea0.WordWrap = false;

            }


            if (sidebarToolStripMenuItem.Checked == false)
            {
                textArea0.WordWrap = true;

            }



        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            



        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: add undo
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: add redo.
        }
            
          


    }






}