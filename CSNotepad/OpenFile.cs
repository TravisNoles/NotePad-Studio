using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSNotepad
{
    class OpenFile
    {
        string _Name;
        string _Text;


        private string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }

        }

        private string Text
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

        public void OpenFile(string filename)
        {
            NewTab newtabhandler = new NewTab();
            StreamReader fileopen = new StreamReader(_Name);



        }



        public void CloseFile()
        {
            




        }








    }
}
