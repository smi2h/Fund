   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      O KFund.DataLayer.Stock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullkIclr-namespace:Fund.DataLayer.Stock.Entities;assembly=Fund.DataLayer.StockFund.DataLayer.Stock.Entities 5       Fund.Wpf.UI'   !Fund.Wpf.UI.Views.CreateStockView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9system&clr-namespace:System;assembly=mscorlib     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      X TXceed.Wpf.Toolkit, Version=3.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5      VstocksIclr-namespace:Fund.DataLayer.Stock.Entities;assembly=Fund.DataLayer.Stock  5        � 	Resources  5       �� 
TargetType �� Property �� Value%  Xceed.Wpf.Toolkit.DecimalUpDown ��Name �� ElementName �� Triggers P� Property P� Value	 �� RelativeSource
 �� Path   
stockTypes S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName%  Xceed.Wpf.Toolkit.IntegerUpDown��%�  '��       '�� o     '      &	  �    '  F    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ Center=�62   5      �� 5   
   "  6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ Center=�62   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $��2q�6%   
���  ��._�5    "   �� .+�5!   &   �� $ errorControl��5"   )   5#   #   5$      �� 5%      
���  ����5&   !   �� *AdornedElement.ToolTip+$ errorControl��5(   !   5)      5*      5,       5-      P� 5.       �@=�HasError . . �5/      ��  � ��
 �  ��64   �� 50       � ��$ 1q�68   �� 51       �@�ToolTip 52      �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�54      56      S� 57   
   $ 	GetValues��58      "  59       5:      M� 5;      $ stocks:StockType��6   5=      �� 5>   
   "  6   .�5?      ��  � ��$	 100��6&   �� 5@       � ��$ Center=�62   �� 5A       �@=�ErrorTemplate 5B      �� 5C      .R�5D      �� .+�5E      �� $��2q�6%   
���  ��._�5F   "   �� .+�5G   &   �� $ errorControl��5H   )   5I   #   5J      �� 5K      
���  ����5L   !   �� *AdornedElement.ToolTip+$ errorControl��5N   !   5O      5P      5R       5S      P� 5T       �@=�HasError . . �5U      ��  � ��
 �  ��64   �� 5V       � ��$ 1q�68   �� 5W       �@�ToolTip 5X      �� 	 �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5Z      5\      �� 5]   
   " ��6   .�5^      ��  � ��$ 5q�6'   �� 5_       � ��$	 100��6&   �� 5`       � ��$ 30��6'   5a      5b      .��5d      � $��10q�6    � ColumnDefinitions 5e   
   �� 5f      $	��100 �6   �� 5g      $	��200 �6    � RowDefinitions 5i   
   �� 5j      $��45 �6   �� 5k      $��45 �6   �� 5l      $��45 �6   �� 5m      .+�5p   
   �� $��
StockType:��6   �� 5q   
   $��1��6   ��5r      ��  �� Source# [   �� SelectedItem 5s      �� *SelectedStockType+�� 5u   
   $��1��6   $��Price:��6!     5v   
   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$ C2��6    $��1��5w       $��1��5x       �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5y       �� *Price+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . �� 5|   
   $��2��6   $��	Quantity:��6!     5}   
   $��2��6    $��1��5~       �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$ N0��5       �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5�       �� *
Quantity+$ PropertyChanged=� .  . �� 5�   
   $��4��6   $��2��5�      $
��Left=�5�      $��CreateStock��5�      ��5�      �� *AddStockCommand+5�      5�      