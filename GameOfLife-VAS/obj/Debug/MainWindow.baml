   M S B A M L   `   `   `  ����I  EGameOfLife-VAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GameOfLife_VASGameOfLife_VAS  5   	       GameOfLife_VAS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GameOfLife_VAS     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1200��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��29* �6   �� 5      $	��34* �6   �� 5      $
��116* �6   .+�5   
   �� -   5         ��Name$
 grid��5      $
��Left=�6   $	��926��6:   $��	10,10,0,0q�6G   $	��Top=�6Z   $	��934��6r   $��3��6~   �� 5   
   $
��Left=�6   $��
563,60,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��57��6o   $	��177��6{   $
��Bold"�6�   $��14(�6�   $��2��6�   �� 6�   $�Najstarija jed��6�   �� 6�   $�inka je stara:��6�   �� 6�   .F�5      �� -   5         ��Name$ 
starostLbl��5      $�� ��6,   $
��Left=�67   $	��Top=�6R    J� RenderTransformOrigin$ 0.285,-0.193&�6j   $��16(�6�   $
��Bold"�6�   5      6#   �� 5   
   -   5         ��Name$
 kuca��5      $
��Left=�6   $	��100��69   $��610,254,0,0q�6F   $	��Top=�6[   $	��100��6s   $��2��6   �� 5   
   -   5        $ curGen��5      $��Trenutna generacija: ��6    $��2��6@   $
��Left=�6P   $��
563,10,0,0q�6k   $	��Top=�6   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $ aliveLbl��5      $��Živih agenata: ��6"   $��2��6<   $
��Left=�6L   $��563,133,0,0q�6g   $	��Top=�6|   $��14(�6�   $
��Bold"�6�   5      5      