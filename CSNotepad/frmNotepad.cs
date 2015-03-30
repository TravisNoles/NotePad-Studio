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

        //File newFile = new File();
        //File saveFile = new File();
        //File openFile = new File();
        File newFile = new File();
        Tab newTab = new Tab();

        //TextFormatting textFormattingTool = new TextFormatting();

        public frmNotepad()
        {
            InitializeComponent();
        }

        //Create New Document in a tab
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                    //Setup variables
                    newFile.CreateNew(tabControl2.TabCount); //setup tab
                    createNewTab(); // Create New tab GUI
        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog
            // Get filename that was selected.
            // Set filename in dialog.
            // Open the file in a new tab

            try
            {
                if (newFile.IsModified[tabControl2.SelectedIndex] == true)
                {
                    //Show Dialog
                    saveFileDialog1.ShowDialog();
                    //Get filename from savefiledialog and set it
                    Path.GetFileName(newFile.FileName[tabControl2.SelectedIndex]);
                    saveFileDialog1.OpenFile();

                }else if (newFile.IsModified[tabControl2.SelectedIndex] == false)
                {



                }


            }catch(PathTooLongException)
            {
                DialogResult createNewFile = MessageBox.Show("ERROR: Path/file name is too long, please rename to a shorter file name.", "ERROR", MessageBoxButtons.OK);
            }



            /*
            try
            {
                if (newFile.IsModified[tabControl2.SelectedIndex] == true)
                {
                   saveFileDialog1.ShowDialog();
                   string filename = "";
                   Path.GetFileName(filename);
                   newFile.saveNew(tabControl2.SelectedIndex, filename, saveFileDialog1.FileName, "");
                   saveFileDialog1.OpenFile();

                }else if (newFile.IsModified[tabControl2.SelectedIndex] == false)
                {


                }



            }catch(PathTooLongException)
            {


            }
            */
        }

        // Each time user changes the text field.
        private void textArea0_TextChanged(object sender, EventArgs e)
        {
            newFile.IsModified[tabControl2.SelectedIndex] = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //Show File dialog.
                openFileDialog1.ShowDialog(); // Display openFileDialog
                //Set variables for creation of existing file.
                newFile.openExisting(tabControl2.TabPages.Count, openFileDialog1.FileName);


                // //Create new instance of a rich textbox.
                RichTextBox newTextBox = new RichTextBox();
                // Fill the tab with the textbox
                newTextBox.Dock = DockStyle.Fill;
                //Set the name of text boxdymaically
                newTextBox.Name = newFile.FileName[tabControl2.TabCount + 1];

                //Create new tab.
                newTab.CreateNew(tabControl2.TabPages.Count);
                tabControl2.TabPages.Add(newFile.TabName[tabControl2.SelectedIndex]); //Add new tab with the file name already set.
                this.tabControl2.TabPages[newTab.CurrentTabs].Controls.Add(newTextBox); //create textbox in new tab

                //newFile.FileName[tabControl2.TabPages.Count + 1] = openFileDialog1.FileName;
                //newTab.Text[tabControl2.TabPages.Count + 1] = newFile.FileName[tabControl2.TabPages.Count + 1]; //Show filename in tab.

                StreamReader sr = new StreamReader(newFile.FileName[tabControl2.TabPages.Count]);
                String line = sr.ReadToEnd();
                newTextBox.Text = line;
                line = ""; //clear line from memory.


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




        private void createNewTab()
        {
            //Create new instance of a rich textbox.
            RichTextBox newTextBox = new RichTextBox();
            newTextBox.Dock = DockStyle.Fill;
            newTextBox.Name = newFile.FileName[tabControl2.TabCount + 1];

            //Create new tab.
            newTab.CreateNew(tabControl2.TabPages.Count);
            tabControl2.TabPages.Add(newFile.TabName[tabControl2.SelectedIndex]); //Add new tab with the file name already set.
            this.tabControl2.TabPages[newTab.CurrentTabs].Controls.Add(newTextBox); //create textbox in new tab
            
            
            
            //http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically
        }





    }






}