   M S B A M L   `   `   `  ����B  >Finally, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:FinallyFinally  5   	       Finally.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Finally     5   	     � Title$  Login��5      $	��300��6   $	��450��6    
������� � 
ResizeMode$ NoResize=�5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6!   $��Manager Student��65   $��24(�5      $
��Bold"�6   
��� ���$��Center=�5      $��10q�6*   �� 5   
   $��1��6   $��0��6   $��	Username:��6-   $��10q�6A   
��� d �6M   �� 5   
   -   5         ��Name$ Username��5      $��1��6$   $��1��61   $��10q�6A   
������
��� d �6e   �� 5   
   $��2��6   $��0��6   $��	Password:��6-   $��10q�6A   
��� d �6M   G� 5   
   -   5         G�Name$ Password��5      $��2��6(   $��1��65   $��10q�6E   
������
��� d �6i   �� 5!   
   $��3��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��10q�6l   .+�5"      �� -   5         ��Name$ LoginButton��5"      $��Login��6*   $	��100��6:   $��5q�6F   
��� ���
�������5#   &   �� 5%      -   5        $ CancelButton��5%      $��Cancel��6+   $	��100��6<   $��5q�6H   
���Gc��
�������5&   "   �� 5'      -   5        $��Forgot Password��5'      $	��100��60   $��5q�6<   6G   5(      �� 5)   
   $��4��6   $��1��6"   .+�5*      �� -   5        $ Signupbutton��5*      $��Sign up��6+   $	��100��6=   $��
0, 10,80,0q�6I   
��� ���
�������5+      5,      5.      5/      