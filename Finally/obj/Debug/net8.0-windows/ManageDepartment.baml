   M S B A M L   `   `   `  ����B  >Finally, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FinallyFinally  5   	       Finally.ManageDepartment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Finally     5   	     � Title$  Department List��5   	   $	��500��6!   $	��700��6.   
������� � 
ResizeMode$ NoResize=�5	        � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding��%�  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   #��z��5   !   $ 10��5   !   # z��63   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      �� 5       � ��
 �����6+   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   5      5      .��5      � 	 � RowDefinitions	 5    
   �� 5!      $
��Auto �6   �� 5#      $��* �6   �� 5%      $
��Auto �6   .+�5)   
   �� -   5        $��Logout��5)      ���#f44336$��10q�67   $��10q�6D   $��Right=�6P   $	��Top=�6l   6�   � 5,   
   $��1��6   .+�5-      �� 
 �� Orientation$
 Vertical=�6   $��10q�60   .+�5.      �� -   5         ��Name$ ListDepartment��5.       �� View 5/      �� 50      .P�51      �� $��ID��6-    �� Width$	 100��6]    �� DisplayMemberBinding 69   �� *Id+6]   �� 52      $��Department Name��6-   $	 150��6l    6F   �� *Name+6l   �� 53      $��Subject��6-   $	 300��6g    6>   �� *	Subject+6g   �� 54      $��Details��6-   $	 100��6>    �� CellTemplate 55   "   �� 56   &   .R�57   *   �� -   5        $��Detail��57   1   ���#4caf50��6s   �� *Id+58   '   5:      5;      5=      �� 5?      -   5        $��viewlist��5?   8   $��View Student Account��6   $��200px��6H   ���#ff98006k   5A      5B      �� 5E   
   $��2��6   $
 Vertical=�6"   $��10q�69   .+�5F      �� -   5         ��Name$ TxtForAdmin��5F      $
 
Horizontal=�6.   $��Center=�6G   $��Center=�6d   $
��0,10q�6   .+�5G      �� $��5q�6   .+�5H      �� $��ID��6    $��5q�6*   �� 5I      -   5         ��Name$ txtId��5I      $	��100��6�   $��5q�6�   ��6.   ��  �� Path$ Id� �� Mode$ OneWay=� � DataContext 6T   ��  �� ElementName$ ListDepartment��$ SelectedItem�6�   5J      �� 5K      $��5q�6   .+�5L      �� $��Department Name��6    $��5q�67   �� 5M      -   5        $ txtName��5M      $	��150��6�   $��5q�6�   ��6/   �� $
 Name�$ OneWay=� 6W   �� $ ListDepartment��$ SelectedItem�6�   5N      �� 5O      $��5q�6   .+�5P      �� $��Subject��6    $��5q�6/   �� 5Q      -   5        $ 
txtSubject��5Q      $	��300��6�   $��5q�6�   ��62   �� $ Subject�$ OneWay=� 6]   �� $ ListDepartment��$ SelectedItem�6�   5R      5S      �� 5U      -	   5        $ ButtonForAdmin��5U      $
 
Horizontal=�61   $��Center=�6J   $��Center=�6g   $
��0,20q�6�   .+�5V      �� -
   5        
����  �$	��Add��5V   /   $	��100��6=   $��5q�6I   6T   �� 5W      -   5        
����  �$
��Edit��5W   /   $	��100��6>   $��5q�6J   6U   �� 5X      -   5        
����  �$��Delete��5X   /   $	��100��6@   $��5q�6L   6W   �� 5Y      -   5        
����  �$��Clear��5Y   /   $	��100��6?   $��5q�6K   6V   5Z      5[      5\      5]      