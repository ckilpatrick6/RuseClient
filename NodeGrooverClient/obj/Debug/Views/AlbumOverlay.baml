   M S B A M L   `   `   `  ����L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  5	      *    $NodeGrooverClient.Views.AlbumOverlay   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      G CFramework.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'extrahttp://schemas.extra.com/ui  5      Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  5      7params*http://schemas.codeplex.com/elysium/params  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      .cv%clr-namespace:NodeGrooverClient.Views  5	        Elysium.Parameters.Design    Theme$
  DarkX�5         Elysium.Parameters.Manager   Theme$
 DarkX�5       � 	Resources 5      1   +NodeGrooverClient.Views.VisibilityConverter   VisibilityConverter  searchItemTemplate  
FadeInGrid � ColumnDefinitions � RowDefinitions$  Elysium.Controls.CommandButton  FadeInButton �� Path �� RelativeSource �� AncestorType �� 	Converter)  #Framework.UI.Controls.OverlayWindow��%3  &	        &	      7  7  7   7  7     5   
   6!   �� 5   
   .R�5      � $��Stretch=�6   8��   5      �� 5      $��6* �6'   �� 5      $��* �6'   �� 5      $��* �6'    5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $��WordEllipsis=�62   $��0��6N   $��24(�6^   $��Segoe UI Light)�6l   $��Light"�6�   
���������6   �� *Name+6�   �� 5      $��1��65   $��0��6B   $��WordEllipsis=�6R   $��16(�6n   $��Segoe UI Light)�6|   $��Light"�6�   
���������6   �� *Artist+6�     5      8�� $	����6L   $��Segoe UI Symbol)�6�   $��1��6  $��2��6)  $��Right=�6:  y�6`   �� $ IsMouseOver� �� " ��8  ��6V  �� $ DataContext.PlayCommand� �� "  ��6�  �� *Id+  5      8�� $	����6L   $��Segoe UI Symbol)�6�   $��2��6  $��2��6(  $��Right=�69  y�6_   �� $ IsMouseOver� �� " ��8  ��6U  �� $ DataContext.QueueCommand� �� "  ��6�  �� *Id+5       5!      5#      .��5%      � $	��600��6   
���   � 5&   
   �� 5'      $��* �6   �� 5(      $��5* �6   �� 5)      $��8* �6    5+   
   �� 5,      $��6* �6   �� 5-      $	��12* �6   .+�50   
     -   5        $��5,5,0,0q�50      
�������
�������
������ $	����6�   $��Segoe UI Symbol)�6�   $
��Left=�6�   �� 51   
   $��1��6   $��0��6   ��6-   �� *	Album.Art+� 52   
   $��1��6   $��1��6    53      �� 54      $
��Auto �6    �� 55      $
��Auto �6    �� 56      $
��Auto �6    �� 57      $
��Auto �6     59      �� 5:      $
��Auto �6#   �� 5;      $
��Auto �6#   �� 5<      $��* �6#   .+�5@      �� $��48(�65   $��Segoe UI Light)�6C   $��Light"�6_   $��3��6r   ��6   �� *
Album.Name+6r   �� 5A      $��36(�6:   $��1��6H   $��Segoe UI Light)�6U   $��Light"�6q   $��3��6�   ��6   �� *Album.ArtistName+6�   �� 5B      $��36(�64   $��2��6B   $��Segoe UI Light)�6O   $��Light"�6k   $��3��6~   ��6   �� *
Album.Year+6~   �� 5C      $��3��6   $��5,0,0,0q�6"   $�� - Play Album��63   $��Segoe UI Symbol)�6S   ��6p   �� *PlayAlbumCommand+�� 5D      $��3��6   $��5,0,0,0q�6#   $��1��64   $�� - Queue Album��6D   $��Segoe UI Symbol)�6e   ��6�   �� *QueueAlbumCommand+5E      �� 5H   
   
���   �$��2��6%   $��2��62   ._�5I      �� -   5        $��listView��5I      
������ #��[ 6f   $��0,0,0,0q�6�   
������ ��6'   �� *Album.Songs+��5J      �� 5K      	 �� 
TargetType"	 ��6   .�5L      �� 
 �� Property
 � �� �� Value$ Stretch=�6G   5M      5P      5Q      5T      5U      