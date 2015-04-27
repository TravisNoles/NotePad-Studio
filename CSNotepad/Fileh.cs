using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSNotepad
{
    //Handles file ops, generic class of type new
    public class FileH
    {
        private Dictionary<int, string> _Name = new Dictionary<int, string>();
        private Dictionary<int, string> _Text = new Dictionary<int, string>();
        private Dictionary<int, bool> _Modified = new Dictionary<int, bool>();
        private int _numberOfOpenTabs;


        //Create new default file
        public void GenerateNew()
        {
            //Generate Data
            //Add to file DB (mem)
            //Return new file object.
            _numberOfOpenTabs = _numberOfOpenTabs + 1;
            _Name.Add(_numberOfOpenTabs, System.IO.Path.GetRandomFileName());
            _Text.Add(_numberOfOpenTabs, "");
            _Modified.Add(_numberOfOpenTabs, false);

        }

        public void OpenExisting(int tab, string filename)
        {
            StreamReader sr = new StreamReader(filename);
            _Text.Add(tab, "");
            _Text[tab] = sr.ReadLine();


        }

        public void Save(int tab, string filename, string text)
        {

            if (filename != "")
            {
                StreamWriter newtextfile = new StreamWriter(filename);
                //Save file to user specified folder.
                newtextfile.WriteLine(text);
                newtextfile.Close();
            }





        }

        public string getNewName()
        {
            return _Name[_numberOfOpenTabs];
        }

        public string getNewText()
        {
            return _Text[_numberOfOpenTabs];
        }

        public string getExistingText(int tab)
        {
            return _Text[tab];
        }

        public bool getModifed(int tab)
        {
            return _Modified[tab];
        }

        public void setNumOfTabs(int tabs)
        {
            _numberOfOpenTabs = tabs;
        }





    }

    



}