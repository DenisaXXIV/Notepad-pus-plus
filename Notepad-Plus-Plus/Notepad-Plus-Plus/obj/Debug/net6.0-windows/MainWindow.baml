   M S B A M L   `   `   `  ����L  HNotepad-Plus-Plus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Notepad_Plus_Plus.ViewModelsNotepad_Plus_Plus.ViewModels  5   	   "    Notepad_Plus_Plus.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Notepad_Plus_Plus.ViewModels     5   	     � Title$  Notepad++ (Clone)��5   	   $	��720��6#   $
��1280��60    � DataContext 5	      0  *Notepad_Plus_Plus.ViewModels.MainViewModel  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��140 �6   �� 5      $��* �6   .+�5   
   o� -   5         o�Name$
 Menu��5      $��0��5      $��2��6   .@�5      m� $
��File��6    6%   �� *FileViewModel+.@�5      m� $��New file��6    m� Command 6-   �� *
NewCommand+m� 5      $��	Open file��6    6.   �� *OpenCommand+�� 5      m� 5      $
��Save��6    6)   �� *SaveCommand+m� 5      $��	Save file��6    6.   �� *SaveAsCommand+m� 5      $��Save all files��6   �� 5      m� 5       $��
Close file��6   m� 5!      $
��Exit��6    6)   �� *ExitCommand+5"      m� 5#      $
��Edit��6   .@�5$      m� $	��Cut��6   m� 5%      $
��Copy��6   m� 5&      $��Paste��6   m� 5'      $��Delete��6   m� 5(      $��
Select All��6   �� 5)      m� 5*      $��Convert to Uppercase��6   m� 5+      $��Convert to Lowercase��6   �� 5,      5.      m� 5/      $��Search��6   .@�50      m� $
��Find��6   �� 51      m� 52      $��Replace��6   m� 53      $��
Go To Line��6   54      m� 55      $��About��6    6&   �� *FileViewModel+.@�56      m� $��Student��6    6,   �� *HelpCommand+57      59      ]� 5;   
   $��1��6   $��1��6!   .+�5<      �� $��Bottom=�6    5=      �� *FileViewModel.MyFile+��5>      �� *
FilePath+�� 5@      $	��Top=�6   " �� VerticalScrollBarVisibility$ Visible=�5A       �� AcceptsReturn$
 True��5H       �� 
AcceptsTab$
 True��5I       5B      �� *EditorViewModel+��5C      �� *Format.Family+��5D      �� *Format.Size+��5E      �� *Format.Style+��5F      �� *Format.Weight+	 �� TextWrapping	 5G      �� *Format.Wrap+��5J      �� *MyFile.Text+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5K      ]� 5M   
   $��1��6   $��0��6!   .+�5N      R� -   5        $��treeView��5N      
������ $��1q�5O      $��0 0 1 0q�5P      ��5N   '   �� *	TreeItems+ � 	Resources 5Q       �� 
TargetType �� Property �� Value��%�   'Q�       �� 5R      " Q�6   .�5S      ��  �@Q�
IsExpanded 67   �� *TreeViewItem_Expanded+$
 TwoWay=�5T      5U      5X      5Y      5\      5_      