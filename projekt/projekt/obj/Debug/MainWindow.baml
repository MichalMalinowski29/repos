   M S B A M L   `   `   `  ����B  >projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projektprojekt  5   	       projekt.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:projekt     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��0��6   $��0��6$   $
��Left=�61   $��NoWrap=�6L   $	��Top=�6b    J� RenderTransformOrigin$ 0.142,0.378&�6z   �� 6�   $�Podaj bok macierz��6�   �� 6�    � Language$ pl-pl�6�   $�y��6�   6�   �� 5   
   -   5         ��Name$
 side��5   /   $��0��6   $��1��6"   $
��Left=�6=    �� TextWrapping$ NoWrap=�6X   $�� ��6n   $	��Top=�6v   $	��120��6�   6�   �� 5   
   -   5        $��0��5      $��2��6!   $%��Stwórz macierz o boku powyżej��6.   $��Stretch=�6V   $��Stretch=�6t   6�   �� 5   
   -   5         ��Name$ ColumnCountLabel��5   1   $��1��6   $��0��6$   $y�Hidden=�6K   $
��Left=�6_   $��NoWrap=�6z   $	��Top=�6�   $ 0.142,0.378&�6�   �� 6�   $�Wpisz indeks ��6�   �� 6�   $�kolumny��6�   �� 6�   $� któr��6  �� 6  $�ą��6  �� 6  $� chcesz policzyć��6#  6>  �� 5   
   -   5        $ columnCount��5   /   $��1��6   $��1��6"   $y�Hidden=�6D   $
��Left=�6X   $ NoWrap=�6s   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5    
   -   5         ��Name$ CountColumnButton��5    .   $��1��6   $��2��6!   $y�Hidden=�6I   $��Oblicz��6]   $��Stretch=�6n   $��Stretch=�6�   6�   �� 5"   
   -   5        $ RowCountLabel��5"   1   $��2��6   $��0��6$   $y�Hidden=�6H   $
��Left=�6\   $��NoWrap=�6w   $	��Top=�6�   $ 0.142,0.378&�6�   �� 6�   $ pl-pl�6�   $2�,Wpisz indeks wiersza który chcesz policzyć��6�   6  �� 5#   
   -   5        $ rowCount��5#   /   $��2��6   $��1��6"   $y�Hidden=�6A   $
��Left=�6V   $ NoWrap=�6q   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5$   
   -   5        $ CountRowButton��5$   .   $��2��6   $��2��6!   $y�Hidden=�6F   $��Oblicz��6Z   $��Stretch=�6k   $��Stretch=�6�   6�   �� 5&   
   -	   5        $��0��5&      $��3��6!   $G��AStwórz macierz o boku podanym i wartościach które teraz podaż��6.   $��Stretch=�6v   $��Stretch=�6�   6�   �� 5'   
   -
   5        $��1��5'      $��3��6!   $9��3Wybierz macierz z pliku (Podaj pierwszo bok wyżej)��6.   $��Stretch=�6k   $��Stretch=�6�   6�   �� 5(   
   -   5        $��2��5(      $��3��6!   $&�� Ustaw macierz na podstawie pliku��6.   $��Stretch=�6Y   $��Stretch=�6w   6�   �� 5*   
   -   5        $ SaveToFileLabel��5*   1   $��0��6   $��4��6$   $y�Hidden=�6J   $
��Left=�6^   $��NoWrap=�6y   $	��Top=�6�   $ 0.142,0.378&�6�   �� 6�   $�Zapisz macież do pliku��6�   �� 6�   $ pl-pl�6�   6  �� 5+   
   -   5        $ pathSF��5+   /   $��1��6   $��4��6"   $y�Hidden=�6?   $
��Left=�6S   $ NoWrap=�6n   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5,   
   -   5        $ ShowMatrixButton��5,   .   $��2��6   $��4��6!   $��Wyświetl macierz��6H   $y�Hidden=�6c   $��Stretch=�6w   $��Stretch=�6�   6�   �� 5.   
   -   5        $ SaveToFileButton��5.   .   $��0��6   $��5��6!   $y�Hidden=�6H   $��Wybierz plik��6\   $��Stretch=�6s   $��Stretch=�6�   6�   �� 50   
   -   5        $ SaveToFileSubmitButton��50   .   $��0��6   $��6��6!   $y�Hidden=�6N   $��Zapisz��6b   $��Stretch=�6s   $��Stretch=�6�   6�   �� 51   
   -   5        $ pathSF2��51   C   $��1��6   $��6��6"   $y�Hidden=�6/   $
��Left=�6T   $ NoWrap=�6o   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 52   
   -   5        $ CountDiagonalButton��52   .   $��2��6   $��6��6!   $y�Hidden=�6K   $��Oblicz przekątną��6_   $��Stretch=�6z   $��Stretch=�6�   6�   54      55      