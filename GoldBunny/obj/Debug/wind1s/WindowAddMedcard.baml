   M S B A M L   `   `   `  ����D  @GoldBunny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GoldBunny.wind1sGoldBunny.wind1s  5   	   7 clr-namespace:GoldBunny.basedataGoldBunny.basedata  66   '    !GoldBunny.wind1s.WindowAddMedcard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GoldBunny.wind1s     5   	   3domain clr-namespace:GoldBunny.basedata     66     � Title$  WindowAddMedcard��5   	   $	��450��5	   	   $	��350��5
   	    � 
ResizeMode$ NoResize=�5   	   ���#181735.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��5      $��0��5      $��Center=�5      .+�5      � $��5q�6   � 5      $��5q�6   5      � 5      $��5q�6   .+�5      �� $,��&Имя питомца:                ��6   
�������5      �� 5       -   5         ��Name$ 
txtNamePet��5       
���   �$	��100��5"      5$      � 5%      $��5q�6   .+�5&      �� $��Тип питомца:   ��6   
�������5'      �� 5(      -   5         ��Name$ 
cmbTypePet��5(      
���   �$	��100��5*      5+      � 5,      .+�5-      �� $0��*День рождения:                ��6   
�������5.      (  "System.Windows.Controls.DatePicker  5/      -   5          Name$ JoinDateDatePicker��51      $��25��5/      $	��150��50      52      54      57      �� 58   
   $��Center=�6   $��0��59      $��1��5:      $��Center=�5;      .+�5<      � $��5q�6   .+�5=      �� $��Гендер:     ��6   
�������5>      �� 5?      -   5        $ 	cmbGender��5?      
���   �$	��100��5A      5B      5F      � 5G   
   $��3��6   $��2��5H      $��Center=�5I      $��Center=�5J      .+�5K      �� -   5         ��Name$ btnSaveMedcard��5N       
  ButOne#��[  5K      $��0,0,30,0q�5L      $
��Save��5M      ��5Q      �� 5R       �� 
TargetType" ��6&   .R�5S      �� $��75��6!   $��25��6,   	 �� CornerRadius$	 12��5T   %   #��z��5U   %   ._�5V      �� $��Center=�6/   $��Center=�5W   3   5X      5Y      5[      �� 5\      -   5        $ btnCancelMedcard��5^      #��[  5\      $��Cancel��5]      
 � Cursor$

 Hand��5_   4   ��5a      �� 5b      " ��6&   .R�5c      �� $��75��6!   $��25��6,   $	 12��5d   %   #��z��5e   %   ._�5f      �� $��Center=�6/   $��Center=�5g   3   5h      5i      5k      5l      5m      5n      