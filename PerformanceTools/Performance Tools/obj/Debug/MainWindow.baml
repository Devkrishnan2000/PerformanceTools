   M S B A M L   `   `   `  ����K  GPerformanceTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Performance_ToolsPerformance_Tools  5   	   M+clr-namespace:Performance_Tools.UsercontrolPerformance_Tools.Usercontrol  5   	   "    Performance_Tools.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Performance_Tools     5   	   :us+clr-namespace:Performance_Tools.Usercontrol     5   	   -   5          �Name$  window��5   	    � Title$ 
MainWindow��5	   	   $	��658��6   $	��810��6)    � 
ResizeMode$ 	CanResize=�65    � WindowState$ Normal=�6L    � AllowsTransparency .  � WindowStyle$
 None=�6{   
������ $��Roboto)�6�    � Icon$ 	/icon.ico��6�    � 	Resources 5
      ��%    5      .��5      �� -   5         ��Name$ 
MainBorder��5      
�������	 �� CornerRadius$	 5��64   $��10q�6E   $	��0.5q�6Q   
�������._�5   
   � 
 � RowDefinitions
 5      �� 5      $��38 �6    �� 5      $	��550 �6    �� 5      $��32 �6    .+�5      � $��0��6   .+�5      �� -   5        $ topbar��5      $��0��6)   $	 5,5,0,0��66   
�������._�5      �  � ColumnDefinitions 5      �� 5      $��10 �6/   �� 5      $	��105 �6/   �� 5      $��* �6/   �� 5      $��72 �6/   �� 5       $��5 �6/   .+�5#      �� $��1��6    $��Performance Tool��60   $��Roboto)�6K   $��Center=�6_   �� 5$      $��3��6%    �� Orientation$ 
Horizontal=�65   .+�5%      �� -   5         ��Name$ maxbtn��5%   %    
  maxbtn#���   65   $��5,0,0,0q�6V   6g   �� 5&      -   5        $ minbtn��5&   %    
 minbtn#���  65   $��5,0,0,0q�6V   6g   �� 5'      -   5        $ closebtn��5'   %     closebtn#���  67   $��5,0,0,0q�6Z   6k   5(      5*       J� Effect 5+      3  -System.Windows.Media.Effects.DropShadowEffect  5,         Color$
 Gray��6+      ShadowDepth$	 0.5Q�68   5.      50      51      � 54      -   5         �Name$ MainBody��54      $��1��6&   
 55      �� 56      $��5* �6$   �� 57      $��5* �6$   .+�5:      � $��0��6   $��
15,15,15,0q�6$   .+�5;      �� -   5        $ FirstSection��5;   *   $��0��6   $	 5��6@   
������� J� SnapsToDevicePixels .  5<        5=      $ 	#FFD0D0D0��6/   $ 1Q�6A      
BlurRadius$ 15Q�6Q      Opacity$ 1Q�6a      RenderingBias$ Quality=�6m      	Direction$	 330Q�6�   5@      � 5A      .+�5B      '   !Performance_Tools.Usercontrol.CPU  5C      5D      � 5F      $��1��6   $��0,20,0,0q�6%   .+�5G      ,   &Performance_Tools.Usercontrol.Profiles  5H      5J      5L      5M      5O      