   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CourseManagementSystem.CourseCourseManagementSystem.Course  5   	   4    .CourseManagementSystem.Course.ViewCourseManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:CourseManagementSystem.Course     5   	     � Title$  ViewCourseManage��5   	   $	��600��6"   $
��1020��6/    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ CanMinimize=�6a    � 	Resources 5	      ;   5CourseManagementSystem.Course.StatusToStringConverter   StatusToStringConverter �� 
TargetType  OrangeButtonStyle �� Property �� Value �� Triggers P� Property	 P� Value&   System.Windows.Controls.DataGrid��%  &	        &	      '        5
   
   6(   �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 �����6+   �� 5       � �� �#FFA5006+   �� 5       � �� �#FF8C006,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$	 5,3q�6(    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �#FF8C0063   5      P� 5       � ��$
	 True��6/   . �5      ��  � �� �#FF450063   5      5      �� 5    
   "  6   .�5!      ��  � ��$ 14(�6)   �� 5"       �@ ColumnHeaderHeight$ 40Q�63   �� 5#       �@ 	RowHeight$ 30Q�6*   �� 5$       � ��$ 10q�6'   5%      5&      .��5(      � ��5*   
   �� 5+      
 �� ImageSource$
 /Image/DHFPT6-1.jpg��6    j� Stretch$ UniformToFill=�6;    �� Opacity$	 0.8Q�6S    � ColumnDefinitions 50   
   �� 51      $	��20* �6   �� 52      $	��80* �6    � RowDefinitions 54   
   �� 55      $
��Auto �6   �� 56      $��* �6   �� 57      $
��Auto �6   .+�5;   
   �� $��0��6   $��2��6   $��COURSE MANAGEMENT��61   
�������$��25(�6`   $��Center=�5<      $��Center=�6-   $
��Bold"�6H   �� 5?   
   $��1��6   $��0��6"    �� Orientation$ Vertical=�62   $��10q�6I    K� ZIndex$ 1��6U   .+�5A      �� $��Filter by Title:��6   $��0,10,0,5q�60   
�������6B   �� 5B      -   5        $��cbFilterTitle��5B      $	��200��6,   68   �� 5D      $��Filter by Credits:��6   $��0,10,0,5q�62   
�������6D   �� 5E      -   5        $��cboFilterCredits��5E      $	��200��6/   6;   �� 5H      -   5        $��btnClearFilter��5H      $��Clear Filter��6+   $	��200��6B   #��[ 6N   $��0,20,0,0q�6y   6�   �� 5I      -   5        $��btnAddCourse��5I      $��
Add Course��6)   $	��200��6>   #��[ 6J   $��0,10,0,0q�6u   6�   �� 5J      -   5        $��btnUpdateCourse��5J      $��Update Course��6,   $	��200��6D   #��[ 6P   $��0,10,0,0q�6{   6�   �� 5K      -   5        $��btnChangeStatus��5K      $��Change Status��6,   $	��200��6D   #��[ 6P   $��0,10,0,0q�6{   6�   �� 5L      -   5        $��btnViewAssessments��5L      $��View Assessments��6/   $	��200��6J   #��[ 6V   $��0,10,0,0q�6�   6�   5M        5P   
   -   5        $��	dgCourses��5P   %      
IsReadOnly$
 True��6   $��1��66   $��1��6C      AutoGenerateColumns$ False��6S      CanUserAddRows$ False��5Q         CanUserDeleteRows$ False��6*   $��10q�6D   $ 1��6P      Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5T      $
 Code��6%   $ * 6L    63   �� *Code+6L     5U      $ Title��6%   $ 2* 6N    64   �� *Title+6N     5V      $ Credits��6%   $
 0.5* 6R    66   �� *	Credits+6R     5W      $ Status��6%   $ * 6�    65   �� *Status+ �� 	Converter# [  6�   5Y      �� 5\   
   -	   5        $��2��5\      $��0��6   $��2��6.   $��Close��6B   #��[ 6R   $��Center=�5]      $��5q�6.   $��40��69   $	��100��6E   6Q   5^      5_      