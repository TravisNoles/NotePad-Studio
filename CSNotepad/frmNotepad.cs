using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Dynamic;
using System.Reflection;
using System.Runtime.Remoting;



//Changes:
// Wordwrap, copy and pasting, opening file, saving file.


namespace CSNotepad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }
        //Create new text file in a new tab.
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //intialize accessors.

            NewFile newfilecreator = new NewFile();
            NewTextBox newtxtboxcreator= new NewTextBox();
            SaveFile savefilecreator = new SaveFile();
            NewTab newtabcreator = new NewTab();

            // Create new Random File (with default values)
            newfilecreator.CreateNewDefaultFile();

            //Set tabs currently open.
            newtabcreator.TabsOpen = tabCtrlFiles.TabCount;

            //Create tab with filename as text
            tabCtrlFiles.TabPages.Add(newfilecreator.DefaultName);
     
            //Create TextBox & Set Properties
            RichTextBox newTextBox = new RichTextBox(); //Create new instance of richtextbox and setup
            newTextBox.Name = newtxtboxcreator.Name;
            newTextBox.Multiline = true;
            newTextBox.WordWrap = wordWrapToolStripMenuItem.Checked; //if checked is true, sets wordwrap of new text file to true as well. extracts the bool value.
            newTextBox.Dock = DockStyle.Fill; // Fill dock to tab a new tab.

            // Add new tab.
            
            //tabControl2.TabPages[tabControl2.TabPages.Count - 1].Text = "New Text" + " " + tabControl2.TabPages.Count;
            tabCtrlFiles.TabPages[tabCtrlFiles.TabPages.Count - 1].Text = NewFile.DefaultName;
            this.tabCtrlFiles.TabPages[tabCtrlFiles.TabPages.Count - 1].Controls.Add(newTextBox); //Place textbox in new tab. (.count subroutine is returning from index 1 and not index 0)
            

            // http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically


        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Find textbox in current tab, and store new instance of it in txtname.
            SaveFile savefilehandler = new SaveFile();

            string currenttab = (tabCtrlFiles.SelectedIndex).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currenttab, true)[0];


            //Display savefile dialog to user.
            saveFileDialog1.ShowDialog();
            savefilehandler.Name = saveFileDialog1.FileName;



            if (savefilehandler.Name != "")//Prevents empty path (causing an empty path exception)
            {
                StreamWriter newtextfile = new StreamWriter(savefilehandler.Name);
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
            int selectedtab = tabCtrlFiles.SelectedIndex;
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + selectedtab, true)[0]; //Reference textbox for currently selected tab.


            //Open file manager for file selection
            openFileDialog1.ShowDialog();
            filenamepath = openFileDialog1.FileName;

            StreamReader openTxt = new StreamReader(filenamepath);
            txtname.Text = openTxt.ReadToEnd();
            tabCtrlFiles.TabPages[selectedtab].Text = Path.GetFileName(filenamepath);






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

        private void frmNotepad_Load(object sender, EventArgs e)
        {

        }
            
          

        private void debugMsg(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }



    }






}