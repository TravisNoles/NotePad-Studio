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
        public string CreateNewDefaultFile()
        {
            DataStorage AccessData = new DataStorage();

            DataStorage.Name.Add(System.IO.Path.GetRandomFileName());
            DataStorage.Text.Add("");

            // Generate blank file.
            for (int index = 0; index < 0; index++)
            {
                DataStorage.Text.Add("");
            }


            

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