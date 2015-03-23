using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    public class File
    {
        public string[] Name = new string[50];
        public string[] Path = new string[50];
        public string[] Text = new string[50];
        public string[] TabName = new string[50];
        public bool[] IsModified = new bool[50];


        //initialize variables
        void Intialize()
        {
            for (int x = 0; x < Name.Length; x++)
            {
                Name[x] = "";

            }

            for (int x = 0; x < Text.Length; x++)
            {
                Text[x] = "";

            }

            for (int x = 0; x < IsModified.Length; x++)
            {
                IsModified[x] = false;

            }




        }
        

        public void createNew(int tabIndex)
        {
            tabIndex = tabIndex + 1; //increase it by 1, to put the tab on the right of existing tab(s)
            Name[tabIndex] = "New Text " + tabIndex.ToString();
        }


        void openExisting(int tabIndex, string ExistingName, string ExistingPath, string ExistingText)
        {
            Name[tabIndex] = ExistingName;
            Path[tabIndex] = ExistingPath;
            Text[tabIndex] = ExistingText;
        }


        public void saveLoaded(int tabIndex, string LoadedName, string LoadedPath, string LoadedText)
        {
            Name[tabIndex] = LoadedName;
            Path[tabIndex] = LoadedPath;
            Text[tabIndex] = LoadedText;

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