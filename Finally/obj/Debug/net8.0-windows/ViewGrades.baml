   M S B A M L   `   `   `  ����B  >Finally, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FinallyFinally  5   	       Finally.ViewGrades   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Finally     5   	     � Title$  
ViewGrades��5   	   $	��450��6   $	��700��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius&   System.Windows.Controls.DataGrid��%�  '��       '�� 	    '�� �    '  w    �� 5   
   " ��6   .�5      ��  � �� �#FF98006+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � ��
 ���� 6,   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   #��z��5   !   $ 5��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5      5      5       �� 5!   
   " ��6   .�5"      ��  � ��$ 5q�6'   �� 5#       � ��$ 5q�6(   �� 5$       � �� �#FF98006,   �� 5%       � ��$ 1q�60   5&      �� 5'   
   " ��6   .�5(      ��  � ��$ 5q�6'   �� 5)       � ��$ 5q�6(   �� 5*       � �� �#FF98006,   �� 5+       � ��$ 1q�60   5,      �� 5-   
   "  6   .�5.      ��  � ��$ 10q�6'   �� 5/       � �� �#FF98006,   �� 50       � ��$ 1q�60   �� 51       �@ RowBackground
 �����6.   �� 52        �@ AlternatingRowBackground �#F1F1F169   �� 53       �@ GridLinesVisibility$
 None=�64   54      55      .��57      � ���#FFF3E0 � RowDefinitions 58   
   �� 59      $
��Auto �6   �� 5:      $��* �6   �� 5;      $
��Auto �6   .+�5?   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $��Center=�6:   .+�5@      �� -   5        
���  ��$
��Back��5@   &   $	��100��65   6A   �� 5A      -   5        	 ��Name$	 
SortButton��5A      $��50,0,0,0q�6(   
�������$��Subject��6M   $��Center=�6_   $��25��6�   �� 5B      -   5        
 ��Name$
 SubjectComboBox��5B       �� SelectedIndex$ 0��60   $	��100��6v   5D        5G   
   -   5          Name$ GradesDataGrid��5G      $��1��6+      AutoGenerateColumns$ False��68   $��
48,8,48,11q�6T      Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Grade ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	GradeId+6S     5J      $ PresentScoree��6%   $	 100 6]    6<   �� *PresentScore+6]     5K      $ LabScore��6%   $ 80 6T    67   �� *
LabScore+6T     5L      $ Ptscore��6%   $	 100 6R    66   �� *	Ptscore+6R     5M      $ Fescore��6%   $	 100 6R    66   �� *	Fescore+6R     5N      $ OverallScore��6%   $	 100 6\    6;   �� *OverallScore+6\   5P      5S      5T      