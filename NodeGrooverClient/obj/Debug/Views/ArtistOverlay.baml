   M S B A M L   `   `   `  ����L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  5	      +    %NodeGrooverClient.Views.ArtistOverlay   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      G CFramework.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'extrahttp://schemas.extra.com/ui  5      Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  5      7params*http://schemas.codeplex.com/elysium/params  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      .cv%clr-namespace:NodeGrooverClient.Views  5	        Elysium.Parameters.Design    Theme$
  DarkX�5         Elysium.Parameters.Manager   Theme$
 DarkX�5       � 	Resources 5      1   +NodeGrooverClient.Views.VisibilityConverter   VisibilityConverter  searchItemTemplate  
FadeInGrid � ColumnDefinitions � RowDefinitions$  Elysium.Controls.CommandButton  FadeInButton �� Path �� RelativeSource �� AncestorType �� 	Converter)  #Framework.UI.Controls.OverlayWindow  albumItemTemplate  FadeInCanvas
	 �� Top
 �� Left  FadeInImage �� Bottom J� Opacity �� 
TargetType �� Triggers P� Property P� Value N� EnterActions  FadeInTrans
 � Tag��%�
  &	        &	      7  7  7   7  7   &	     7  7  7   7    5   
   6!   �� 5   
   .R�5      � $��Stretch=�6   8��   5      �� 5      $��6* �6'   �� 5      $��* �6'   �� 5      $��* �6'    5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $��WordEllipsis=�62   $��0��6N   $��24(�6^   $��Segoe UI Light)�6l   $��Light"�6�   
���������6   �� *Name+6�   �� 5      $��1��65   $��0��6B   $��WordEllipsis=�6R   $��16(�6n   $��Segoe UI Light)�6|   $��Light"�6�   
���������6   �� *Artist+6�     5      8�� $	����6L   $��Segoe UI Symbol)�6�   $��1��6  $��2��6)  $��Right=�6:  y�6`   �� $ IsMouseOver� �� " ��8  ��6V  �� $ DataContext.PlayCommand� �� "  ��6�  �� *Id+  5      8�� $	����6L   $��Segoe UI Symbol)�6�   $��2��6  $��2��6(  $��Right=�69  y�6_   �� $ IsMouseOver� �� " ��8  ��6U  �� $ DataContext.QueueCommand� �� "  ��6�  �� *Id+5       5!      �� 5"   
   .R�5#      � .+�5%      �� $	��200��6   $	��200��6%   8��  .+�5&      �� $	 0��63   $
 0��6B   $	��200��6R   $	��200��6^   8�� ��6   �� *Art+6k   �� 5'      $ 0��6!   $
 0��63   $
 0.65Q�6C   $	��200��6R   $��75��6^   
���   �.+�5(      �� $��WordEllipsis=�6:   $��24(�6V   $��Segoe UI Light)�6d   $��Light"�6�   
���������6$   �� *Name+6�   �� 5)      $��WordEllipsis=�6@   $��16(�6\   $��Segoe UI Light)�6j   $��Light"�6�   
���������6$   �� *
ArtistName+6�   �� 5*      $��WordEllipsis=�6:   $��13(�6V   $��Segoe UI Light)�6d   $��Light"�6�   
���������6$   �� *Year+6�   5+      5,      �� 5-      $	��200��6   $	��125��6%   $	��Top=�62   
���   �$ 0Q�6�   $��5��6  y�6J   �� $ IsMouseOver� �� " ��8  ��5.      �� 5/      " ��6     50      P� 51   "    � y�$ Visible=�6@    52   &   �� 53   *   8�� 6:   55   #   57      ._�59      �� .+�5:      � $	��200��6   $	��125��6+   $	��Top=�68   $��Center=�6P    5;      �� 5<   "   $��* �63   �� 5=   "   $��* �63   .+�5?        $��50��62   $��50��6=   $��Center=�6I   $��22(�6d   $��Segoe UI Symbol)�6r   $	����6�   
������ ��6�   �� $" DataContext.PlayAlbumCommand� �� " >���66  �� *Id+  5@      -   5        $��50��5@   2   $��50��6=   $��Center=�6J   $��22(�6e   $��1��6s   $	����6�   $��Segoe UI Symbol)�6�   
������  6�   �� *Id+6�   5A      5C      5D      5E      5F      5H      .��5J      � $	��600��6   
���   � 5K   
   �� 5L      $��* �6   �� 5M      $��4* �6   �� 5N      $��4* �6   �� 5O      $��4* �6    5Q   
   �� 5R      $��6* �6   �� 5S      $	��12* �6   .+�5V   
     -   5        $��5,5,0,0q�5V      
�������
�������
������ $	����6�   $��Segoe UI Symbol)�6�   $
��Left=�6�   �� 5W   
   $��1��6   $��0��6   ��6-   �� *
Artist.Art+� 5X   
   $��1��6   $��1��6    5Y      �� 5Z      $
��Auto �6    �� 5[      $
��Auto �6    �� 5\      $
��Auto �6    �� 5]      $
��Auto �6     5_      �� 5`      $
��Auto �6#   �� 5a      $
��Auto �6#   �� 5b      $��* �6#   .+�5f      �� $��48(�66   $��Segoe UI Light)�6D   $��Light"�6`   $��3��6s   ��6   �� *Artist.Name+6s   5g      �� 5j   
   
���   �$��2��6%   $��2��62   ._�5k      �� -   5        $��listView��5k      
������ #��[ 6k   $��0,0,0,0q�6�   
������ ��6'   �� *Artist.TopTracks+��5l      �� 5m      " ��6   .�5n      ��  �� Property � �� �� Value$ Stretch=�6G   5o      5r      5s      �� 5u   
   
���   �$��3��6%   $��2��62   ._�5v      �� -   5        $��	listView2��5v      
������ #��[ 6i   $��0,0,0,0q�6�   
������ ��6(   �� *Artist.Albums+��5w      �� 5x      " ��6   .�5y      ��  � ��$ Stretch=�6G   5z      ��5|      �� 5}      .R�5~      � ��6$   �� * (FrameworkElement.ActualWidth)+ �� $ ScrollContentPresenterL� � 	ItemWidth 5�      �� *(ListView.View).ItemWidth+ �� $ ListViewL���5�      �� *	ItemWidth+ �� *Self+ � 
ItemHeight 5�      �� *(ListView.View).ItemHeight+ �� $ ListViewL�5�      5�      5�      5�      5�      