using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
   public class Note
    {
       private string[,] _TextFile;

       public string[,] TextFile
       { 
           get
           {
               return _TextFile;
           }
            
           set
           {
               _TextFile = value;
           }
       }


       







       // [Note Loaded (tab)] [tabIndex, fileName, fileContent, ifFileModifed]

       /*
       public static string[,] NewNote(string tabIndex, string fileName)
       {
           
           Note._TextFile[0,0] = fileName;
           Note._TextFile[0, 1] = "test test"; // 0,1 Stores file content, blank because of new file.
           Note._TextFile[0, 2] = "false"; // if file modified (default false)
           return _TextFile;
       }

       public static string[,] OpenNote(int tabIndex, string fileName, string fileContent)
       {
           _TextFile[0, 0] = fileName;
           _TextFile[0, 1] = fileContent;
           _TextFile[0, 2] = "false";


           return _OpenNote;
       }

       public static string[,] SaveNote(int tabIndex, string fileName, string fileContent, bool isModified)
       {
           _SaveNote[0, 0] = fileName;
           _SaveNote[0, 1] = fileContent; // 0,1 Stores file content.
           _SaveNote[0, 2] = "false"; // if file modified (default false)

           return _SaveNote;
       }





       /*
       private string _fileName;
       private string _fileContent;
       private bool _fileModified;
       private string[] _newNote;
       
       public string fileName
       {
           get
           {
               return _fileName;
           }

           set
           {
               _fileName = value;
           }
       }

       public string fileContent
       {
           get
           {
               return _fileContent;
           }

           set
           {
               _fileContent = value;
           }
       }

       public bool fileModified
       {
           get
           {
               return _fileModified;
           }

           set
           {
               _fileModified = value;
           }

       }
        
       public string[] newNote
       {
           get
           {
               return _newNote;
           }

           set
           {
               _newNote = value;

           }


       }
 


       //https://msdn.microsoft.com/en-us/library/aa288471(v=vs.71).aspx

        public string NewNote(string filename)
        {
            Note note0 = new Note();
            string[] newNoteLocal;

            note0.fileName = filename;
            note0.fileContent = "";
            note0.fileModified = false;
            note0.newNote[0] = note0.fileName;
            note0.newNote[1] = note0.fileContent;
            string modtostring = note0.fileModified.ToString();
            note0.newNote[2] = modtostring;



            switch (fileAcessType)
            {
                // Create a new file.
                case "new":
 

                    //return note0.newNote[0];

                case "open":
                    note0.fileName = "Default.text";
                    note0.fileContent = "";
                    note0.fileModified = false;

                    note0.newNote[0] = note0.fileName;
                    note0.newNote[1] = note0.fileContent;
                    modtostring = note0.fileModified.ToString();
                    note0.newNote[2] = modtostring;

                case "save":
                    note0.fileName = filename;


                default:
                    return "test, returned default";

            }


        }

        public string OpenNote(string filename, string filecontent)
        {
            string[] openNoteLocal;




            return openNoteLocal[1];
        }


        public string SaveNote(string filename, string filecontent)
        {
            string[] saveNoteLocal;




            return saveNoteLocal;
        }


        public bool[] NoteModified(bool modified)
        {
            Note note0 = new Note();
            note0 = modified;


            return mod
        }

       */

    }
            
}
