   M S B A M L   `   `   `  ����  OSBB.DesktopClient-    'OSBB.DesktopClient.Views.SpdtBillWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$!  Начислить СПДТ��5   	   $	��217��6    $	��300��6-   
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
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��	20,0,0,10q�6   $��0��6'   
Сумма6;   �� 5   
   $��20,25,20,25q�6   $��1��6'   ��64   �� *MoneyAmmount+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ 	LostFocus=��� 5   
   $��2��6   $��72,10,99,10q�6   $��5q�63   #��[  6?   ��6j   �� *SpdtChargeCommand+.��6�   Сохранить6�   5      5       