   M S B A M L   `   `   `  ����I  EWpfApp_LR5_Kuz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp_LR5_KuzWpfApp_LR5_Kuz  5   	       WpfApp_LR5_Kuz.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp_LR5_Kuz     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � $��55,10,-55,-10q�6   .+�5   
   �� -   5         ��Name$ Button1��5      $��Оплатить��6"   $
��Left=�65   $��	20,45,0,0q�6P   $	��Top=�6c   $	��120��6{   $y�Visible=�6�   
���   �
�������$��21��6�   6�   �� 5   
   -   5         ��Name$ TextBox��5      $
��Left=�6#   $��	20,20,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   $��20��6�   6�   �� 5   
   -   5         ��Name$ LabelSum��5      $$��Внесённая сумма:��6"   $
��Left=�6=   $��
154,20,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ LabelChange��5      $��Сдача:��6%   $
��Left=�66   $��
154,43,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ 
LabelPrice��5      $��Цена напитка:��6$   $
��Left=�6<   $��
292,20,0,0q�6W   $	��Top=�6k   �� 5   
   -   5         ��Name$ 
stackPanel��5      $��10,95,669,254q�6)   .+�5      	� -   5         	�Name$ 	Americano��5      $��Американо��6-   $	��Top=�6A    d� 	IsChecked$
 TrueY�6�   	� 5      -   5        $ 
cappuccino��5      $��Капучино��6.   $	��Top=�6B   6w   	� 5      -	   5        $ espresso��5      $��Эспрессо ��6,   6]   	� 5      -
   5        $ cocoa��5      $��
Какао��6)   6Q   5      �� 5   
   -   5         ��Name$ 	ImageMilk��5      $
��Left=�6#   $	��207��6>   $��-25,211,0,0q�6K   $	��Top=�6`   $	��242��6x   $,��&/fenx7m5o1s7vdljdvjjt70617ak9cavf.jpeg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ 
ImageSugar��5      $
��Left=�6$   $	��133��6?   $��123,314,0,0q�6L   $	��Top=�6a   $	��103��6y   $+��%/093f948d1087dedada54ae9f7e199cdd.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ ImageAmericano��5      $
��Left=�6(   $	��404��6C   $��
328,-6,0,0q�6P   $	��Top=�6d   $	��505��6|   $��/8_kofe_amerikano.png��6�   $y�Hidden=�6�   �� 5   
   -   5        $ 
ImageCocoa��5      $
��Left=�6$   $	��309��6?   $��
376,49,0,0q�6L   $	��Top=�6`   $	��458��6x   $'��!/6cfdf028159883.5637090d1843f.jpg��6�   $y�Hidden=�6�   �� 5   
   -   5        $ stackPanel2��5      $��95,95,618,263q�6*   .+�5      �� -   5        	 ��Name$
	 Milk��5      $��Молоко��6%   $��74��66   6X   �� 5      -   5        $	 Sugar��5      $��
Сахар��6&   $��74��66   6A   5      �� 5   
   -   5        $ ImageCappuccino��5      $
��Left=�6)   $	��289��6D   $��	357,0,0,0q�6Q   $��Center=�6d   $	��395��6   $��/cappuccino.png��6�   $y�Hidden=�6�   �� 5   
   -   5        $ ImageEspresso��5      $
��Left=�6'   $	��325��6B   $��
361,76,0,0q�6O   $	��Top=�6c   $	��371��6{   $��/espresso.png��6�   $y�Hidden=�6�   5!      5"      