using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNotepad
{
    //Tab management class.
    class Tab
    {

        private Dictionary<int, string> _Name = new Dictionary<int, string>();
        private Dictionary<int, string> _Text = new Dictionary<int, string>();
        private Dictionary<int, bool> _Modified = new Dictionary<int, bool>();
        private int _numberOfTabs;

        //private List<string> _Name = new List<string>();
        //private List<string> _Text = new List<string>();
        //private List<bool> _Modified = new List<bool>();

        public void setNumOfTab(int tabs)
        {
            _numberOfTabs = tabs;
        }

        public int getNumOfTabs()
        {
            return _numberOfTabs;
        }

        public string getNewText(int tab)
        {
            tab = tab + 1;
            return _Text[tab];
        }

        public string getText(int tab)
        {
            return _Text[tab];
        }

        public bool getModified(int tab)
        {
            return _Modified[tab];
        }


        public void GenerateNew()
        {
            int _NewTabNumber = _numberOfTabs + 1;
            _Name[_NewTabNumber] = "tabPage" + _NewTabNumber.ToString();
            _Text[_NewTabNumber] = "New Tab " + _NewTabNumber.ToString();
        }


    }






}
