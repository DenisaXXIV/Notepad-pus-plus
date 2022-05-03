using Notepad_Plus_Plus.Commands;
using Notepad_Plus_Plus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad_Plus_Plus.ViewModels
{
    internal class EditorViewModel
    {
        //public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; }
        public File MyFile { get; }

        public EditorViewModel(File myFile)
        {
            MyFile = myFile;
            Format = new FormatModel();
            //FormatCommand = new RelayCommand
            WrapCommand = new RelayCommand(p => ToggleWrap());
        }

        public void ToggleWrap()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}
