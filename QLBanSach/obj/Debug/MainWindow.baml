   M S B A M L   `   `   `  ����D  @QLBanSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QLBanSach	QLBanSach  5   	   C ?Fluent, Version=6.1.0.326, Culture=neutral, PublicKeyToken=null/$clr-namespace:Fluent;assembly=FluentFluent 5   	       QLBanSach.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QLBanSach     5   	   7Fluent$clr-namespace:Fluent;assembly=Fluent     5   	   -   5         
  MainVM  � DataContext#  [  5	   	    � Title$ 
MainWindow��5
   	   $	��600��6   $
��1000��6)   .��5      ]� ��. .+�5   
     Fluent.Ribbon  -   5        $��ribbon��5   -   $	��Top=�6      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 File��6#      Content. 5         Fluent.BackstageTabControl  .@�5        Fluent.BackstageTabItem     Header$ Options��62     5      $ About��62   5      5         Tabs. 5        Fluent.RibbonTabItem     Header$ Category��6#     5      $ Product��6#     5      $ Transaction��6#   5      �� 5   
   -   5        $
��tabs��5      $��0q�6e    �� SelectedIndex 6!   �� 	 �� ElementName$	 ribbon��
 �� Path$
 SelectedTabIndex� � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType��%w   '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6.   6E   5!      5"      5#      5$      5%      5'      