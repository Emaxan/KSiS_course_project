   M S B A M L   `   `   `  ����O  KFreeMax File Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Jclr-namespace:FreeMax_File_Manager.Properties.UserSettings.Text.MainWindow<FreeMax_File_Manager.Properties.UserSettings.Text.MainWindow  5   	   ;"clr-namespace:FreeMax_File_ManagerFreeMax_File_Manager  5   	   Q-clr-namespace:FreeMax_File_Manager.PropertiesFreeMax_File_Manager.Properties  5   	   E AFolderView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FolderView;assembly=FolderView
FolderView 5	   	   -    'FreeMax_File_Manager.Windows.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   XpJclr-namespace:FreeMax_File_Manager.Properties.UserSettings.Text.MainWindow     5   	   AfreeMaxFileManager"clr-namespace:FreeMax_File_Manager     5   	   D
properties-clr-namespace:FreeMax_File_Manager.Properties     5   	   C
folderView,clr-namespace:FolderView;assembly=FolderView     5	   	   -   5          �Name$  WMain��5
   	    � Title$ FreeMax File Manager��5   	   $	��768��5   	   $
��1366��5   	    � WindowState$ 	Maximized=�5   	    � Icon$% /Properties/Resources/Icon1.ico��5   	      
MainWindow#���   5   	    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5   
      
KernelType$ Gaussian=�6      Radius$ 0Q�6+   .��5      � $��3,0,-3,0q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5       $
��Auto �6   .+�5"      �� $��0��6     MainWindowTitleStyle#���  6�   ��6   �� .  (FreeMax_File_Manager.Properties.Settings   Default	 �� Source#	 Z 
 �� Path$
 
wMainTitle� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   � 5#   
   $��1��6   $��Stretch=�6   $��Stretch=�6:    � ColumnDefinitions 5$      �� 5%      �� 5&      .+�5(      � $��0��6   $��Stretch=�6#   $��Stretch=�6A   $��	10,0,10,0q�6o    5)      �� 5*      �� 5+      �� 5,      �� 5-      �� 5.      .+�50      �� $��0��6     TopPanelPasiveStyle#���  6,   ��6Z   �� J  DFreeMax_File_Manager.Properties.UserSettings.Text.MainWindow.TopText   Default#	 Z $
 Text1�$ OneWay=�$ PropertyChanged=��� 51      $��1��6   #���  6,   ��6Z   �� #	 Z $
 Text2�$ OneWay=�$ PropertyChanged=��� 52      $��2��6   #���  6,   ��6Z   �� #	 Z $
 Text3�$ OneWay=�$ PropertyChanged=��� 53      $��3��6   #���  6,   ��6Z   �� #	 Z $
 Text4�$ OneWay=�$ PropertyChanged=��� 54      $��4��6   #���  6,   ��6Z   �� #	 Z $
 Text5�$ OneWay=�$ PropertyChanged=�55      � 56      $��1��6   $��Stretch=�6#   $��Stretch=�6A   $��	10,0,10,0q�6o    57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      .+�5>      �� $��0��6   #���  6,   ��6Z   �� #	 Z $
 Text6�$ OneWay=�$ PropertyChanged=��� 5?      $��1��6   #���  6,   ��6Z   �� #	 Z $
 Text7�$ OneWay=�$ PropertyChanged=��� 5@      $��2��6   #���  6,   ��6Z   �� #	 Z $
 Text8�$ OneWay=�$ PropertyChanged=��� 5A      $��3��6   #���  6,   ��6Z   �� #	 Z $
 Text9�$ OneWay=�$ PropertyChanged=��� 5B      $��4��6   #���  6,   ��6Z   �� #	 Z $
 Text0�$ OneWay=�$ PropertyChanged=�5C      5D      � 5E   
   $��2��6   $��Stretch=�6   $��Stretch=�6:    5F      �� 5G      �� 5H      .+�5J        FolderView.MyFolderView  -   5          Name$ LbLeftPanel��5J        FocusVisualInvis � FocusVisualStyle# [ 5N        MyListBoxItemStyle#��[ 5O        MiddleLeftPanelStyle#���  5P        MiddlePanelTemplate#���  5Q      $��10q�5R      |�.  $��10q�6#   $��0��60   $��Stretch=�6@   $��Stretch=�6^    �� SelectionMode$ Extended=�6z      CurAttributes 5K      �� #	 Z $
 LeftAttributes�$ OneWay=�$ PropertyChanged=�   CurNegativeAttributes 5L      �� #	 Z $
 NegLeftAttributes�$ OneWay=�$ PropertyChanged=�   Path 5M      �� #	 Z $
 CurLeftFolder�$ OneWay=�$ PropertyChanged=�5V        5W      -   5        $ LbRightPanel��5W   &   # [ 5[      #��[ 5\        MiddleRigthPanelStyle#���  5]      #���  5^      $��10q�5_      |�.  $��10q�6#   $��1��60   $��Stretch=�6@   $��Stretch=�6^   $ Extended=�6z    5X      �� #	 Z $
 RightAttributes�$ OneWay=�$ PropertyChanged=� 5Y      �� #	 Z $
 NegRigthAttributes�$ OneWay=�$ PropertyChanged=� 5Z      �� #	 Z $
 CurRightFolder�$ OneWay=�$ PropertyChanged=�5c      5d      � 5e   
   $��3��6   $��Stretch=�6   $��Stretch=�6:    5f      �� 5g      $
��Auto �6#   �� 5h      $
��Auto �6#   �� 5i      $
��Auto �6#   �� 5j      $
��Auto �6#   �� 5k      $
��Auto �6#   �� 5l      $
��Auto �6#   �� 5m      $
��Auto �6#   �� 5n      $
��Auto �6#   �� 5o      $
��Auto �6#   �� 5p      $
��Auto �6#   .+�5r      �� $��0��6     BottomPanelStyle#���  6   ��6J   �� M  GFreeMax_File_Manager.Properties.UserSettings.Text.MainWindow.BottomText   Default#	 Z $
 Text1�$ OneWay=�$ PropertyChanged=��� 5s      $��1��6   #���  6   ��6J   �� #	 Z $
 Text2�$ OneWay=�$ PropertyChanged=��� 5t      $��2��6   #���  6(   ��6S   �� #	 Z $
 Text3�$ OneWay=�$ PropertyChanged=��� 5u      $��3��6   #���  6(   ��6S   �� #	 Z $
 Text4�$ OneWay=�$ PropertyChanged=��� 5v      $��4��6   #���  6(   ��6S   �� #	 Z $
 Text5�$ OneWay=�$ PropertyChanged=��� 5w      $��5��6   #���  6(   ��6S   �� #	 Z $
 Text6�$ OneWay=�$ PropertyChanged=��� 5x      $��6��6   #���  6(   ��6S   �� #	 Z $
 Text7�$ OneWay=�$ PropertyChanged=��� 5y      $��7��6   #���  6(   ��6S   �� #	 Z $
 Text8�$ OneWay=�$ PropertyChanged=��� 5z      $��8��6   #���  6(   ��6S   �� #	 Z $
 Text9�$ OneWay=�$ PropertyChanged=��� 5{      $��9��6   #���  6(   ��6S   �� #	 Z $
 Text0�$ OneWay=�$ PropertyChanged=�5|      5}      5~      