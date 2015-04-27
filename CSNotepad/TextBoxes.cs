using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{

    //Combines tabs and files 
    class TextBoxesH
    {
        private Dictionary<int, string> _Name = new Dictionary<int, string>();
        private Dictionary<int, string> _Text = new Dictionary<int, string>();
        private Dictionary<int, bool> _Modified = new Dictionary<int, bool>();
        private Dictionary<int, bool> _WordWrap = new Dictionary<int, bool>();
        private int _numberOfTabs;


        public void GenerateTextBox()
        {
            //_numberOfTabs = _numberOfTabs;
            _Name.Add(_numberOfTabs, "textArea" + _numberOfTabs.ToString());
            _Text.Add(_numberOfTabs, "");
            _WordWrap.Add(_numberOfTabs, false);
        }

        public string getNewName()
        {
            return _Name[_numberOfTabs];

        }

        public string getNewText()
        {
            return _Name[_numberOfTabs];
        }

        public void setNumOfTabs(int tabs)
        {
            _numberOfTabs = tabs;
        }

        public string getName(int tab)
        {
            return _Name[tab];
        }

        public string getText(int tab)
        {
            return _Text[tab];
        }



    }
}
