   M S B A M L   `   `   `  ����?  ;Lab7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7Lab7  5   	   C&clr-namespace:WpfCustomControlLibrary1WpfCustomControlLibrary1  5   	       Lab7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab7     5   	   Kwpfcustomcontrollibrary1&clr-namespace:WpfCustomControlLibrary1     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $	��800��6)   $��20(�65    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$' !local:NewCustomCommand.PnvCommand��5      6j    � 	Resources 5         	Lab7.City   Temperature   Name 	  Minsk��%<   &	          5   
   $ 15��6   $ Minsk��6&   63   5      .��5      � -   5         �Name$ grid1��5       � DataContext# [  6   $��0,10,2,0q�6?   .+�5   
   �� $��
Город��6   �� 5   
   $��174,0,470,493q�6*   ��6   �� *Name+6*   �� 5   
   $��Температура��6   $��10,72,638,421q�6)   �� 5   
   $��174,72,498,432q�6<   ��6   �� *Temperature+ �� Mode$ TwoWay=�6<   �� 5   
   -   5        $��Check��5      $��70,144,607,386q�67   �� 5   
   -   5        $��0,251,536,165q�5   3   .+�5      �� -   5        .��5      A� -   5        $��50��5      $��50��6%   
�������6C   5      5      �� 5   
   -   5        $��259,251,297,160q�5   :   .+�5      �� -   5        .��5      A� -	   5        $��50��5      $��50��6%   
���  ��6<   5      5       �� 5!   
   $��498,251,0,234q�6   .+�5"      �� -
   5        .��5#      A� $��50��6   $��50��6%   
����p��61   5$      5%      �� 5&   
   -   5        	 ��Name$	 Button1��5&      $��80��6"   $��30��6-   $��
Выход��69   $'��!local:NewCustomCommand.PnvCommand��5'      $��351,179,359,351q�6=   �� 5(   
   -   5        
 ��Name$
 
textBlock1��5(      $��10(�6(   $��	0,326,0,0q�66   5*      5,      