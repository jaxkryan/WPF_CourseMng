   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:CourseManagementSystem.EnrollmentManagement+CourseManagementSystem.EnrollmentManagement  5   	   :    4CourseManagementSystem.EnrollmentManagement.EditMark   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:CourseManagementSystem.EnrollmentManagement     5   	     � Title$  EditMark��5   	   $	��450��6   $	��800��6'    � 	Resources 5
       �� 
TargetType �� Property �� Value   PrimaryColor �� Color  ButtonHoverColor��%�  '��       '�� �     &	  �    &	     '�� 7    7   '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�62   �� 5       � ��$ 0,5,10,5q�6'   �� 5       � �� �	#FF9C54006+   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Center=�62   �� 5       � ��$ 0,5,0,5q�6'   �� 5       � ��$	 250��6&   �� 5       � ��$ 30��6'   �� 5       � ��
 � ���6,   �� 5       � ��$ 1q�60   5      �� 5   
   $ 	#FF9C5400��6/   �� 5    
   $ 	#FFD37C00��63   �� 5"   
   " ��6   .�5#      ��  � ��$ 14(�6)   �� 5$       � ��$ 0,0,0,5q�6'   �� 5%       � ��8   6+   5&      �� 5)   
   " ��6   .�5*      ��  � ��$ 14(�6)   �� 5+       � ��$
 Bold"�6+   �� 5,       � ��$	 120��6&   �� 5-       � ��$ 40��6'   �� 5.       � ��$ 10q�6'   �� 5/       � ��$
 10,5q�6(   �� 50       � �� �	#FF9C54006+   �� 51       � ��
 �����6+   �� 52       � ��
 � ���6,   �� 53       �@�Cursor$
 Hand��6'   54      55      .��57      �  � RowDefinitions 58   
   �� 59      $
��Auto �6   �� 5:      $��* �6   �� 5;      $
��Auto �6   .+�5?   
   �� -   5         ��Name$ lblTitle��5?      $��	Edit Mark��6"   $��0��66   $��0��6C   $��3��6S   $
��Bold"�6g   $��30(�6y   $��Center=�5@      $��20q�6.   &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ dgData��5C      	   AutoGenerateColumns$	 False��6#   $��1��6?   $��0��6L   $��20,20,266,20q�5D   >   $��2��6T   
   Columns
 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Assessment��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Assessment.Name+  5G      $
 Mark��6%   $ * 63    6=   �� *Mark1+5I      �� 5L   
   $��
Assessment��6   $��1��6&   $	��Top=�63   $
��Left=�6K   $��
550,40,0,0q�6f   �� 5M   
   -   5         ��Name$ 	txtAssess��5M      $��1��6%   $	��Top=�62   $
��Left=�6J   $��
550,74,0,0q�6e   $	��218��6y   �� 5P   
   $
��Mark��6   $��1��6    $	��Top=�6-   $
��Left=�6E   $��550,119,0,0q�6`   �� 5Q   
   -   5        $ txtMark��5Q      $��1��6#   $	��Top=�60   $
��Left=�6H   $��550,148,0,0q�6c   $��2��6x   $	��218��6�   �� 5T   
   -   5         ��Name$ btnEdit��5T      $
��Edit��6"   $��2��61   $
��Left=�6>   $��602,70,0,110q�6Y   6o   5U      5V      