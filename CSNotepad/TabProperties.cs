using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    class TabProperties
    {
        private int _tabsOpenAsInt;
        private string _tabsOpenAsString;


        public int TabsOpenAsInt
        {
            get
            {
                return _tabsOpenAsInt - 1; //TabCount starts index at 1 instead of 0.
            }

            set
            {
                _tabsOpenAsInt = value; //Set the value
            }


        }

        public string tabsOpenAsString
        {
            get
            {
                return _tabsOpenAsString = _tabsOpenAsInt.ToString();
            }

        }



    }
}
