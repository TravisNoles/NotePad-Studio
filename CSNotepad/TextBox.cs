using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNotepad
{

    //Combines tabs and files 
    class TextBox
    {
        private string _name;
        private string _text;
        private bool _multiline;
        private bool _wordwrap;
        

        public string name
        {
            get
            {
                return _name;
            }


            set
            {


            }
            

        }
        

        public string text
        {
            get
            {
                return _text;
            }


            set
            {

            }

        }


        public bool multiline
        {
            get
            {
                return _multiline;
            }


            set
            {
                _multiline = value;
            }


        }


        public bool wordwrap
        {
            get
            {
                return _wordwrap;
            }


            set
            {

            }

        }






    }
}
