   M S B A M L   `   `   `  ����  Fund.Wpf.UI%    Fund.Wpf.UI.Views.StockGridView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5	      &   System.Windows.Controls.DataGrid      AutoGenerateColumns  .  ��6   �� *Stocks+   Columns 5
   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6?      CanUserReorder .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6!   ��  �� Path$
 Type�6M     5         MinWidth$	 100Q�6:   $
 Name��6I    .   6!   �� *Name+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      �� 	 �� Property	 � ��
 �� Value

 �����67    �� Triggers 5      �� 5       �� Binding 6*   �� *IsHighlighted+ �� Value True6L   .a�5   "   �� 	 � ��

 �  ��6?   5      �� 5       6*   �� *IsHighlighted+	 False6L   .a�5   "   �� 	 � ��

 �   �6?   5      5      5        5      $ Price��6W    .   6!   �� $ Price� �� StringFormat$ {0:n2}��5   !     5      $ Quantity��6Z    .   6!   �� $ Quantity�$ {0:n2}��5    !     5!      $ MarketValue��6]    .   6!   �� $ MarketValue�$ {0:n2}��5"   !     5#      $ TransactionCosts��5$   !    .   5#   !   �� $ TransactionCosts�$ {0:n2}��5$   ;     5%      $ StockWeight��6]    .   6!   �� $ StockWeight�$ {0:n2}��5&   !   5(      5)      