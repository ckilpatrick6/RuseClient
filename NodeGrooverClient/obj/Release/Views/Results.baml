   M S B A M L   `   `   `  ���� L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NodeGrooverClient.ViewModelNodeGrooverClient.ViewModel  A%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  %    NodeGrooverClient.Views.Results   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  G CFramework.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'extrahttp://schemas.extra.com/ui  2vm)clr-namespace:NodeGrooverClient.ViewModel  .cv%clr-namespace:NodeGrooverClient.Views     SearchViewModel  � DataContext#  �    � 	Resources 1   +NodeGrooverClient.ViewModel.SearchViewModel1   +NodeGrooverClient.Views.VisibilityConverter  VisibilityConverter  albumItemTemplate  FadeInCanvas
 �� Top �� Left  FadeInImage �� Bottom J� Opacity �� Path �� RelativeSource �� AncestorType	 �� 	Converter
 �� 
TargetType �� Triggers P� Property P� Value N� EnterActions  FadeInTrans � ColumnDefinitions$  Elysium.Controls.CommandButton
 � Tag  artistItemTemplate  searchItemTemplate  
FadeInGrid � RowDefinitions 	 FadeInButton��%�	  &	        &	      &	 
     7  7  7  7  &	 �    7  7  7  7  &	 r    7  7 	 7  7 	 7      �� .R�� .+��� $	��200��$	��200��8��  .+��� $ 0��$ 0��$	��200��$	��200��8�� ���� *Art+�� $ 0��$ 0��$
 0.65Q�$	��200��$��75��
���   �.+��� $��WordEllipsis=�$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *
ArtistName+�� $��WordEllipsis=�$��13(�$��Segoe UI Light)�$��Light"�
����������� *Year+�� $	��200��$	��125��$	��Top=�
���   �$ 0Q�$��5��y��� $ IsMouseOver� �� " ��8	  ���� "
 �� P�  � y�$ Visible=� �� 8�� ._��� .+�� $	��200��$	��125��$	��Top=�$��Center=� �� $��* ��� $��* �.+�  $��50��$��50��$��Center=�$��22(�$��Segoe UI Symbol)�$	����
������ ���� $" DataContext.PlayAlbumCommand� �� " >����� *Id+  -   $��50��$��50��$��Center=�$��22(�$��1��$	����$��Segoe UI Symbol)�
������  �� *Id+�� .R�� .+��� $	��200��$	��112��8��  .+��� $ 0��$ 0��$	��200��$	��112��8�� ���� *Art+�� $ 0��$ 0��$
 0.65Q�$	��200��$��50��
���   �.+��� $��WordEllipsis=�$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $	��200��$��75��$	��Top=�
���   �$ 0Q�$��5��y��� $ IsMouseOver� �� " ��8	  ���� "
 �� P�  � y�$ Visible=� �� 8�� ._��� .+�� $	��200��$	��125��$	��Top=�$��Center=� �� $��* �.+�  -   $��50��$��50��$��Center=�$��22(�$��0��$	����$��Segoe UI Symbol)�
������  �� *Id+�� .R�� $��Stretch=�8��   �� $��6* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��WordEllipsis=�$��0��$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��1��$��0��$��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *Artist+  8�� $	����$��Segoe UI Symbol)�$��1��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8	  ���� $ DataContext.PlayCommand� �� " >����� *Id+  8�� $	����$��Segoe UI Symbol)�$��2��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8	  ���� $ DataContext.QueueCommand� �� " >����� *Id+.���  �� $��9* ��� $	��100 � �� $��55 ��� $��8* �.+�"  Elysium.Controls.ProgressBar  -   $��progressBar��$��10��$	��Top=�$��2��.  (Elysium.Controls.Primitives.ProgressBase   State$
 Busy=�$y�	Collapsed=��� -   $��	searchBox��$��0������ *Query+ �� UpdateSourceTrigger$ PropertyChanged=�.�� J� InputBindings �� 
 �� Key$ Enter�� �� Command �� *SearchCommand+.���� $��0��$��2��$��18(�$��Segoe UI Symbol)�$	�������� *SearchCommand+�� $��1��$��2��
������ .@��� $��Songs��
������ .���� -   $��listView��$��1��$��2��#��[ 
������ $��0,0,0,0q�
������ ���� *Results.Songs+���� "
 ��.���  �� Property � �� �� Value$ Stretch=��� $��Albums��
������ .���� -   $��	listView2��$��1��$��2��#��[ 
������ $��0,0,0,0q�
������ ���� *Results.Albums+���� "
 ��.���  � ��$ Stretch=����� .R�� ���� * (FrameworkElement.ActualWidth)+ �� $ ScrollContentPresenterL� � 	ItemWidth �� *(ListView.View).ItemWidth+ �� $ ListViewL����� *	ItemWidth+ �� *Self+ � 
ItemHeight �� *(ListView.View).ItemHeight+ �� $ ListViewL��� $��Artists��
������ .���� -   $��	listView3��$��1��$��2��#��[ 
������ $��0,0,0,0q�
������ ���� *Results.Artists+���� "
 ��.���  � ��$ Stretch=����� .R�� ���� * (FrameworkElement.ActualWidth)+ �� $ ScrollContentPresenterL� �� *(ListView.View).ItemWidth+ �� $ ListViewL����� *	ItemWidth+ �� *Self+ �� *(ListView.View).ItemHeight+ �� $ ListViewL�