   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CourseManagementSystem.CourseCourseManagementSystem.Course  5   	   1    +CourseManagementSystem.Course.AddAssessment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:CourseManagementSystem.Course     5   	     � Title$  AddAssessment��5   	   $	��450��6   $	��500��6,    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ CanMinimize=�6]    � 	Resources 5	         PrimaryColor �� Color  ButtonHoverColor �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%i  &	        &	 #     '�� F     7   '��     7   '�� �    7   '�� �    7   7  �� 5   
   $ 	#FF9C5400��6/   �� 5   
   $ 	#FFD37C00��63   �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   �� 5       � ��8   6,   �� 5       � ��$ 1q�60   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   �� 5       � ��8   6,   �� 5       � ��$ 1q�60   5      �� 5"   
   " ��6   .�5#      ��  � ��$ 14(�6)   �� 5$       � ��$ 0,0,0,5q�6'   �� 5%       � ��8   6+   5&      �� 5)   
   " ��6   .�5*      ��  � ��$ 14(�6)   �� 5+       � ��$
 10,5q�6(   �� 5,       � ��$ 5q�6'   �� 5-       � ��8   6+   �� 5.       � ��
 �����6+   �� 5/       � ��$ 0q�60   �� 50       �@�Cursor$
 Hand��6'    51      P� 52      	 �@J�IsMouseOver$

 True��61   . �53      ��  � ��8  63   54      56      57      .��59      �  � RowDefinitions 5:   
   �� 5;      $
��Auto �6   �� 5<      $��* �6   .+�5@   
   �� $��ADD NEW ASSESSMENT��6   #��[  6-   $��18(�6X   $
��Bold"�5A      $��10q�6"   $��Center=�6.   �� 5D   
   
�������$��1q�6$    �� CornerRadius$ 5��68    �� Padding$ 20q�6I   $��10q�6V   $��1��6b   ._�5E      �� .+�5F      �� $��Type:��6   �� 5G      -   5         ��Name$ cmbType��5G      .@�5H      �� $	��Lab��6#   �� 5I      $
��Quiz��6#   �� 5J      $��
Assignment��6#   �� 5K      $��Class Participation��6#   �� 5L      $��Practical Exam��6#   �� 5M      $��
Final Exam��6#   5N      �� 5P      $��Name:��6   �� 5Q      -   5         ��Name$ txtName��5Q      �� 5S      $��Percent:��6   �� 5T      -   5        $ 
txtPercent��5T      �� 5W      -   5        $	��ADD��5W      $	��100��6'   $��30q�63   $��Center=�6?   6\   5X      5Y      5Z      5[      