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
                    newFile.createNew(tabControl2.TabCount); //setup tab
                    newTab.CreateNew(tabControl2.TabCount);
                    //createNewTab(); // Create New tab GUI
        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (newFile.IsModified[tabControl2.SelectedIndex] == true)
                {
                   saveFileDialog1.ShowDialog();
                   string filename = "";
                   Path.GetFileName(filename);
                   newFile.saveLoaded(tabControl2.SelectedIndex, filename, saveFileDialog1.FileName, "");
                   saveFileDialog1.OpenFile();

                }else if (newFile.IsModified[tabControl2.SelectedIndex] == false)
                {


                }



            }catch(PathTooLongException)
            {


            }

            try
            {
                if (newFile.IsModified[tabControl2.SelectedIndex] == true)
                {
                    //Setup save file dialog and show it:
                    

                    newFile.Name[tabControl2.SelectedIndex] = saveFileDialog1.FileName; //Get selected file name and set the filename to instance variable

                    }




                // //write all text in the text box to a text file.

            }catch (PathTooLongException)
            {
                DialogResult createNewFile = MessageBox.Show("ERROR: Path/file name is too long, please rename to a shorter file name.", "Error", MessageBoxButtons.OK);
            }

        }

        // Each time user changes the text field.
        private void textArea0_TextChanged(object sender, EventArgs e)
        {
            newFile.IsModified[tabControl2.SelectedIndex] = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                newTab.CreateNew(tabControl2.TabPages.Count); // Set tab variables.


                openFileDialog1.ShowDialog(); //Open file dialog
                newFile.Name[tabControl2.SelectedIndex] = openFileDialog1.FileName;
                newTab.Text[tabControl2.SelectedIndex] = newFile.Name[tabControl2.SelectedIndex]; //Show filename in tab.

                createNewTab();

                



                StreamReader sr = new StreamReader(newFile.Name[tabControl2.SelectedIndex]);
                String line = sr.ReadToEnd();
                textArea0.Text = line;
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
            newTextBox.Name = newFile.Name[tabControl2.TabCount + 1];
            newTextBox.Text = "";


            //Create new tab.
            newTab.CreateNew(tabControl2.TabPages.Count);
            tabControl2.TabPages.Add(newTab.Text[tabControl2.SelectedIndex]); //Add new tab with the file name already set.
            this.tabControl2.TabPages[newTab.CurrentTabs].Controls.Add(newTextBox); //create textbox in new tab
            
            
            
            //http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {

        }





    }






}