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
            //2) Create New File
            FileH newFile = new FileH();
            newFile.setNumOfTabs(tabCtrlFiles.TabCount);
            newFile.GenerateNew();
            newFile.getNewName();
            //debugMsg("Test", newFile.getNewName());


           //Generate Tab Data
           Tab newtab = new Tab();
           newtab.setNumOfTab(tabCtrlFiles.TabCount);
           newtab.GenerateNew(); //Generate new file with defaults
           tabCtrlFiles.TabPages.Add(newtab.getNewText(tabCtrlFiles.TabCount));


            RichTextBox newTextBox = new RichTextBox(); //Create new instance of richtextbox and setup
            TextBoxesH newTextBoxProps = new TextBoxesH();
            newTextBoxProps.setNumOfTabs(tabCtrlFiles.TabCount);
            newTextBoxProps.GenerateTextBox();
            newTextBox.Name = newTextBoxProps.getNewName();
            newTextBox.Text = newTextBoxProps.getNewText();
            newTextBox.Multiline = true;
            newTextBox.WordWrap = wordWrapToolStripMenuItem.Checked; //if checked is true, sets wordwrap of new text file to true as well. extracts the bool value.
            newTextBox.Dock = DockStyle.Fill; // Fill dock to tab a new tab.
            this.tabCtrlFiles.TabPages[tabCtrlFiles.TabPages.Count - 1].Controls.Add(newTextBox); //Place textbox in new tab. (.count subroutine is returning from index 1 and not index 0)



            // Add new tab.
            
            //tabControl2.TabPages[tabControl2.TabPages.Count - 1].Text = "New Text" + " " + tabControl2.TabPages.Count;
            //tabCtrlFiles.TabPages[tabCtrlFiles.TabPages.Count - 1].Text = newfile.Name;
            //
            

            // http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically


        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display savefile dialog to user.
            FileH saveFile = new FileH();
            saveFileDialog1.ShowDialog();

            //RichTextBox txtbx = (RichTextBox)Controls["textArea" + tabCtrlFiles.SelectedIndex.ToString()];
            int currenttabint = tabCtrlFiles.SelectedIndex + 1;
            string currentabstr = currenttabint.ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentabstr, true)[0];
            debugMsg("test", txtname.Name);
            saveFile.Save(tabCtrlFiles.SelectedIndex, saveFileDialog1.FileName, txtname.Text);
  

            
        }

        // Each time user changes the text field.
        private void textArea0_TextChanged(object sender, EventArgs e)
        {


            //filehandler.setFilePropertyModified(tabControl2.SelectedIndex, true); // Change selected tab for file to modified.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filenamepath;
            string currentab = (tabCtrlFiles.SelectedIndex + 1).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentab, true)[0];


            //Open file manager for file selection
            openFileDialog1.ShowDialog();
            filenamepath = openFileDialog1.FileName;
            FileH openfile = new FileH();

  
            tabCtrlFiles.TabPages[tabCtrlFiles.SelectedIndex].Text = Path.GetFileName(filenamepath);
            openfile.OpenExisting(tabCtrlFiles.SelectedIndex, filenamepath);
            txtname.Text = openfile.getExistingText(tabCtrlFiles.SelectedIndex);






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
            //TODO: Call selected textbox dynamically
            string currentab = (tabCtrlFiles.SelectedIndex + 1).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentab, true)[0];
        }

        // Paste text into textbox area (from clipboard)
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentab = (tabCtrlFiles.SelectedIndex + 1).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentab, true)[0];
            Clipboard.GetText();
            txtname.Paste();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + tabCtrlFiles.SelectedIndex + 1.ToString(), true)[0];


            //toggle wordwrap toggling
            if (sidebarToolStripMenuItem.Checked == true)
            {
                txtname.WordWrap = false;

            }


            if (sidebarToolStripMenuItem.Checked == false)
            {
                txtname.WordWrap = true;

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
            string currentab = (tabCtrlFiles.SelectedIndex + 1).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentab, true)[0];
            txtname.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentab = (tabCtrlFiles.SelectedIndex + 1).ToString();
            RichTextBox txtname = (RichTextBox)this.Controls.Find("textArea" + currentab, true)[0];
            txtname.Redo();
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