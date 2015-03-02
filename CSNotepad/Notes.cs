using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    public class Note<N>
    {

        // Generic class Note and name of note.
        public Note(N note, string fileName, string noteModified)
        {
            
  

        }


        void NewNote()
        {
            // values are for debugging for now. need to set date and file name. (prompt user.)
            var SaveNoteProc = new Note<int>(0, "default0.txt", "0");


        }


        void SaveNote()
        {
            var SaveNoteProc = new Note<int>(0, "default0.txt", "1");
        }


    }






}
