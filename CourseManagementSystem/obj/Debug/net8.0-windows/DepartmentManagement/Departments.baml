   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:CourseManagementSystem.DepartmentManagement+CourseManagementSystem.DepartmentManagement  5   	   =    7CourseManagementSystem.DepartmentManagement.Departments   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:CourseManagementSystem.DepartmentManagement     5   	     � Title$  Departments��5   	   $	��600��6   $
��1020��6*    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�6\    � 	Resources 5	       �� 
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
   �� $��DEPARTMENT MANAGEMENT��6   
�������$��25(�50      $
��Bold"�51      $��Center=�52      $��0��53      $��0,0,0,20q�54      �� 56   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��1��6K   $��0,0,0,10q�6X   .+�57      �� -   5        $��btnAdd��57   #   $	��Add��6   #��[  61   $	��100��6W   6c   �� 58      -   5        $��	btnUpdate��58   &   $��Update��6   #��[  67   $	��100��6]   6i   �� 59      -   5        $��	btnDelete��59   &   $��Delete��6   #��[  67   $	��100��6]   6i   5:        5<   
   -   5          Name$ dgDepartments��5<      $��2��5=         AutoGenerateColumns$ False��5>         CanUserAddRows$ False��5?         CanUserDeleteRows$ False��5@         
IsReadOnly$
 True��5A      $��
10,0,10,10q�5B         Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Code+6L     5E      $
 Name��6%   $ * 6L    63   �� *Name+6L   5G      �� 5I   
   -   5        $��btnClose��5J      $��3��5I      $��Close��5K      $	��100��5M      $��30��5N      $
��Bold"�5O      $��10q�5P      $��Center=�5Q      5R      5S      