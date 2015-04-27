using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{

    //Combines tabs and files 
    class NewTextBox
    {
        string _Name;
        string _Text;
        bool _WordWrap;

        //Create default text box.
        public string Name
        {
            get
            {
                NewTab newtabprops = new NewTab();
                
                _Name = "newTextArea" + newtabprops.TabsOpen;
                _Text = "";
                _WordWrap = true;





                return _Name;
            }


            set
            {


            }


            

            _Name = "textArea" + 





            return _Name;
        }

        public string Text
        {
            get
            {
                return _Text;
            }


            set
            {
                _Text = value;
            }

        }

        public bool WordWrap
        {
            get
            {
                return _WordWrap;
            }


            set
            {
                _WordWrap = value;
            }
            

        }






    }
}
