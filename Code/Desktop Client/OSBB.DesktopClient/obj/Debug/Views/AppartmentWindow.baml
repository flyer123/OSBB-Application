   M S B A M L   `   `   `  ����M  IOSBB.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OSBB.DesktopClient.ViewModelsOSBB.DesktopClient.ViewModels  5   	   D @OSBB.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:OSBB.Data;assembly=OSBB.Data	OSBB.Data 5	   	   G COSBB.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:OSBB.Windows;assembly=OSBB.WindowsOSBB.Windows 5
   	   /    )OSBB.DesktopClient.Views.AppartmentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A	viewModel+clr-namespace:OSBB.DesktopClient.ViewModels     5   	   ;data*clr-namespace:OSBB.Data;assembly=OSBB.Data     5	   	   Dwindows0clr-namespace:OSBB.Windows;assembly=OSBB.Windows     5
   	     � Title$'  !Добавить квартиру��5   	   $��325.092��6#   $��392.748��64   
�����_� � 	Resources 5         VisibilityConverter  ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value��%K  &	        &	      �� 5      6%   �� 5   
   " ��61   .R�5      �� $��Border��6   
���   �$��3q�67   $ 2��6K   
�������
�����_�._�5      �� #��z��6#   6H   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ Border��6    � ��
	 ��� �6G   5      5      5      .��5      � .+�5      �� $��20q�6   $��Right=�6   .+�5      �� .��6   
Номер6   �� 5      ��6   �� *Number+
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ 	LostFocus=��� 5      .��6   
Этаж6   �� 5       ��6   �� *Floor+
 . $ 	LostFocus=��� 5#      .��6   Жилая площадь6    �� 5$      ��6   �� *
LivingArea+
 . $ 	LostFocus=��� 5'      .��6   Общая площадь6    �� 5(      ��6   �� *GeneralArea+
 . $ 	LostFocus=��� 56      $��122,10,106,10q�65   $��5q�6L   #��[ 6X   $��Сохранить��6�   {�6   �� *	CanModify+��6�   �� *UpdateAppartmentCommand+6�   57      58      59      