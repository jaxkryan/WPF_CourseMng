   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:CourseManagementSystem.StudentManagement(CourseManagementSystem.StudentManagement  5   	   D    >CourseManagementSystem.StudentManagement.ViewStudentManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:CourseManagementSystem.StudentManagement     5   	     � Title$  ViewStudentManagement��5   	   $	��650��6'   $
��1250��64    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ CanMinimize=�6f    � 	Resources 5	       �� 
TargetType   StyledButton �� Property �� Value �� Triggers P� Property	 P� Value&   System.Windows.Controls.DataGrid��%�  &	        '      �� 5
   
   " ��6   .�5      ��  � �� �#FFA5006+   �� 5       � ��
 �����6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       �@�Cursor$
 Hand��6'    5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      ��  � �� �#FF8C0063   5      P� 5       � ��$
	 True��6/   . �5      ��  � �� �#FF450063   5      5      �� 5   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5       �@ ColumnHeaderHeight$ 40Q�63   �� 5       �@ 	RowHeight$ 30Q�6*   �� 5        � ��$ 10q�6'   5!      5"      .��5$      � ��5%   
   �� 5&      
 �� ImageSource$
 \Image\DHFPT6-1.jpg��6    j� Stretch$ UniformToFill=�6;    � RowDefinitions 5(   
   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $��* �6   �� 5,      $
��Auto �6   .+�5/   
   �� $��0��6   $��STUDENT MANAGEMENT��6   
�������$��0,0,0,9q�6M   $��25(�6^   $��Center=�50      $��Center=�6)   $
��Bold"�6D   �� 51   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��
10,10,0,10q�6;   .+�52      �� $��Search:��6   $��10q�6'   
�������63   �� 53      -   5         ��Name$ txtSearchName��53      $	��150��6-   $��30��69   $��5q�6E   $��5q�6P   6\   �� 54      $��Gender:��6   $��10q�6'   
�������63   �� 55      -   5         ��Name$ 	cboGender��55      $	��100��6*   $��30��66   $��5q�6B   6M   �� 56      $��Country:��6   $��10q�6(   
�������64   �� 57      -   5        $ 
cboCountry��57      $	��100��6+   $��30��67   $��5q�6C   6N   �� 58      $��Department:��6   $��10q�6+   
�������67   �� 59      -   5        $ cboDepartment��59      $	��120��6.   $��30��6:   $��5q�6F   6Q   �� 5:      -   5        $��btnClearFilter��5:      $��Clear Filter��6+   $
��Bold"�6B   $��5q�5;      $��70��6   
�������6'   �� 5<      -   5        $��btnAddStudent��5<      $��Add student��6*   $	��100��6@   #��[  6L   $
��Bold"�5=   &   $��5q�68   �� 5>      -   5        $��	btnExport��5>      $��Export to Excel��6&   $
��Bold"�6@   $��5q�5?      $	��120��6   
����ح�$��Right=�6?   $��3��6[   �� 5@      -   5        $��	btnImport��5@      $��Import from Excel��6&   $
��Bold"�6B   $��5q�5A      $	��120��6   
����ح�$��Right=�64   $��3��6P   5B        5C   
   -	   5        $��dgData��5C   %      
IsReadOnly$
 True��6   $��2��63      AutoGenerateColumns$ False��6@      CanUserAddRows$ False��5D         CanUserDeleteRows$ False��6"   $��10,10,10,10q�6<      EnableRowVirtualization$ False��5E         Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Student ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6P     5H      $ Student Name��6%   $ 2* 6T    6;   �� *Name+6T     5I      $ 
Birth Date��6%   $ * 6W    69   �� *	Birthdate+6W     5J      $ Gender��6%   $ * 6P    65   �� *Gender+6P     5K      $ Address��6%   $ 2* 6R    66   �� *	Address+6R     5L      $
 City��6%   $ * 6L    63   �� *City+6L     5M      $ Country��6%   $ * 6R    66   �� *	Country+6R     5N      $ 
Department��6%   $ 2* 6X    69   �� *
Department+6X   5P      �� 5Q   
   -
   5        $��btnClose��5Q      $��3��6   $��Close��6.   $��5q�5R      $��40��6   $	��100��6$   $
��Bold"�60   
�������6B   5S      5T      