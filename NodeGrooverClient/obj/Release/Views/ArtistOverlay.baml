   M S B A M L   `   `   `  ���� L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  +    %NodeGrooverClient.Views.ArtistOverlay   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     G CFramework.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'extrahttp://schemas.extra.com/ui  Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  7params*http://schemas.codeplex.com/elysium/params  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  :d2http://schemas.microsoft.com/expression/blend/2008  .cv%clr-namespace:NodeGrooverClient.Views    Elysium.Parameters.Design    Theme$
  DarkX�   Elysium.Parameters.Manager   Theme$
 DarkX� � 	Resources 1   +NodeGrooverClient.Views.VisibilityConverter   VisibilityConverter  searchItemTemplate  
FadeInGrid � ColumnDefinitions � RowDefinitions$  Elysium.Controls.CommandButton  FadeInButton �� Path �� RelativeSource �� AncestorType �� 	Converter)  #Framework.UI.Controls.OverlayWindow  albumItemTemplate  FadeInCanvas
	 �� Top
 �� Left  FadeInImage �� Bottom J� Opacity �� 
TargetType �� Triggers P� Property P� Value N� EnterActions  FadeInTrans
 � Tag��%�  &	        &	      7  7  7   7  7   &	 �    7  7  7   7    �� .R�� $��Stretch=�8��   �� $��6* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��WordEllipsis=�$��0��$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��1��$��0��$��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *Artist+  8�� $	����$��Segoe UI Symbol)�$��1��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8  ���� $ DataContext.PlayCommand� �� "  ���� *Id+  8�� $	����$��Segoe UI Symbol)�$��2��$��2��$��Right=�y��� $ IsMouseOver� �� " ��8  ���� $ DataContext.QueueCommand� �� "  ���� *Id+�� .R�� .+��� $	��200��$	��200��8��  .+��� $	 0��$
 0��$	��200��$	��200��8�� ���� *Art+�� $ 0��$
 0��$
 0.65Q�$	��200��$��75��
���   �.+��� $��WordEllipsis=�$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *
ArtistName+�� $��WordEllipsis=�$��13(�$��Segoe UI Light)�$��Light"�
����������� *Year+�� $	��200��$	��125��$	��Top=�
���   �$ 0Q�$��5��y��� $ IsMouseOver� �� " ��8  ���� " �� P�  � y�$ Visible=� �� 8�� ._��� .+�� $	��200��$	��125��$	��Top=�$��Center=� �� $��* ��� $��* �.+�  $��50��$��50��$��Center=�$��22(�$��Segoe UI Symbol)�$	����
������ ���� $" DataContext.PlayAlbumCommand� �� " >����� *Id+  -   $��50��$��50��$��Center=�$��22(�$��1��$	����$��Segoe UI Symbol)�
������  �� *Id+.��� $	��600��
���   � �� $��* ��� $��5* ��� $��8* � �� $��6* ��� $	��12* �.+�  -   $��5,5,0,0q�
�������
�������
������ $	����$��Segoe UI Symbol)�$
��Left=��� $��1��$��0������ *
Artist.Art+� $��1��$��1�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��48(�$��Segoe UI Light)�$��Light"�$��3������ *Artist.Name+�� 
���   �$��2��$��2��._��� -   $��listView��
������ #��[ $��0,0,0,0q�
������ ���� *Arist.TopTracks+���� " ��.���  �� Property � �� �� Value$ Stretch=�