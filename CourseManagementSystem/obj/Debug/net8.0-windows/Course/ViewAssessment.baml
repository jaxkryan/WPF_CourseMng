   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CourseManagementSystem.CourseCourseManagementSystem.Course  5   	   2    ,CourseManagementSystem.Course.ViewAssessment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:CourseManagementSystem.Course     5   	     � Title$  ViewAssessment��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^    � 	Resources 5	      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value   OrangeButtonStyle �� Triggers P� Property	 P� Value��%�  '        &	  �     �� 5
   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5       �@ RowHeaderWidth$ 0Q�6/   �� 5       �@ ColumnHeaderHeight$ 40Q�63   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � ��
 �����6+   �� 5       � �� �#FFA5006+   �� 5       � �� �#FF8C006,   �� 5       �@�Cursor$
 Hand��6'    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �#FF8C0063   5      P� 5       � ��$
	 True��6/   . �5      ��  � �� �#FF450063   5      5!      5"      .��5#      � ��5$   
   �� 5%      
 �� ImageSource$
 /Image/DHFPT6-1.jpg��6    j� Stretch$ UniformToFill=�6;    � RowDefinitions 5'   
   �� 5(      $
��Auto �6   �� 5)      $��* �6   �� 5*      $
��Auto �6   .+�5,   
   �� $��ASSESSMENT MANAGEMENT��6   
�������$��16(�6C   $
��Bold"�6Q   $��10q�6c   $��Center=�6o     5-   
   -   5        $��dgAssessments��5-   %      
IsReadOnly$
 True��6      AutoGenerateColumns$ False��6:      CanUserAddRows$ False��6V      CanUserDeleteRows$ False��6m   $��1��6�      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Type+6L     50      $
 Name��6%   $ * 6L    63   �� *Name+6L     51      $ Percent��6%   $
 Auto 6R    66   �� *	Percent+6R   53      �� 54   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��2��6K   .+�55      �� -   5        $��btnAddAssessment��55   .   $��Add Assessment��6   $	��130��6F   $��35��6R   #��[  6^   6�   �� 56      -   5        $��btnEditAssessment��56   /   $��Edit Assessment��6   $	��130��6H   $��35��6T   #��[  6`   6�   �� 57      -   5        $��btnClose��57   %   $��Close��6   $	��130��65   $��35��6A   #��[  6M   6x   58      59      5:      