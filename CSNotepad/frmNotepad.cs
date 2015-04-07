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

//Changes:
// Wordwrap, copy and pasting, opening file, saving file.


namespace CSNotepad
{
    public partial class frmNotepad : Form
    {
        //Create new instance of file class.
        File filehandler = new File();
        Tab tabhandler = new Tab();

        //Tab Dictionary: tabIndex, TabData(TabName, TabText);
        Dictionary<int, List<string>> TabStor = new Dictionary<int, List<string>>();
        //File dictionary: index, FileData(FileName, FilePath, FileText, ismodified)
        Dictionary<int, List<string>> FileStor = new Dictionary<int, List<string>>();


        public frmNotepad()
        {
            InitializeComponent();
        }

        //Create New Document in a tab
        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Create a new tab
            string tabName = tabhandler.getNewTab();

            //Add Textbox
            int newtabnum = tabControl2.TabCount + 1;
            filehandler.createNew(newtabnum, "newfile.txt", "C:\newfile.txt", "", false);
            createNewTab(newtabnum, "notetab" + newtabnum.ToString(), "newtab"); // Create New tab GUI
        }

        // Save existing document
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get whether the current file in selected tab is modified.
                bool isSelectedTabModified = filehandler.getModified(tabControl2.SelectedIndex);
                string selectedFileName;

                if (isSelectedTabModified == true)
                {
                    //If the file is modified, show dialog for saving.
                    saveFileDialog1.ShowDialog();
                    //Get filename from savefiledialog and set it
                   selectedFileName = filehandler.getFileName(tabControl2.SelectedIndex);
                   saveFileDialog1.OpenFile();
                }
                else if (isSelectedTabModified == false)
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
            filehandler.setModified(tabControl2.SelectedIndex, true); // Change selected tab for file to modified.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //Show File dialog.
                openFileDialog1.ShowDialog();
               
                string filename = openFileDialog1.FileName;
                string tabname = newTab.getTabName(tabControl2.SelectedIndex);

                //Create new instance of a rich textbox.
                RichTextBox newTextBox = new RichTextBox();

                // Fill the tab with the textbox
                newTextBox.Dock = DockStyle.Fill;
            
                //Set the name of textbox dymaically
                newTextBox.Name = filehandler.getFileName(tabControl2.TabCount + 1);

                // Create new tab.
                filehandler.readFile(tabControl2.SelectedIndex, filename);
                tabControl2.TabPages.Add(tabname); //Add new tab with the file name already set.
                this.tabControl2.TabPages[tabControl2.TabPages.Count].Controls.Add(newTextBox); //create textbox in new tab
                


                //newFile.FileName[tabControl2.TabPages.Count + 1] = openFileDialog1.FileName;
                //newTab.Text[tabControl2.TabPages.Count + 1] = newFile.FileName[tabControl2.TabPages.Count + 1]; //Show filename in tab.


                // New Stream reader
                
                

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




        //Handles the creation of a new tab.
        private void createNewTab(int newtabnumber, string newtabname, string newtext)
        {
            //Create new textbox
            RichTextBox newTextBox = new RichTextBox();
            newTextBox.Text = newtext;


            //Create new tab.
            newTab.createTab(tabControl2.TabPages.Count + 1, "newtab", "");
            tabControl2.TabPages.Add(newtabname); //Add new tab with the file name already set.
            this.tabControl2.TabPages[newtabnumber].Controls.Add(newTextBox); //create textbox in new tab
            
            //http://www.codeproject.com/Questions/210229/How-to-add-a-dynamic-RichTextBox-to-a-dynamically
        }


        private void createNewTextbox(int newtextboxname, string newtabname, string newtabtext)
        {
            //Get number of loaded tabs and then increase it by one.
            //Set the fille property, to fill the tab

            RichTextBox newTextBox = new RichTextBox();
            newTextBox.Dock = DockStyle.Fill;
            newTextBox.Name = filehandler.getFileName(tabControl2.SelectedIndex + 1);
        }




    }






}