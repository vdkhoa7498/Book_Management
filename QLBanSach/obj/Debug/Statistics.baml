   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   D @QLBanSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLBanSach	QLBanSach 5   	   l hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5   	      QLBanSach.Statistics   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   )localclr-namespace:QLBanSach     5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	      StatisticsVM  � DataContext#  �   5	   	    � Title$ 
Statistics��5   	   $	��800��6   $
��1000��6)   .��5      � $��	0,-15,0,0q�6   .+�5   
   >  8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��ProductsColumnChart��5          Title$< 6Biểu đồ cột Thống kê số lượng đã bán��6;   $	��200��6h   $	��400��6u   $��	50,50,0,0q�6�   $	��Top=�6�   $
��Left=�6�      Series. 5      E  ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   IsSelectionEnabled .    DependentValueBinding 6+   ��  �� Path$ Value�   IndependentValueBinding 6X   �� $	 Key�   ItemsSource 6�   �� 6�   5        5   
   -   5        	  Name$	 ProductsPieChart��5       $< 6Biểu đồ tròn Thống kê số lượng đã bán��6:   $	��200��6h   $	��400��6u   $��
550,50,0,0q�6�   $	��Top=�6�   $
��Left=�6�   . 5      B  <System.Windows.Controls.DataVisualization.Charting.PieSeries   .  6(   �� $ Value� 6U   �� $	 Key� 6�   �� 6�   5        5   
   -   5        $��TransactionsColumnChart��5       $< 6Biểu đồ cột Thống kê số lượng trong kho��6?   $	��200��6o   $	��400��6|   $��
50,270,0,0q�6�   $	��Top=�6�   $
��Left=�6�   . 5         .  6+   �� $ Value� 6X   �� $	 Key� 6�   �� 6�   5        5   
   -   5        $	 TransactionsPieChart��5       $< 6Biểu đồ tròn Thống kê số lượng trong kho��6>   $	��200��6o   $	��400��6|   $��550,270,0,0q�6�   $	��Top=�6�   $
��Left=�6�   . 5         .  6(   �� $ Value� 6U   �� $	 Key� 6�   �� 6�   5        5   
   -   5        $��IncomeLineChart��5       $3 -Biểu đồ đường thống kê thu nhập��67   $	��200��6_   $��	0,500,0,0q�6l   $	��Top=�6   $	��800��6�   . 5       C  =System.Windows.Controls.DataVisualization.Charting.LineSeries   .  6)   �� $ Value� 6V   �� $	 Key� 6�   �� 6�   5!      �� 5#   
   -   5        
 ��Name$
 btnDay��5#      $��Daily��6"   $
��Left=�62   $��
50,700,0,0q�6M   $	��Top=�6a   $	��120��6y   $��36��6�     MaterialDesignBackground#���  6�    " MaterialDesignRaisedDarkButton#���  6�   �� 5$   
   -   5        $
 btnMonth��5$      $��Monthly��6$   $
��Left=�66   $��190,700,0,0q�6Q   $	��Top=�6f   $	��120��6~   $��36��6�   #���  6�   #���  6�   �� 5%   
   -   5        $
 btnYear��5%      $��Yearly��6#   $
��Left=�64   $��330,700,0,0q�6O   $	��Top=�6d   $	��120��6|   $��36��6�   #���  6�   #���  6�   (  "System.Windows.Controls.DatePicker  5&   
   -	   5          Name$ DatePickerFrom��5&      $
��Left=�6-   $��670,700,0,0q�6H   $	��Top=�6]     5'   
   -
   5        $ DatePickerTo��5'      $
��Left=�6+   $��820,700,0,0q�6F   $	��Top=�6[    J� RenderTransformOrigin$ 	0.48,0.04&�6s   �� 5(   
   -   5        $
 	btnChoice��5(      $��Date of selection��6%   $
��Left=�6A   $��470,700,0,0q�6\   $	��Top=�6q   $	��180��6�   $��36��6�   #���  6�   #���  6�   5*      5+      