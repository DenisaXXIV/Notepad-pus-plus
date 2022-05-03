using Notepad_Plus_Plus.Models;
using Notepad_Plus_Plus.Property;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Notepad_Plus_Plus.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private Notepad_Plus_Plus.Models.File _file;
        public EditorViewModel EditorViewModel { get; set; }
        public FileViewModel FileViewModel { get; set; }
        private ObservableCollection<TreeViewItem> treeItems = new ObservableCollection<TreeViewItem>();

        public ObservableCollection<TreeViewItem> TreeItems
        {
            get { return treeItems; }
            set { treeItems = value; OnPropertyChanged(nameof(TreeItems)); }
        }

        public MainViewModel()
        {
            _file = new Notepad_Plus_Plus.Models.File();
            EditorViewModel = new EditorViewModel(_file);
            FileViewModel = new FileViewModel(_file);
            InitializeDrives();
        }

        private void InitializeDrives()
        {
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            foreach (var drive in drives)
            {
                TreeItems.Add(CreateTreeItem(drive));
            }
        }

        private TreeViewItem CreateTreeItem(object o)
        {
            TreeViewItem treeItem = new TreeViewItem();
            if (o is FileInfo)
            {
                treeItem.Header = o.ToString();
                treeItem.Tag = 0;
            }
            else
            {
                treeItem.Header = o.ToString();
                treeItem.Tag = 0;
                treeItem.Items.Add("Loading...");
            }
            return treeItem;
        }

        public void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            var item = e.Source as TreeViewItem;
            if ((item.Items.Count == 1) && (item.Items[0] is string) && !(item.Tag is FileInfo))
            {
                item.Items.Clear();
                DirectoryInfo expanded = null;

                if (item.Tag is DriveInfo)
                {
                    expanded = (item.Tag as DriveInfo).RootDirectory;
                }

                if (item.Tag is DirectoryInfo)
                {
                    expanded = (item.Tag as DirectoryInfo);

                }

                try
                {
                    foreach (var subdir in expanded.GetDirectories())
                    {
                        item.Items.Add(CreateTreeItem(subdir));
                    }
                    foreach (var file in expanded.GetFiles())
                    {
                        item.Items.Add(CreateTreeItem(file));
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
    }
}
