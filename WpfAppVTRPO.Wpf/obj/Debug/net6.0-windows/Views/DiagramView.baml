   M S B A M L   `   `   `  ����D  @VTRPO.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VTRPO.Wpf.ViewsVTRPO.Wpf.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      !    VTRPO.Wpf.Views.DiagramView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VTRPO.Wpf.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5	      .��5
      � .+�5   
     LiveCharts.Wpf.PieChart  -   5           Name$  pieChart��5      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�6)      	Hoverable$ False��6m   $��0,38,0,0q�6�      DataClickCommand 6@   �� *PieClickCommand+   DataTooltip 6   Z�    Series 5        LiveCharts.Wpf.PieSeries  -   5          Name$ 
serDeposit��5         LiveCharts.Wpf.Series   Title$ Депозит��64      
DataLabels$
 True��6d   	   
Foreground
	 �   �
   Values
 6D   �� *PointDeposit+5         5      -   5        $ serPrecentEasy��5       $# Простой процент��69   $
 True��6n   
	 �   �
 6Q   �� *	PointEasy+5         5      -   5        $ serPrecentHard��5       $# Сложный процент��69   $
 True��6n   
	 �   �
 6Q   �� *	PointHard+5       5      �� 5   
   $:��4Диаграмма будущих процентов��6   $��14(�66   $��Center=�6D   $	��Top=�6b   $	��240��6z   $��32��6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��
Выйти��6   $��0,380,600,0q�6!   $��20(�66   ��6D   �� *ExitCommand+5      5      