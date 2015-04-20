using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNotepad
{
    //Tab management class.
    class NewTab
    {
        private int _TabsOpen;
        private int _TabSelected;
        private string _Name;
        private string _Text;

        public int TabsOpen
        {
            get
            {
                return _TabsOpen;
            }


            set
            {
                _TabsOpen = value;
            }

        }


        public int TabSelected
        {
            get
            {
                return _TabSelected;
            }

            set
            {
                _TabSelected = value;
            }
        }

        public string setDefaultName()
        {
            string newtabname = "tab" + _TabsOpen.ToString();




            return newtabname;
        }

        public string setDefaultText()
        {
            string newtabname = "New Tab" + _TabsOpen.ToString();



            return newtabname;
        }

    }
}
