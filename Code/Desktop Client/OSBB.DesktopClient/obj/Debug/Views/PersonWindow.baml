   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   M IDatePickerExtended, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:DatePickerExtended;assembly=DatePickerExtendedDatePickerExtended 5   	   M IOSBB.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:OSBB.DesktopClient.ViewModelsOSBB.DesktopClient.ViewModels 5   
   D @OSBB.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:OSBB.Data;assembly=OSBB.Data	OSBB.Data 5   	   L HGenderEnumeration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:GenderEnumeration;assembly=GenderEnumerationGenderEnumeration 5   	   G COSBB.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:OSBB.Windows;assembly=OSBB.WindowsOSBB.Windows 5   
   +   %OSBB.DesktopClient.Views.PersonWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R	 NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml 	    5   	   @d2http://schemas.microsoft.com/expression/blend/2008 	    5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006 	    5   	   6sys&clr-namespace:System;assembly=mscorlib 	    5   	   Qcontrols<clr-namespace:DatePickerExtended;assembly=DatePickerExtended 	    5   	   A	viewModel+clr-namespace:OSBB.DesktopClient.ViewModels 	    5   
   ;data*clr-namespace:OSBB.Data;assembly=OSBB.Data 	    5   	   Llocal:clr-namespace:GenderEnumeration;assembly=GenderEnumeration 	    5   	   Dwindows0clr-namespace:OSBB.Windows;assembly=OSBB.Windows 	    5   
     � Title$/  )Добавить проживающего��5   	   $	��376��6'   $	��375��64   
�����_� � 	Resources 5         VisibilityConverter  ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value��%K  &	        &	      �� 5      6%   �� 5      " ��65   .R�5      �� $��Border��6   
���   �$��3q�6;   $ 2��6O   
�������
�����_�._�5      �� #��z��6'   6L   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ Border��6!    � ��
	 ��� �6K   5      5      5      .��5      �� $��30q�6   .+�5      �� Имя6   �� 5      ��6   �� *	FirstName+
 �� ValidatesOnDataErrors
 .  �� UpdateSourceTrigger$ PropertyChanged=��� 5!      Фамилия6   �� 5"      ��6   �� *
LastName+
 . $ PropertyChanged=��� 5%      Отчество6   �� 5&      ��6   �� *
MiddleName+
 . $ PropertyChanged=��� 5)      Пол6   �� 5*       �� DisplayMemberPath$	 Key��6    �� SelectedValuePath$ Value��6/   ��6I   �� *
GenderList+ �� SelectedValue 6l   �� *SelectedGender+
 .  �� Mode$ TwoWay=�6�   �� 5+      Дата рождения6$   (  "System.Windows.Controls.DatePicker  5,         SelectedDate 6   ��  �� Path$ 	BirthDate�$ TwoWay=� �� ValidatesOnExceptions .  �� NotifyOnValidationError . $ PropertyChanged=� � DataContext 5/   A   �� 6\   �� 50      Владелец6   �� 51       d� 	IsChecked 6   �� *Owner+65   �� 55   
   #��[ 6   $��77,10,72,10q�6\   $��5q�6q   {�6<   �� *	CanModify+.��6}   Сохранить6�   56   	   57      