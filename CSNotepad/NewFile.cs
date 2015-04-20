using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSNotepad
{
    //Handles file ops, generic class of type new
    public class NewFile
    {
        private string _Name;
        private string _Text;


        public string CreateNewDefaultFile()
        {
            _Name = DefaultName = System.IO.Path.GetRandomFileName();





            return _Name;
        }

        
        public string DefaultName
        {
            get
            {
                return _Name;
            }

            set
            {
                DefaultName = value;
            }


        }







    }

    



}