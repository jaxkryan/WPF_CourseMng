   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:CourseManagementSystem.SemeterManagement(CourseManagementSystem.SemeterManagement  5   	   A    ;CourseManagementSystem.SemeterManagement.SemesterManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:CourseManagementSystem.SemeterManagement     5   	     � Title$  SemesterManagement��5   	   $	��600��6$   $
��1020��61    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ CanMinimize=�6c    � 	Resources 5	       �� 
TargetType   StyledButton �� Property �� Value �� Triggers P� Property	 P� Value&   System.Windows.Controls.DataGrid��%�  &	        '      �� 5
   
   " ��6   .�5      ��  � �� �#FFA5006+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       �@�Cursor$
 Hand��6'    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �#FF8C0063   5      P� 5       � ��$
	 True��6/   . �5      ��  � �� �#FF450063   5      5      �� 5   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5       �@ ColumnHeaderHeight$ 40Q�63   �� 5       �@ 	RowHeight$ 30Q�6*   �� 5        � ��$ 10q�6'   5!      5"      .��5#      � ��5$   
   �� 5%      
 �� ImageSource$
 /Image/DHFPT6-1.jpg��6    j� Stretch$ UniformToFill=�6;    � RowDefinitions 5'   
   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $��* �6   �� 5+      $
��Auto �6   .+�5.   
   �� $��0��6   $��SEMESTER MANAGEMENT��6   
�������$��0,0,0,20q�6N   $��25(�6`   $��Center=�6n   $��Center=�6�   $
��Bold"�6�   �� 5/   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��1��6K   $��
10,10,0,10q�6X   .+�50      �� $��Filter by Year��6   $��10q�6-   
�������69   �� 51      -   5         ��Name$ YearComboBox��51      $��60��6-   $��25��68   $
��10,0q�6D   6R   �� 52      -   5        $��btnClearFilter��52      $��Clear Filter��6+   #��[  6B   $	��100��6h   6t   �� 53      -   5         ��Name$	 Add��53      $	��Add��6"   #��[  60   $	��100��6V   6b   �� 54      -   5        $
 Edit��54      $
��Edit��6#   #��[  62   $	��100��6X   6d   55        56   
   -   5        $��
dgSemester��56   %      
IsReadOnly$
 True��6   $��2��67      AutoGenerateColumns$ False��6D      CanUserAddRows$ False��6`      CanUserDeleteRows$ False��6w   $��10,10,10,51q�6�      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     59      $
 Code��6%   $ * 6L    63   �� *Code+6L     5:      $
 Year��6%   $ * 6L    63   �� *Year+6L     5;      $ 
Begin Date��6%   $	 120 6W    69   �� *	BeginDate+6W     5<      $ End Date��6%   $	 120 6S    67   �� *	EndDate+6S   5>      �� 5?   
   -   5        $��btnClose��5?      $��2��6   $��Close��6.   $	��100��6?   $��460,425,460,10q�6b   5@      5A      