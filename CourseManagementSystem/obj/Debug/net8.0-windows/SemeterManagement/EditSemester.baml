   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:CourseManagementSystem.SemeterManagement(CourseManagementSystem.SemeterManagement  5   	   ;    5CourseManagementSystem.SemeterManagement.EditSemester   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:CourseManagementSystem.SemeterManagement     5   	   -   5          � Title$  EditSemester��5	   	   $	��450��6   $	��700��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�6\    � 	Resources 5         PrimaryColor �� Color  ButtonHoverColor �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker �� Triggers	 P� Property
 P� Value��%i  &	        &	 #     '�� F     7   '      7   '�� �    7   '�� �    7   7  �� 5   
   $ 	#FF9C5400��6/   �� 5   
   $ 	#FFD37C00��63   �� 5   
   " ��6   .�5      ��  � ��$ 12(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   �� 5       � ��8   6,   �� 5       � ��$ 1q�60   5      �� 5   
   "  6   .�5      ��  � ��$ 12(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   �� 5       � ��8   6,   �� 5        � ��$ 1q�60   5!      �� 5$   
   " ��6   .�5%      ��  � ��$ 12(�6)   �� 5&       � ��$ 0,0,0,5q�6'   �� 5'       � ��8   6+   5(      �� 5+   
   " ��6   .�5,      ��  � ��$ 12(�6)   �� 5-       � ��$
 10,5q�6(   �� 5.       � ��$ 5q�6'   �� 5/       � ��8   6+   �� 50       � ��
 �����6+   �� 51       � ��$ 0q�60   �� 52       �@�Cursor$
 Hand��6'    53      P� 54      	 �@J�IsMouseOver$

 True��61   . �55      ��  � ��8  63   56      58      59      .��5;      �  � RowDefinitions 5<   
   �� 5=      $��50 �6   �� 5>      �� 5?      $��40.04 �6   .+�5A   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6K   $��50��6f   $	��278��6r   .+�5B      �� $��Edit Semester��6   $��30(�6,   $
��Bold"�6:   5C      �� 5D   
   $ Vertical=�6   $��30,20,30,20q�6,   $��1��6A   .+�5E      �  � ColumnDefinitions 5F      �� 5G      $
��Auto �6'   �� 5H      $��* �6'    5J      �� 5K      $
��Auto �6$   �� 5L      $
��Auto �6$   �� 5M      $
��Auto �6$   �� 5N      $
��Auto �6$   �� 5O      $
��Auto �6$   .+�5R      �� $
��Id :��6   $
��Bold"�6'   $��20(�69   $��0,0,10,0q�6G   $��0��6Y   $��0��6f   �� 5S      -   5         ��Name$ txtId��5S      $
��Bold"�6+   $��20(�6=   $��0,5,0,0q�6K   $��0��6\   $��1��6i   �� 5U      $
��Code��6   $��1��6'   $��0��64   �� 5V      -   5         ��Name$ txtCode��5V      $��35��6+   $��1��6c   $��1��6p   �� 5X      $
��Year��6   $��2��6'   $��0��64   �� 5Y      -   5        $ txtYear��5Y      $��35��6+   $��2��6c   $��1��6p   �� 5[      $��
Begin Date��6   $��3��6-   $��0��6:     5\      -   5          Name$ txtStartDate��5\      $��35��63   $��3��6v   $��1��6�   �� 5^      $��End Date��6   $��4��6+   $��0��68     5_      -   5        $ 
txtEndDate��5_      $��35��61   $��4��6r   $��1��6   5`      �� 5a      $ 
Horizontal=�6   $��2��62   $��Center=�6?   $��50��6\   $	��198��6h   .+�5b      �� -   5         ��Name$ btnSave��5b      $
��Save��6*   $��90��6O   �� 5c      -   5        $ 	btnCancel��5c      $��Cancel��6,   ���	#FF9C5499$��90��6l   5d      5e      5f      5g      