using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNotepad
{
    class Tab
    {
        public string[] Name = new string[50];
        public string[] Text = new string[50];
        public int CurrentTabs;


        public void CreateNew(int currentTabs)
        {
            CurrentTabs = currentTabs;
            int tabIndex = currentTabs + 1;
            Name[tabIndex] = "noteTab" + tabIndex.ToString();
            Text[tabIndex] = "New Note" + tabIndex.ToString();

        }



        public void CreateNewTabExistingFile(int tabIndex, int currentTabs)
        {
            Name[tabIndex] = "noteTab" + tabIndex.ToString();
            Text[tabIndex] = "New Note" + tabIndex.ToString();

        }



    }
}
