using Microsoft.Win32;
using Notepad_Plus_Plus.Commands;
using Notepad_Plus_Plus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Notepad_Plus_Plus.ViewModels
{
    internal class FileViewModel
    {
        private File m_myFile;

        public void HelpMessage()
        {
            MessageBox.Show("Vasile Denisa-Georgiana\ngrupa 10LF203\nInformatica");
            return;
        }

        public File MyFile { get; private set; }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand HelpCommand { get; }
        public ICommand ExitCommand { get; }

        public FileViewModel(File file)
        {
            MyFile = file;
            NewCommand = new RelayCommand(param => NewFile());
            SaveCommand = new RelayCommand(param => SaveFile(), pred => !MyFile.IsEmpty);
            SaveAsCommand = new RelayCommand(param => SaveFileAs());
            OpenCommand = new RelayCommand(param => OpenFile());
            HelpCommand = new RelayCommand(param => HelpMessage());
            ExitCommand = new RelayCommand(param => Exit());
        }

        public void Exit()
        {
            if (!String.IsNullOrEmpty(MyFile.Text))
            {
                var dialog = MessageBox.Show("Save before quit?", "Warning", MessageBoxButton.YesNo);
                if (dialog == MessageBoxResult.Yes)
                {
                    SaveFileAs();
                    Application.Current.Shutdown();
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
            Application.Current.Shutdown();
        }

        public void NewFile()
        {
            MyFile.FileName = String.Empty;
            MyFile.FilePath = String.Empty;
            MyFile.Text = String.Empty;
        }

        public void SaveFile()
        {
            System.IO.File.WriteAllText(MyFile.FilePath, MyFile.Text);
        }

        public void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                System.IO.File.WriteAllText(saveFileDialog.FileName, MyFile.Text);
            }
        }

        public void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                MyFile.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            MyFile.FilePath = dialog.FileName;
            MyFile.FileName = dialog.SafeFileName;
        }
    }
}
