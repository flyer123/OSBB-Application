   M S B A M L   `   `   `  ����  OSBB.DesktopClient*    $OSBB.DesktopClient.Views.PaymentView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $	��203��5   T   $	��300��6a   
�����_�  � Title  6	   ��  �� Path$ OperationMode� �� RelativeSource �� *Self+ � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%.  &	        �� 5   
   " ��61   .R�5      �� $��Border��6   
���   �$��3q�67   $ 2��6K   
�������
�����_�._�5      �� #��z��6#   6H   5	       5
      P� 5       �@J�IsMouseOver . . �5      �� $	 Border��6   
 � ��
 ��� �6G   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��20,0,0,0q�6   $��0��6&   Сумма Оплаты6A   �� 5   
   $��20,25,20,25q�6   $��1��6'   ��64   �� *MoneyAmmount+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ 	LostFocus=��� 5   
   $��2��6   #��[  6   $��85,10,101,97q�6I   $��5q�6_   .��6k   Сохранить6v   5      5       