using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSNotepad
{
    //Handles file ops.
    public class File
    {
        string name;
        string text;
        bool modified;






        /*
        //<int tabnumber>: FileName, FilePath
        

        //List<string>: Stores properties:
            // 0: FileName
            // 1: FileText
            // 2: FilePath
            // 3: IsModified

        //Get FileName
        public string getFileName(int selectedTab)
        {
            return FileStor[selectedTab][0]; // 0 is filename.
        }

        //Set FleName
        public void setFileName(int selectedTab, string fileName)
        {
            FileStor[selectedTab].Insert(0, fileName);
        }
           
        //Get modification propetty of the file.
        public string getFilePropertyModified(int selectedTab)
        {
            return FileStor[selectedTab][3]; //3 is the file modified index of the list.
        }

        //Set modification property of the file.
        public void setFilePropertyModified(int selectedTab, bool value)
        {
            //FileStor[selectedTab].Insert(3, value.ToString());
        }

        //Read File
        public void readFile(string filename)
        {
            //Open StreamReader

        }

        //Write File
        public void writeFile(string filename)
        {
            //Open StreamWriter


        }



        



        //REMOVE BELOW AFTER OPTIMIZATION
        /*


        //TODO: Create a new file object dynamically
        public string[] createNew(int selectedTab, string filename, string filepath, string filetext)
        {
            string[] NewFile = new string[10]; //Creates a return newfile string array

            //Set Tab Text - Based on default filename && adds +1 tabs onto existing tabs.
            filename = "newfile" + newTabNumberAsString();

            //Add file information to dictionary.
            FileStor[selectedTab].Add(filename);
            FileStor[selectedTab].Add(filepath);
            FileStor[selectedTab].Add(filetext);

            // Create file in program dir.
            




            // Create NewFile DataObj


            return NewFile;
        }

        
        public void createNewdd(int tab, string filename, string fullpath, string txttext, bool modified)
        {
            // Set the file name
            FileName[tab] = "newfile" + tab.ToString() + ".txt";

            //Set the tab Name



            // Set the name of the tab.
            FileName[tab] = "noteTab" + tab.ToString();

            // Set the text of the tab
            Text[tab] = "New File" + tab.ToString();

            // Not modified by default.
            IsModified[tab] = modified;
        }

        public void openExisting(int tab, string filename)
        {
            //Set filename for current tab
            FileName[tab] = filename;

            StreamReader openTextFile = new StreamReader(filename);
            String line = openTextFile.ReadToEnd();
            Text[tab] = line;

        }

        public void saveExisting(int tabIndex, string LoadedName, string LoadedPath, string LoadedText)
        {
            FileName[tabIndex] = LoadedName;
            Path[tabIndex] = LoadedPath;
            Text[tabIndex] = LoadedText;
            System.IO.File.WriteAllText(LoadedPath, LoadedText);
        }

        //TODO: Set file name
        public void setFileName(int tab, string filename)
        {
            FileName[tab] = filename;
        }

        public string getFileName(int tab)
        {
            return FileName[tab];
        }

        public void setModified(int tab, bool value)
        {

        }

        public bool getModified(int tab)
        {
            return IsModified[tab];
        }

        //TODO: Read file.
        public string readFile(int tab, string filename)
        {
            return Text[tab];
        }

         */
    }


    
    



}