   M S B A M L   `   `   `  ����C  ?Fluent, Version=6.1.0.326, Culture=neutral, PublicKeyToken=null/$clr-namespace:Fluent;assembly=FluentFluent  5      D @QLBanSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLBanSach	QLBanSach 5          QLBanSach.TransactionsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7Fluent$clr-namespace:Fluent;assembly=Fluent     5      )localclr-namespace:QLBanSach     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         TransactionsVM  � DataContext#  �   5
       N� Title$ TransactionsPage��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   .��5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   66   �� 5      $
��auto �6'   .+�5         Fluent.RibbonGroupBox     Header$ 
Operations��6(   $��0��6<   .@�5      ]� .+�5         Fluent.Button  -   5        $��btnAdd��5   (      Header$	 Add��6U      	LargeIcon$ Images/Add.png��6b   ��66   �� *
AddCommand+6     5      -   5        $��btnEdit��5   (   $
 Edit��6W   $ Images/Edit.png��6e   ��67   �� *EditCommand+6�     5      -   5        $��	btnDelete��5   (   $ Delete��6[   $ Images/Delete.png��6k   ��69   �� *DeleteCommand+6�   5       5!        5"      $��15 0 0 0q�6(   $ Report��6:   $��1��6J   .@�5#        -   5        $��btnStatistics��5#   $   $ 
Statistics��6_   $ Images/Statistics.png��6s   ��69   �� *StatisticCommand+6�   5%      5&      5(        5)   
   $��1��6   $��5q�6+   .��5*      � .+�5+      � $��0 0 0 10q�6   .+�5,      �� $	��200��6   $��5 5 15 5q�6+    �� DisplayMemberPath$ ProductName��6=   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Tên Sách��6�   	 �� 
IsEditable	 .  & "MaterialDesignFloatingHintComboBox#��[ 6  ��6]   �� *ProductList+
 �� SelectedItem
 6�   �� *SelectedProduct+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6V  �� 5-      $��70��6   $��5 5 15 5q�6w   $ Số Lượng��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6+   �� *
Quantity+$ PropertyChanged=�$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5.      $��Center=�6!   $	��120��6}   $��	5 5 15 -7q�6�   $ Ngày Thanh Toán��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *ContractDate+ �� StringFormat$ 
dd/MM/yyyy��6�   �� 5/      $	��120��6   $��5 5 15 5q�6}   $ DV Thanh toán��6�   #��[ 6�   ��6,   �� *BooksDelivery+$ PropertyChanged=�$ TwoWay=�6�   �� 50      $	��120��6   $��5 5 15 5q�6x   $ Giảm Giá (%)��6�   #��[ 6�   ��6,   �� *
Discount+$ PropertyChanged=�$ TwoWay=�6�   51      53      54        57   
   $��2��6   $��5q�6+   $��Stretch=�66   .��58      �� $
��Auto=�6   .��59      �� ��6   �� *List+$ TwoWay=�$ PropertyChanged=�
 6j   �� *SelectedItem+$ TwoWay=� �� View 5:      �� 5;      .P�5<      ��  �� Width$ 50��6-   $��Id��68    �� DisplayMemberBinding 6D   �� *Id+6j   �� 5=      $	 170��6-   $��
Tên Sách��69    6K   �� *Product.ProductName+6�   �� 5>      $ 90��6-   $��Số Lượng��68    6J   �� *
Quantity+6v   �� 5?      $	 135��6-   $��Ngày Thanh Toán��69    6R   �� *ContractDate+6�   �� 5@      $	 120��6-   $��DV Thanh Toán ��69    6Q   �� *BooksDelivery+6�   �� 5A      $	 110��6-   $��Giảm Giá (%)��69    6O   �� *
Discount+6{   �� 5B      $	 150��6-   $��Tổng Hoá Đơn��69    6O   �� *
TotalPrice+6}   5C      5E      5F      5G      5H      5J      