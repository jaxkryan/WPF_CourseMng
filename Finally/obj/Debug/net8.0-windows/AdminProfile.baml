   M S B A M L   `   `   `  ����B  >Finally, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FinallyFinally  5   	       Finally.AdminProfile   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Finally     5   	     � Title$  AdminProfile��5   	   $	��500��6   $	��400��6+   ���#E1F5FE.��5
      � $��20q�6   ���#E1F5FE.+�5   
   �� ���#03A9F4$��2q�6'    �� CornerRadius$ 10��6;   
�������._�5      �� $��20q�6   .+�5      �� 
��� E��$��Admin Profile��63   $��24(�6H   $
��Bold"�6V   $��Center=�6h   $
��0 10q�6�   �� 5       �� Orientation$ 
Horizontal=�6   $
��0 10q�66   .+�5      �� $��
Full Name:��6    $	��100��62   $��Center=�6>   �� 5      -   5         ��Name$ txtFullName��5      $	��200��63   $��Center=�6?   $��5q�6Z   ���#E1F5FE���#81D4FA$��1q�5   E   5      �� 5      $ 
Horizontal=�6   $
��0 10q�66   .+�5      �� $��Date of Birth:��6    $	��100��66   $��Center=�6B   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpDateOfBirth��5   !   $	��200��68   $��Center=�6D   $��5q�6_   ���#E1F5FE���#81D4FA$��1q�5   H   5      �� 5      $ 
Horizontal=�6   $
��0 10q�66   .+�5      �� $��Gender:��6    $	��100��6/   $��Center=�6;   �� 5      $ 
Horizontal=�6!   .+�5      	� -   5         	�Name$ rbMale��5   &   $
��Male��66    	� 	GroupName$ Gender��6E   $��5q�6X   	� 5      -   5        $ rbFemale��5   &   $��Female��68   $ Gender��6I   $��5q�6\   5       5!      �� 5#      $ 
Horizontal=�6   $
��0 10q�66   .+�5$      �� $��Phone Number:��6    $	��100��65   $��Center=�6A   �� 5%      -   5        $ txtPhoneNumber��5%      $	��200��66   $��Center=�6B   $��5q�6]   ���#E1F5FE���#81D4FA$��1q�5&   E   5'      �� 5)      $ 
Horizontal=�6   $
��0 10q�66   .+�5*      �� $��Address:��6    $	��100��60   $��Center=�6<   �� 5+      -   5        $ 
txtAddress��5+      $	��200��62   $��Center=�6>   $��5q�6Y   ���#E1F5FE���#81D4FA$��1q�5,   E   5-      �� 5/      $ 
Horizontal=�6   $��Center=�66   $
��0 20q�6S   .+�50      �� -   5        $��Save Changes��50      $	��100��64   $
��10 0q�6@   ���#00C853
�������52      �� 53      -   5        $
��Back��53      $	��100��6,   $
��10 0q�68   ���#D50000
�������55      56      57      58      59      5:      