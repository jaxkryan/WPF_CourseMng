   M S B A M L   `   `   `  ����B  >Finally, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FinallyFinally  5   	       Finally.JoinSubject   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Finally     5   	     � Title$  JoinSubject��5   	   $	��450��6   $	��800��6*   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6"   .+�5      �� $��Join Subject��6   $��40(�6+   $
��Bold"�69   
���<��6K   5      �� 5   
   $��SubjectCode��6   $��Center=�6'   $��5q�6B   $��1��6M   �� 5   
   -   5         ��Name$ SubjectComboBox��5      $��1��6,   $��1��6<   $��5q�6I   $��25��6T   5       �� 5#   
   $��Class��6   $��Center=�6!   $��5q�6<   $��2��6G   �� 5$   
   -   5        $ ClassComboBox��5$      $��1��6*   $��2��6:   $��5q�6G   $��25��6R   5&      �� 5)   
   $��TranningTime��6   $��Center=�6(   $��5q�6C   $��3��6N   (  "System.Windows.Controls.DatePicker  5*   
   -   5          Name$ dpkTimeLearn��5*      $	��200��6+   $��Center=�67   $��5q�6R   ���#E1F5FE���#81D4FA$��1q�5+   4   $��1��6H   $��3��6X   �� 5.   
   $��2��6   $��4��6)    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��5q�6l   .+�5/      �� -   5        $
��Save��5/      $��75��6$   $��5q�6/   
������6R   �� 50      -   5        $��Cancel��50      $��75��6&   $��5q�61   
�������6T   51      52      53      