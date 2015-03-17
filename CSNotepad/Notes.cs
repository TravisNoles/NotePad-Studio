using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    public class Note
    {
        private string _fileName;
        private string _fileContent;
        private bool _fileModified;

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



        //https://msdn.microsoft.com/en-us/library/aa288471(v=vs.71).aspx

    }




}