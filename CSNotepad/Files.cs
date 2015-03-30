using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    public class File
    {
        // Purpose: Stores file information into memory.


        public string[] FileName = new string[50];
        public string[] FilePath = new string[50];
        public string[] FileText = new string[50];
        public string[] TabName = new string[50];
        public string[] TabText = new string[50];
        public bool[] IsModified = new bool[50];
        public int tabsOpen;


        //initialize variables
        void Intialize()
        {
            for (int x = 0; x < FileName.Length; x++)
            {
                FileName[x] = "";

            }

            for (int x = 0; x < FileText.Length; x++)
            {
                FileText[x] = "";

            }

            for (int x = 0; x < IsModified.Length; x++)
            {
                IsModified[x] = false;

            }




        }
       
     
        //Default new file setup
        public void CreateNew(int tabIndex)
        {
            tabIndex = tabsOpen + 1; //increase it by 1, to put the tab on the right of existing tab(s)
            
            // Set the file name
            FileName[tabIndex] = "newfile" + tabIndex.ToString() + ".txt";

            // Set the name of the tab.
            TabName[tabIndex] = "noteTab" + tabIndex.ToString();

            // Set the text of the tab
            TabText[tabIndex] = "New File" + tabIndex.ToString();
        }

        public void openExisting(int tabIndex, string filename)
        {
            tabIndex = tabIndex + 1;
            //Set filename
            FileName[tabIndex] = filename;
            TabName[tabIndex] = filename;


        }


        public void saveNew(int tabIndex, string LoadedName, string LoadedPath, string LoadedText)
        {
            FileName[tabIndex] = LoadedName;
            FilePath[tabIndex] = LoadedPath;
            FileText[tabIndex] = LoadedText;
            System.IO.File.WriteAllText(LoadedPath, LoadedText);
        }








        /*
        private string[] _fileName;
        private string[] _tabName;
        private string[] _fileContent;
        private bool[] _fileModified;
        private bool[] _wordWrap;
        private int[] _selectedTab;


        //get set index of varibles array (accessor, setter)
        //indexer declaration, throws exception out of bounds.
        public int this[int index]
        {
            get
            {
                return _selectedTab[index];
            }

            set
            {
                _selectedTab[index] = value;
            }


        }

        public string this[int index]
        {
            get
            {
                return _fileName[index];
            }

            set
            {
                _fileName[index] = value;
            }


        }






        public string fileName
        {
            get
            {
                return _fileName;
            }

            set
            {
                _fileName = value;
            }
        }

        public string tabName
        {
            get
            {
                return _tabName;
            }

            set
            {
                _tabName = value;
            }

        }

        public string fileContent
        {
            get
            {
                return _fileContent;
            }

            set
            {
                _fileContent = value;
            }
        }

        public bool fileModified
        {
            get
            {
                return _fileModified;
            }

            set
            {
                _fileModified = value;
            }

        }
        */



    }


    
    



}