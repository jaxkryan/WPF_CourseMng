   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CourseManagementSystemCourseManagementSystem  5   	   !    CourseManagementSystem.Home   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CourseManagementSystem     5   	     � Title$
  Home��5   	   $	��500��6   $	��900��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ CanMinimize=�6T    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 10q�6(   �� 5       � ��$ 16(�6)   �� 5       � �� �#007ACC6+   �� 5       � ��
 �����6+   �� 5       � �� �#005A9E6,   �� 5       � ��$ 2q�60   �� 5       � ��$	 150��6&   �� 5       � ��$ 40��6'   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   #��z��6w   $ 5��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5       5!      .��5"      � ��5#   
   �� 5$      	 �� ImageSource$	 Image/DHFPT6-1.jpg��6   
 j� Stretch$
 UniformToFill=�6:    � RowDefinitions 5&   
   �� 5'      $��* �6   �� 5(      $
��Auto �6   .+�5*   
   �� $��0��6   $��Center=�6"   $	��Top=�6?   ���#333 J� Opacity$	 0.8Q�6i   $	��439��6w   $��2��6�   $	��900��6�   .+�5+      �� $��Course Management System��6   $��28(�68   $
��Bold"�6F   
�������$��Center=�6k   $��	0,100,0,0q�6�   �� 5,      $-��'Welcome to the Course Management System��6   $��22(�6G   $��SemiBold"�6U   
������� �� TextAlignment$ Center=�6~   $��0,20,0,0q�6�   �� 5-      $T��NManage your courses, students, departments, semesters, and enrollments easily.��6   $��14(�6n   
�������$ Center=�6�   $��0,20,0,0q�6�   5.      �� 5/   
   ���#333$	 0.8Q�6'    �� Orientation$ 
Horizontal=�65   $��Center=�6N   $��Center=�6k   $	��900��6�   $��1��6�   .+�50      A�  A� Columns$ 6��6   $	��900��6&   .+�51      �� -   5         ��Name$ 	btnCourse��51      $��Courses��6,   6>   �� 52      -   5        $ 
btnStudent��52      $��Students��6-   6@   �� 53      -   5        $ btnDepartment��53      $��Departments��60   6F   �� 54      -   5        $ btnSemester��54      $��	Semesters��6.   6B   �� 55      -   5        $ 	btnEnroll��55      $��Enrollments��6,   6B   �� 56      -   5        $��Logout��56      ���#D9534F���#C9302C6W   57      58      59      5:      