   M S B A M L   `   `   `  ���� L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  *    $NodeGrooverClient.Views.AlbumOverlay   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     G CFramework.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'extrahttp://schemas.extra.com/ui  Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  7params*http://schemas.codeplex.com/elysium/params  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  :d2http://schemas.microsoft.com/expression/blend/2008  .cv%clr-namespace:NodeGrooverClient.Views    Elysium.Parameters.Design    Theme$
  DarkX�   Elysium.Parameters.Manager   Theme$
 DarkX� � 	Resources 1   +NodeGrooverClient.Views.VisibilityConverter   VisibilityConverter  searchItemTemplate  
FadeInGrid � ColumnDefinitions � RowDefinitions$  Elysium.Controls.CommandButton  FadeInButton �� Path �� RelativeSource �� AncestorType �� 	Converter)  #Framework.UI.Controls.OverlayWindow��%�  &	        &	      7  7  7   7  7     �� .R�� $��Stretch=�8��   �� $��6* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��WordEllipsis=�$��0��$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��1��$��0��$��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *Artist+  8�� $	����$��Segoe UI Symbol)�$��1��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8  ���� $ DataContext.PlayCommand� �� "  ���� *Id+  8�� $	����$��Segoe UI Symbol)�$��2��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8  ���� $ DataContext.QueueCommand� �� "  ���� *Id+.��� $	��600��
���   � �� $��* ��� $��5* ��� $��8* � �� $��6* ��� $	��12* �.+�  -   $��5,5,0,0q�
�������
�������
������ $	����$��Segoe UI Symbol)�$
��Left=��� $��1��$��0������ *	Album.Art+� $��1��$��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��48(�$��Segoe UI Light)�$��Light"�$��3������ *
Album.Name+�� $��36(�$��1��$��Segoe UI Light)�$��Light"�$��3������ *Album.ArtistName+�� $��36(�$��2��$��Segoe UI Light)�$��Light"�$��3������ *
Album.Year+�� $��3��$��5,0,0,0q�$�� - Play Album��$��Segoe UI Symbol)����� *PlayAlbumCommand+�� $��3��$��5,0,0,0q�$��1��$�� - Queue Album��$��Segoe UI Symbol)����� *QueueAlbumCommand+�� 
���   �$��2��$��2��._��� -   $��listView��
������ #��[ $��0,0,0,0q�
������ ���� *Album.Songs+���� 	 �� 
TargetType"	 ��.��� 
 �� Property
 � �� �� Value$ Stretch=�