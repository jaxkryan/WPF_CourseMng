   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CourseManagementSystem.CourseCourseManagementSystem.Course  5   	   -    'CourseManagementSystem.Course.AddCourse   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:CourseManagementSystem.Course     5   	     � Title$  	AddCourse��5   	   $	��450��6   $	��450��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ CanMinimize=�6Y    � 	Resources 5
         PrimaryColor �� Color  ButtonHoverColor �� 
TargetType �� Property �� Value  TitleLabelStyle �� Triggers	 P� Property
 P� Value  CancelButtonStyle �� BasedOn��%�  &	        &	 #     '�� F     7   &	 �     7   '�� �    7   '�� e    7   '�� <    7   7  &	     7���� 5   
   $ 	#FF9C5400��6/   �� 5   
   $ 	#FFD37C00��63   �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5q�6'   �� 5       � ��8   6+   5      �� 5   
   " ��6(   .�5      ��  � ��$ 20(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��8   6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 10q�6'   5      �� 5"   
   " ��6   .�5#      ��  � ��$ 14(�6)   �� 5$       � ��$ 5,10,0,5q�6'   �� 5%       � ��8   6+   5&      �� 5)   
   " ��6   .�5*      ��  � ��$ 14(�6)   �� 5+       � ��$ 0,5,0,5q�6'   �� 5,       � ��8   6,   �� 5-       � ��$ 1q�60   �� 5.       � ��$ 5q�6(   5/      �� 52   
   " ��6   .�53      ��  � ��$ 14(�6)   �� 54       � ��$
 Bold"�6+   �� 55       � ��$	 100��6&   �� 56       � ��$ 35��6'   �� 57       � ��$ 5q�6'   �� 58       � ��
 �����6+   �� 59       � ��8   6+   �� 5:       �@�Cursor$
 Hand��6'   �� 5;       � ��$ 0q�60    5<      P� 5=      	 �@J�IsMouseOver$

 True��61   . �5>      ��  � ��8  63   5?      5A      �� 5D   
   " ��6*   8   .�5E      ��  � ��
 �����6+   5F      5G      .��5J      �  � RowDefinitions 5L   
   �� 5M      $
��Auto �6   �� 5N      $��* �6   �� 5O      $
��Auto �6   .+�5S   
   �� $��Center=�6   $��Center=�60   $��0��6M   .+�5T      �� $��ADD NEW COURSE��6   #��[ 6-   5U      �� 5X   
   
�������$��1q�6$    �� CornerRadius$ 5��68    �� Padding$ 20q�6I   $��10q�6V   $��1��6b   ._�5Y      ��  �� Orientation$ Vertical=�6   $��10q�60   .+�5Z      �� $��Course Code:��6   �� 5[      -   5        $��txtCourseCode��5[      �� 5\      $��Course Title:��6   �� 5]      -   5        $��txtCourseTitle��5]      �� 5^      $��Credits:��6   �� 5_      -   5        $��
txtCredits��5_      5`      5a      �� 5d   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   $��10q�6X   .+�5e      �� -   5        $��btnAdd��5e      $	��ADD��6#   61   �� 5f      -   5        $��	btnCancel��5f      $��CANCEL��6&   #��[ 67   6b   5g      5h      5i      