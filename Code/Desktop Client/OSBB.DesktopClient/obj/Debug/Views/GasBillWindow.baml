   M S B A M L   `   `   `  ����  OSBB.DesktopClient,    &OSBB.DesktopClient.Views.GasBillWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$1  +Начислить оплату за газ��5   	   $	��300��6)   $	��300��66   
�����_� � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value��%.  &	        �� 5   
   " ��61   .R�5      �� $��Border��6   
���   �$��3q�67   $ 2��6K   
�������
�����_�._�5      �� #��z��6#   6H   5	       5
      P� 5       �@J�IsMouseOver . . �5      �� $ Border��6    � ��
	 ��� �6G   5      5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   .+�5      �� $��20,0,0,0q�6   $��0��6*   )'Предыдущие показания6M   �� 5      $��20q�6   ��6"   �� *PrevCounter+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ 	LostFocus=�5      �� 5   
   $��1��6   .+�5       �� $��20,0,0,0q�6   #!Текущие показания6=   �� 5!      $��20q�6   ��6#   �� *ActualCounter+ . $ 	LostFocus=�5$      �� 5%   
   $��2��6   .+�5&      �� $��20,0,0,0q�6   
Тариф61   �� 5'      $��20q�6   $��2��6"   ��6/   �� *Factor+ . $ 	LostFocus=�5*      �� 5.   
   #��[  6   $��83,10,93,20q�6<   $��5q�6Q   $��3��6�   ��6]   �� *GasChargeCommand+.��6�   Сохранить6�   5/      50      