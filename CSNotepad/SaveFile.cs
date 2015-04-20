using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSNotepad
{
    class SaveFile
    {
           string _Name;
           string _Text;
        
        
        public string Name
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

        public bool SaveFile()
        {
            bool saveFileResult = false; //default value
        
            StreamWriter newfilewriter = new StreamWriter(_Name);
            
            
            if (_Name != "")
            {
                newfilewriter.WriteLine(_Text);
                newfilewriter.Close();
            }






            return saveFileResult;

        }

            




    }
}
