   M S B A M L   `   `   `  ����K  GPerformanceTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Performance_Tools.UsercontrolPerformance_Tools.Usercontrol  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      '    !Performance_Tools.Usercontrol.CPU   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Performance_Tools.Usercontrol     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      $��Roboto)�5
   7   .��5      � 
�������  � ColumnDefinitions  5   
   �� 5      $��3* �6   �� 5      $��4* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6&   $
��Left=�6=   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5        LiveCharts.Wpf.Gauge  -   5          Name$ tempgaugeCPU��5      $��5q�63      Uses360Mode .     From$ 0Q�5      	   To$	 100Q�6      Value$ 0Q�6&   $	��213��60   $	��132��6<      GaugeBackground �#e7eff8   GaugeActiveFill �#2196F35      �� 5      $��/Images/celsius.png��6   $��20��65   $��20��6A   	 �� BitmapScalingMode$	 HighQuality=�6L   $��-320,0,-150,-60q�6z   5      �� 5      -   5        
 ��Name$
 ClockspdCPU��5      $��0000 MHz��6)   $��Center=�6<   $��18(�6Y   �� 5      $	��CPU��6   $��Center=�6"   $��48(�6?   5      �� 5    
   $��2��6   $ Vertical=�6&   $��Right=�6=   .+�5!      �� $ 
Horizontal=�6   $��Center=�62   .+�5"        -   5        $ tempgaugeGPU��5"      $��5q�63    .  $ 0Q�5$      $	 100Q�6   $ 0Q�6&   $	��213��60   $	��132��6<    �#e7eff8 �#2196F35&      �� 5'      $��/Images/celsius.png��6   $��20��65   $��20��6A   $	 HighQuality=�6L   $��-320,0,-150,-60q�6z   5(      �� 5)      -   5        $
 ClockspdGPU��5)      $��0000 MHz��6)   $��Center=�6<   $��18(�6Y   �� 5*      $	��GPU��6   $��Center=�6"   $��48(�6?   5,      � 5-   
   $��1��6   $��15q�6   .+�5.      � .+�5/      �� 
������� �� CornerRadius$ 6��6-   $��0q�6?    J� SnapsToDevicePixels .  J� Effect 50      3  -System.Windows.Media.Effects.DropShadowEffect  51         Color$ #BBDEFB��6+      ShadowDepth$ 0Q�6;      
BlurRadius$ 15Q�6K   6]   54      � 55      .+�56      �� $ Vertical=�6!   $��Center=�68   $��	40,0,40,0q�6U   $��Center=�6h   .+�57      �� $��System Information��6$   ���#2196F3$��18(�6S   $��0,20,0,0q�6a   �� 58      -   5        $
 cpufam��58       $��CPU Family : ��60   $��12(�6H   $��Center=�6V   $��0,20,0,0q�6t   $
��Bold"�6�   �� 59      -   5        $	
 ver��59       $��RyzenAdj Version : ��6-   $��12(�6K   $��Center=�6Y   $��0,10,0,0q�6w   �� 5:      -   5        $
 stapm��5:       $��STAPM LIMIT : ��6/   $��12(�6H   $��Center=�6V   $��0,10,0,0q�6t   �� 5;      -   5        $

 temp��5;       $��TEMP LIMIT : ��6.   $��12(�6F   $��Center=�6T   $��0,10,0,0q�6r   5<      5=      5>      5A      5D      5F      