   M S B A M L   `   `   `  ����D  @GoldBunny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GoldBunny.wind1sGoldBunny.wind1s  5      "    GoldBunny.wind1s.PageMedcard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:GoldBunny.wind1s     5        N� Title$  PageMedcard��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��470 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��800 �6   .+�5   
   �� -   5         ��Name$ LvPet��5      $��1��5      $��2��5      $��10,10,150,0q�5       �� View 5      �� 5      .P�5      ��  �� Width$	 150��6%   $��Имя питомца��5   )    �� DisplayMemberBinding 5   )   �� *	NamePet+�� 5      $	 180��6%   $��Тип питомца��5   )    5   )   �� *TypePet.NameTypePet+�� 5       $	 180��6%   $��День рождения��5!   )    5"   )   �� *
Birthday+�� 5#      $	 130��6%   $��Гендер��5$   )    5%   )   �� *Gender.NameGender+5&      5(      �� 5)   
   $��1��6   $��0��6"   $��0,100,0,150q�62   .+�5*      �� $��
Поиск��6   
�������$��16(�5,      �� 5-      $��Имя питомца��6   
�������$��14(�5/      $��20,0,0,0q�50      �� 51      -   5         ��Name$ 
txtNamePet��51      $	��100��52      53      54      �� 55   
   $��1��6   $��0��6"   $��	0,380,0,0q�62   .+�56      �� -   5         ��Name$	 Add��56      $��0,0,0,10q�57      $��20��58      $	��100��59      $��Добавить��5:      $��3��5;       
  ButOne#��[  5<      ��5>      �� 5?      	 �� 
TargetType"	 ��6&   .R�5@      �� $	��100��6!   $��20��6-   
 �� CornerRadius$
 8��5A   %   #��z��5B   %   ._�5C      �� $��Center=�6/   $��Center=�5D   3   5E      5F      5H      �� 5I      -   5        $
 Edit��5I      $��20��5J      $	��100��5K      $��Изменить��5L      $��3��5M      #��[  5N      ��5P      �� 5Q      "	 ��6&   .R�5R      �� $	��100��6!   $��20��6-   $
 8��5S   %   #��z��5T   %   ._�5U      �� $��Center=�6/   $��Center=�5V   3   5W      5X      5Z      �� 5[      -   5        $ Delete��5[      $��0,10,0,0q�5\      $��20��5]      $	��100��5^      $��Удалить��5_      #��[  5`      ��5b      �� 5c      "	 ��6&   .R�5d      �� $	��100��6!   $��20��6-   $
 8��5e   %   #��z��5f   %   ._�5g      �� $��Center=�6/   $��Center=�5h   3   5i      5j      5l      5m      5o      5p      