   M S B A M L   `   `   `  ����Q  MCourseManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CourseManagementSystemCourseManagementSystem  5   	   "    CourseManagementSystem.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CourseManagementSystem     5   	     � Title$  Login��5   	   $	��450��6   $	��700��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U   ���#f0f0f0.��5	      � .+�5   
   �� $��Image/DHFPT6-1.jpg��6   $
��Fill=�6,   $��Stretch=�6;   $��Stretch=�6Y   � 5   
   ���	#AAFFFFFF$��	0,0,350,0q�6&    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $	��350 �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $	��Top=�6&   $��Center=�6>   $��0,99,0,0q�6[   $��5��6m   $	��303��6~   .+�5      �� $��28(�5      $
��Bold"�6'   
��� ���$��Center=�5      $��10q�66   �� 6C   $�CMS Lite��6G   �� 6Y   �� 6e   6l   �� 5!      $��	Username:��6   �� 5"      -   5         ��Name$ Username��5"      �� 5$      $��	Password:��6   G� 5%      -   5         G�Name$ Password��5%      �� 5'       �� Orientation$ Vertical=�6   $��Center=�64   $��10q�6Q   .+�5(      �� -   5         ��Name$ LoginButton��5(      $��Login��62   $	��150��6B   
��� ���
�������5)   2   5.      52      54      � 57   
   $��0��6   $��1��6   $��Center=�6,   $��Center=�6G   $	��534��6d   59      5;      5<      