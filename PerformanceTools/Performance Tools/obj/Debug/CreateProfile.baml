   M S B A M L   `   `   `  ����K  GPerformanceTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Performance_ToolsPerformance_Tools  5   	   %    Performance_Tools.CreateProfile   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Performance_Tools     5   	     � Title$  CreateProfile��5   	   $	��550��6   $	��550��6,    � 
ResizeMode$ 	CanResize=�68    � WindowState$ Normal=�6O    � AllowsTransparency .  � WindowStyle$
 None=�6~   
������ $��Roboto)�6�   $��Normal"�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ 
MainBorder��5
      
������� �� CornerRadius$ 5��68   $��0q�6I   $	��0.5q�6T   
������� J� SnapsToDevicePixels . 5      � 5   
    � RowDefinitions 5      �� 5      $��38 �6    �� 5      $	��454 �6    �� 5      $��48 �6    .+�5      �� -   5        $ topbar��5      $��0��6%   $ 5,5,0,0��62   
�������._�5      � 	 � ColumnDefinitions	 5      �� 5      $��10 �6+   �� 5      $	��105 �6+   �� 5      $��* �6+   �� 5      $��72 �6+   �� 5      $��5 �6+   .+�5       �� $��1��6   $��Create Profile��6,   $��Roboto)�6E   $��Center=�6Y   �� 5!      $��3��6!   
 �� Orientation$
 
Horizontal=�61   .+�5"      �� -   5         ��Name$ maxbtn��5"   !    
  maxbtn#���   61   $��5,0,0,0q�6R   6c   �� 5#      -   5        $ minbtn��5#   !    
 minbtn#���  61   $��5,0,0,0q�6R   6c   �� 5$      -   5        $ closebtn��5$   !     closebtn#���  63   $��5,0,0,0q�6V   6g   5%      5'       J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         Color$
 Gray��6'      ShadowDepth$	 0.5Q�64   5+      5-      �� 5/      $��1��6   .+�50      �� $��Profile Name : ��6   $��14(�62   $��10,20,10,10q�6@   �� 51      -   5         ��Name$ Profname��51      $��29��6,   $��
12,0,80,10q�68   $��14(�6L   �� 53      $��STAPM Limit : ��6   $��14(�61   $��10,15,10,10q�6?   �� 54      $
 
Horizontal=�6   $��
10,0,80,10q�66   .+�55      �� -   5         ��Name$ stapm_slide��55       �� Orientation$ 
Horizontal=�62     Horizontal_Slider#���  6L   $	��363��6x    � Value$ 25Q�6�    �� TickPlacement$
 None=�6�    � Maximum$ 45Q�6�    � Minimum$ 15Q�6�    � SmallChange$ 1Q�6�    �� IsSnapToTickEnabled . 6�   �� 56      -   5        $ stapmval��56        MiniTextBox#���  6�   $��45,0,0,0q�6�   ��60   ��  �� ElementName$ stapm_slide�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   57      �� 59      $��Fast Limit : ��6   $��14(�60   $��10,15,10,10q�6>   �� 5:      $
 
Horizontal=�6   $��
10,0,80,10q�66   .+�5;      �� -	   5        $ 
fast_slide��5;      $ 
Horizontal=�61   #���  6K   $	��363��6w   $ 45Q�6�   $ 15Q�6�   $ 1Q�6�    . 6�   �� 5<      -
   5        $ fastval��5<      #���  6�   $��45,0,0,0q�6�   ��6/   �� $ 
fast_slide��$ Value�$ PropertyChanged=�6�   5=      �� 5?      $��Slow Limit : ��6   $��14(�60   $��10,15,10,10q�6>   �� 5@      $
 
Horizontal=�6   $��
10,0,80,10q�66   .+�5A      �� -   5        $ 
slow_slide��5A      $ 
Horizontal=�61   #���  6K   $	��363��6w   $ 45Q�6�   $ 15Q�6�   $ 1Q�6�    . 6�   �� 5B      -   5        $ slowval��5B      #���  6�   $��45,0,0,0q�6�   ��6/   �� $ 
slow_slide��$ Value�$ PropertyChanged=�6�   5C      �� 5E      $��Temp Limit : ��6   $��14(�60   $��10,15,10,10q�6>   �� 5F      $
 
Horizontal=�6   $��
10,0,80,10q�66   .+�5G      �� -   5        $ 
temp_slide��5G      $ 
Horizontal=�61   #���  6K   $	��363��6w   $ 95Q�6�   $ 50Q�6�   $ 1Q�6�    . 6�   �� 5H      -   5        $ tempwval��5H      #���  6�   $��45,0,0,0q�6�   ��60   �� $ 
temp_slide��$ Value�$ PropertyChanged=�6�   5I      5L      �� 5M      $��2��6   $
 
Horizontal=�6&   $��Right=�6?   .+�5N      �� -   5        $ 
createprof��5N      $��Create��6-     MainBtn#���  6>   $��64��6`   $��28��6k   $��	10,0,10,0q�6w   6�   5O      5Q      5R      5T      