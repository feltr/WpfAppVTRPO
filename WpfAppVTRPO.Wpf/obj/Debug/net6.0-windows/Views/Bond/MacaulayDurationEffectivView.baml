   M S B A M L   `   `   `  ����D  @VTRPO.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:VTRPO.Wpf.Views.BondVTRPO.Wpf.Views.Bond  5      7    1VTRPO.Wpf.Views.Bond.MacaulayDurationEffectivView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:VTRPO.Wpf.Views.Bond     5      .��5	      �� .+�5
   
   ��   �� Orientation$  
Horizontal=�6   .+�5      �� $0��*текущая цена облигации��6   �� 5      -   5         ��Name$' !TextBox_PMacaulayDurationEffectiv��5      $	��100��6A   ��6M   �� *P+ �� UpdateSourceTrigger$ 	LostFocus=�5      �� 5   
   $  
Horizontal=�6   .+�5      �� $2��,размер купонной выплаты��6   �� 5      -   5        $' !TextBox_CMacaulayDurationEffectiv��5      $	��100��6A   ��6M   �� *C+$ 	LostFocus=�5      �� 5   
   $  
Horizontal=�6   .+�5      �� $-��'доходность облигации��6   �� 5      -   5        $' !TextBox_yMacaulayDurationEffectiv��5      $	��100��6A   ��6M   �� *y+$ 	LostFocus=�5      �� 5   
   $  
Horizontal=�6   .+�5      �� $*��$общее число купонов��6   �� 5      -   5        $' !TextBox_kMacaulayDurationEffectiv��5      $	��100��6A   ��6M   �� *n+$ 	LostFocus=�5      �� 5   
   $  
Horizontal=�6   .+�5      �� $'��!номинал облигации��6   �� 5      -   5        $' !TextBox_MMacaulayDurationEffectiv��5      $	��100��6A   ��6M   �� *M+$ 	LostFocus=�5      �� 5   
   $  
Horizontal=�6   .+�5      �� $d��^рыночная цена в случае понижения процентных ставок��6   �� 5       -   5        $) #TextBox_UpPMacaulayDurationEffectiv��5       $	��100��6C   ��6O   �� *UpP+$ 	LostFocus=�5!      �� 5"   
   $  
Horizontal=�6   .+�5#      �� $d��^рыночная цена в случае повышения процентных ставок��6   �� 5$      -   5        $+ %TextBox_DownPMacaulayDurationEffectiv��5$      $	��100��6E   ��6Q   �� *DownP+$ 	LostFocus=�5%      �� 5&   
   $  
Horizontal=�6   .+�5'      �� $4��.размер повышенной ставки��6   �� 5(      -   5        $) #TextBox_UpIMacaulayDurationEffectiv��5(      $	��100��6C   ��6O   �� *UpI+$ 	LostFocus=�5)      �� 5*   
   $  
Horizontal=�6   .+�5+      �� $4��.размер пониженной ставки��6   �� 5,      -	   5        $+ %TextBox_DownIMacaulayDurationEffectiv��5,      $	��100��6E   ��6Q   �� *DownI+$ 	LostFocus=�5-      5.      5/      