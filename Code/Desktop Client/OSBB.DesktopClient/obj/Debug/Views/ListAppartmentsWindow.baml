   M S B A M L   `   `   `  ����M  IOSBB.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OSBB.DesktopClient.ViewModelsOSBB.DesktopClient.ViewModels  5   	   D @OSBB.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:OSBB.Data;assembly=OSBB.Data	OSBB.Data 5	   	   G COSBB.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:OSBB.Windows;assembly=OSBB.WindowsOSBB.Windows 5
   	   7 clr-namespace:OSBB.DesktopClientOSBB.DesktopClient  5   	   4    .OSBB.DesktopClient.Views.ListAppartmentsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A	viewModel+clr-namespace:OSBB.DesktopClient.ViewModels     5   	   ;data*clr-namespace:OSBB.Data;assembly=OSBB.Data     5	   	   Dwindows0clr-namespace:OSBB.Windows;assembly=OSBB.Windows     5
   	   .l clr-namespace:OSBB.DesktopClient     5   	   -   5          � Title$  ОСМД��5   	   $	��644��6   $
��1305��6#   
�����_�
������� � SizeToContent$ WidthAndHeight=�6q    � 	Resources 5         VisibilityConverter0   *OSBB.DesktopClient.SubstractValueConverter  SubstractConverter-   'OSBB.DesktopClient.FilterValueConverter  FilterConverter  ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value  AlternatingStyle �� 
TargetType �� Triggers��%�  &	        &	      &	 &     &	 9     &	 ]    �� 5      6%     5      6"     5   
   6!   �� 5   
   " ��61   .R�5      �� $��Border��6   
���   �$��3q�67   $ 2��6K   
�������
�����_�._�5      �� #��z��6#   6H   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ Border��6   	 � ��

 ��� �6G   5      5      �� 5   
   " ��6)    5      P� 5       �@��AlternationIndex$ 0��6C   . �5      �� 	 � ��

 ��İ�63   5      P� 5        �@��AlternationIndex$ 1��6C   . �5!      �� 	 � ��

 �����63   5"      P� 5#       �@��
IsSelected . . �5$      �� 	 � ��

 � ���63   5%      5'      5(      .��5)      ��  �� Orientation$ Vertical=�6   .+�5*   
   �� $ 
Horizontal=�6   .+�5+      �� $ Vertical=�6   .+�5,      �� #��[ 6   $��5q�6D   $��
10, 10,5,5q�6P   ��6d   �� *OpenNewAppartmentCommand+.��6�   #!Добавить квартиру6�   �� 5-      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenAppartmentCommand+.��6�   -+Редактировать квартиру6�   �� 5.      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *DeleteAppartmentCommand+.��6�   !Удалить квартиру6�   �� 5/      #��[ 6D   $��5q�6o   $��
10, 10,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenSpdtBillDialogCommand+.��6�   Рассчитать СПДТ6�   �� 50      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *" OpenElectricityBillDialogCommand+.��6�   Рассчитать свет6�   �� 51      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenWaterBillDialogCommand+.��6�   Рассчитать воду6�   �� 52      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenGasBillDialogCommand+.��6�   Рассчитать газ6�   �� 53      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenSpdtPaymentDialogCommand+.��6�   Оплатить СПДТ6�   �� 54      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *%#OpenElectricityPaymentDialogCommand+.��6�   Оплатить Свет6�   �� 55      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenWaterPaymentDialogCommand+.��6�   Оплатить Воду6�   �� 56      #��[ 6D   $��5q�6o   $��	10, 5,5,5q�6{   {�6   �� *AppartmentIsSelected+��6�   �� *OpenGasPaymentDialogCommand+.��6�   Оплатить Газ6�   57      �� 58      $ Vertical=�6   .+�59      �� $ 
Horizontal=�6   .+�5:      �� $ 
Horizontal=�6!   .+�5;      �� $��
20,10,5,10q�6$   0.Выделите критерии поиска6R   �� 5<      $��
10,10,5,10q�6$   Минимум6A   �� 5=      -   5        $��minCriterion��5=   6   $��
10,10,5,10q�6"   $��20��6J   $��40��6V   6c   �� 5>      $��
10,10,5,10q�6$   Максимум6B   �� 5?      -   5        $��maxCriterion��5?   6   $��
10,10,5,10q�6"   $��20��6J   $��40��6V   6c   �� 5@      -   5        $��sortCriterionComboBox��5@   7   $��
10,10,5,10q�6#   $��90��6T   .@�5A      �� 
 � Tag$ totalCharge��6+   .��6=   Общий долг6I   �� 5B      $ totalPayment��6+   .��6>   Общая оплата6L   �� 5C      $ 	gasCharge��6+   .��6;   Долг газ6E   �� 5D      $ 
gasPayment��6+   .��6<   Оплата газ6H   �� 5E      $ waterCharge��6+   .��6=   Долг вода6H   �� 5F      $ waterPayment��6+   .��6>   Оплата вода6K   �� 5G      $ electricityCharge��6+   .��6C   Долг свет6N   �� 5H      $ electricityPayment��6+   .��6D   Оплата свет6Q   �� 5I      $ 
spdtCharge��6+   .��6<   Долг СПДТ6G   �� 5J      $ spdtPayment��6+   .��6=   Оплата СПДТ6J   5K      �� 5L      $��
10,10,5,10q�6$   По возрастанию6H   �� 5M      -   5        $��directionCheckBox��5M   #   $��
10,10,5,10q�6<   6R   �� 5N      $��
10,10,5,10q�6!   ��65   �� *FilterCommand+��5O      �� 5P   "   Сортировка68   ��5R      `� 5S   "    `� 	Converter# [ 6/   .1�5T   &   ��  �� ElementName$ minCriterion��6.    �� Path$
 Text�6I   �� 5U   &   $ maxCriterion��6.   $
 Text�6I   �� 5V   &   $ sortCriterionComboBox��6.   $ SelectedItem.Tag�6R   �� 5W   &   $ directionCheckBox��6.   $ 	IsChecked�6N   5X   #   5Z      5[      5\      �� 5^      -   5        $��AppartmentsListView��5^   �   #��[ 6    �� AlternationCount$ 2��6R   $��30,10q�6g   $��Stretch=�6v    �� SelectedIndex$ 0��6�   $	��417��6  ��6�   �� $ Appartments� �� SelectedItem 6�   �� *SelectedAppartment+ �� View 5_      �� 5`      .P�5a      �� $��
Номер��6-    �� Width$
 Auto��6d    �� DisplayMemberBinding 6<   �� *Number+6d   �� 5b      $��Этаж��6-   $
 Auto��6b    6;   �� *Floor+6b   �� 5c      $��Жилая площадь��6-   $
 Auto��6p    6D   �� *
LivingArea+6p   �� 5d      $��Общая площадь��6-   $
 Auto��6q    6D   �� *GeneralArea+6q   �� 5e      $!��СПДТ Начислено��6-   $
 Auto��6o    6E   �� *
SpdtBill+6o   �� 5f      $��СПДТ Оплачено��6-   $
 Auto��6q    6D   �� *SpdtPayment+6q   �� 5g      $!��Свет Начислено��6-   $
 Auto��6v    6E   �� *ElectricityBill+6v   �� 5h      $��Свет Оплачено��6-   $
 Auto��6x    6D   �� *ElectricityPayment+6x   �� 5i      $!��Вода Начислено��6-   $
 Auto��6p    6E   �� *	WaterBill+6p   �� 5j      $��Вода Оплачено��6-   $
 Auto��6r    6D   �� *WaterPayment+6r   �� 5k      $��Газ Начислено��6-   $
 Auto��6m    6D   �� *	GasBill+6m   �� 5l      $��Газ Оплачено��6-   $
 Auto��6o    6C   �� *
GasPayment+6o   �� 5m      $#��Всего Начислено��6-   $
 Auto��6q    6F   �� *	TotalBill+6q   �� 5n      $!��Всего Оплачено��6-   $
 Auto��6s    6E   �� *TotalPayment+6s   �� 5o      $��Остаток��6-   $
 Auto��6>    �� CellTemplate 5p   "   �� 5q   &   .R�5r   *   �� ��5s   .   `� 5t   2   # [ 6?   1�5u   6   �� 5v   :   $ 	TotalBill�6B   �� 5w   :   $ TotalPayment�6B   5y   3   5{   +   5|   '   5~      5      5�      5�      5�   
   �� 5�   
   $ 
Horizontal=�6   .+�5�      �� $ Vertical=�6   .+�5�      �� #��[ 6   $��5q�6H   $��
10, 10,5,5q�6T   ��6h   �� *OpenNewOccupantCommand+.��6�   +)Добавить проживающего6�   �� 5�      #��[ 6F   $��5q�6q   $��	10, 5,5,5q�6}   {�6   �� *OccupantIsSelected+��6�   �� *OpenOccupantForEditCommand+.��6�   B@Редактировать данные проживающего6�   �� 5�      #��[ 6F   $��5q�6q   $��	10, 5,5,5q�6}   {�6   �� *OccupantIsSelected+��6�   �� *DeleteOccupantCommand+.��6�   )'Удалить проживающего6�   5�      �� 5�      -   5        $��OccupantsListView��5�   c   $
��Auto��6   $��80��6(   $��30,10q�67   $��2��6F   $��1��6S   ��6|   �� $ AppartmentsListView��$ SelectedItem.Occupants� 6�   �� *SelectedOccupant+ 5�      �� 5�      .P�5�      �� $��Фамилия��6-   $
 Auto��6h    6>   �� *
LastName+6h   �� 5�      $��Имя��6-   $
 Auto��6e    6:   �� *	FirstName+6e   �� 5�      $��Отчество��6-   $
 Auto��6k    6?   �� *
MiddleName+6k   �� 5�      $��Пол��6-   $
 Auto��6i    6:   �� *DisplayGender+6i   �� 5�      $��Дата рождения��6-   $
 Auto��6�    6D   �� *	BirthDate+ �� StringFormat$ 
dd/MM/yyyy��6�   �� 5�      $��Владелец��6-   $
 Auto��6l    6?   �� *OwnerString+6l   5�      5�      5�      5     5     