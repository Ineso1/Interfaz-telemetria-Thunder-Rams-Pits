   M S B A M L   `   `   `  ����E  ADataSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DataSender
DataSender  5   	       DataSender.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ced4http://schemas.microsoft.com/expression/2010/drawing     5   	   *localclr-namespace:DataSender     5   	     � Title$  Sender Panel��5	   	   $	��450��6   $	��800��6+   ���	#FFA74CBD.��5
      � ���	#FF14161D.+�5   
   �� $��Coords��6   $
��Left=�6!   $��	54,20,0,0q�6<   $	��Top=�6O   ���	#FFF641F2$
��Bold"�6~   $��Italic$�6�   �� 5   
   -   5         ��Name$	 lat��5      $
��Left=�6   $��
101,52,0,0q�6:    �� TextWrapping$
 Wrap=�6N   $��0.000000��6b   $	��Top=�6r   
���������6�   Z� ��6�   Z� �� 5   
   $
��Lat.��6   $
��Left=�6   $��	54,46,0,0q�6:   $	��Top=�6M   
�������$��14(�6x   �� 5   
   -   5        $	 lng��5      $
��Left=�6   $��
101,82,0,0q�6:   $
 Wrap=�6N   $��0.000000��6b   $	��Top=�6r   
���������6�   Z� ��6�   Z� �� 5   
   $
��Lng.��6   $
��Left=�6   $��	54,76,0,0q�6:   $	��Top=�6M   
�������$��14(�6x   �� 5   
   -   5        $
��Send��5      $
��Left=�6    $��
161,23,0,0q�6;   $	��Top=�6O   ���	#FFF69C41 � Cursor$
 Hand��6�   ��6g   Z� ��6�   Z� 6�   �� 5   
   $��Eje X��6   $
��Left=�6    $��
52,163,0,0q�6;   $	��Top=�6O   
�������6g   �� 5   
   $��Eje Y��6   $
��Left=�6    $��
52,190,0,0q�6;   $	��Top=�6O   
�������6g   �� 5   
   $��Eje Z��6   $
��Left=�6    $��
52,217,0,0q�6;   $	��Top=�6O   
�������6g   �� 5   
   -   5        $
��Left=�5      $��101,167,0,0q�6,   $	��Top=�6A   $	��120��6Y    � Maximum$	 180Q�6{    �� TickPlacement$ BottomRight=�6�    �� TickFrequency$ 1Q�6�   ��6e   Z� 6�   �� 5   
   -   5        $
��Left=�5      $��101,195,0,0q�6,   $	��Top=�6A   $	��120��6Y   $	 180Q�6{   $ BottomRight=�6�   $ 1Q�6�   ��6e   Z� 6�   �� 5   
   -   5        $
��Left=�5      $��101,221,0,0q�6,   $	��Top=�6A   $	��120��6Y   $	 180Q�6{   $ BottomRight=�6�   $ 1Q�6�   ��6e   Z� 6�   �� 5   
   $��Angle��6   $
��Left=�6    $��
54,136,0,0q�6;   $	��Top=�6O   ���	#FF15B62E$
��Bold"�6~   $��Italic$�6�   �� 5   
   -   5        $��lblTime��5      $��00:00:00 a. m.��6   $��16(�68   $
��Left=�6F   $	��Top=�6a   ���	#FFFEFEFE$��
658,17,0,0q�6�   �� 5   
   $��Tiempo real : ��6   $
��Left=�6)   $��
560,20,0,0q�6D   $	��Top=�6X   
�������6p   �� 5   
   $��Actual lap : ��6   $
��Left=�6(   $��
560,49,0,0q�6C   $	��Top=�6W   
�������6o   �� 5   
   -   5         ��Name$ instance��5      $��00:00:00.00��6"   $��16(�68   $
��Left=�6F   $	��Top=�6a   ���	#FFFEFEFE$��
658,45,0,0q�6�   �� 5   
   -	   5        $
 ejeX��5      $	��0°��6   $
��Left=�6+   $��232,163,0,0q�6F   $	��Top=�6[   
�������$��Normal"�6�   �� 5   
   -
   5        $
 ejeY��5      $	��0°��6   $
��Left=�6+   $��232,190,0,0q�6F   $	��Top=�6[   
�������$��Normal"�6�   �� 5   
   -   5        $
 ejeZ��5      $	��0°��6   $
��Left=�6+   $��232,217,0,0q�6F   $	��Top=�6[   
�������$��Normal"�6�   �� 5   
   $	��Lap��6   $
��Left=�6   $��
340,12,0,0q�69   $	��Top=�6M   ���	#FF1F99CD$
��Bold"�6|   $��Italic$�6�   $��24(�6�   ��6�   Z� �� 5    
   -   5        $	 lap��5       $
��Left=�6   $��
400,16,0,0q�6:   $
 Wrap=�6N   $
��Bold"�6b   $��0��6t   $	��Top=�6}   $��64��6�   
�������$��24(�6�   $��Center=�6   �� SelectionTextBrush 6�   Z� ��6�   Z� ��6�   Z� 6  �� 5!   
   -   5        $��
Change lap��5!      $
��Left=�6&   $��
374,57,0,0q�6A   $	��Top=�6U   ���	#FFF69C41$
 Hand��6�   ��6m   Z� ��6�   Z� 6�   �� 5"   
   $��Battery��6   $
��Left=�6"   $��325,106,0,0q�6=   $
��Bold"�6R   $	��Top=�6d   ���	#FFB19DE86|   �� 5#   
   -   5        $��Center=�5#      $��	0,138,0,0q�6.   $	��Top=�6A   $	��120��6Y   $	 100Q�6{   $ BottomRight=�6�   $ 1Q�6�   ��6e   Z� 6�   �� 5$   
   -   5        $ batery��5$      $��0%��6    $
��Left=�6-   $��422,101,0,0q�6H   $
��Bold"�6]   $	��Top=�6o   $��60��6�   
�������$��20(�6�   �� 5%   
   $��Temperature��6   $
��Left=�6&   $��
40,264,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   ���	#FFFF58586   �� 5&   
   -   5        $
��Left=�5&      $��
54,295,0,0q�6,   $	��Top=�6@   $	��167��6X   $	 200Q�6z   $ BottomRight=�6�   $ 1Q�6�   $��23��6�   ��6d   Z� 6�   �� 5'   
   -   5        $ temperatura��5'      $
��0°C��6%   $
��Left=�63   $��182,259,0,0q�6N   $
��Bold"�6c   $	��Top=�6u   $��71��6�   
�������$��20(�6�   � 5(   
   -   5        $��temperatureBar��5(      $
��Left=�6,   $��10��6G   $��
52,323,0,0q�6S   $	��Top=�6g   $	��166��6   	 � Minimum$	 0Q�6�   $	 200Q�6�   5)      5*      