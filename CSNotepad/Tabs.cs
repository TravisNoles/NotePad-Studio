using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    //Tab management class.
    class Tab
    {
        //TabStor -- Tab Properties
            //List: 
            // 1) Tab Name
            // 2) Tab Text


        private Dictionary<int, List<string>> TabStor = new Dictionary<int, List<string>>();
        private int _tabsOpen;

        //Get/Set tabs that are open (locally)
        private int tabsOpen
        {
            get
            {
                return _tabsOpen;
            }
            
            set
            {
                _tabsOpen = value;
            }
            

        }

        public string getNewTabName(int tab)
        {
            return TabStor[tab][0];
        }

        //Generate new tab number (for naming of new tabs)
        public string getNewTabNumberAsString()
        {
            string tabsOpen = _tabsOpen.ToString();
            return tabsOpen + 1;
        }

        //Set New Tab Number
        public void setNewTabNumber(int selectedTab)
        {
            int newtab = getNewTabNumberAsInt();
            TabStor[newtab].Insert(0, getNewTabNumberAsString());
        }

        //Generate new tab number
        public int getNewTabNumberAsInt()
        {
            return _tabsOpen + 1;
        }

    }
}
