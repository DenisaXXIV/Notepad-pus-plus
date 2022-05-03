using Notepad_Plus_Plus.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Plus_Plus.Models
{
    internal class File : ObservableObject
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged(nameof(Text)); }
        }

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; OnPropertyChanged(nameof(FilePath)); }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; OnPropertyChanged(nameof(FileName)); }
        }

        public bool IsEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
