   M S B A M L   `   `   `  ���� L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:NodeGrooverClient.NetNodeGrooverClient.Net  A%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  A%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  K*clr-namespace:NodeGrooverClient.PropertiesNodeGrooverClient.Properties      NodeGrooverClient.App   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5local#clr-namespace:NodeGrooverClient.Net     7views%clr-namespace:NodeGrooverClient.Views     Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  7params*http://schemas.codeplex.com/elysium/params  .cv%clr-namespace:NodeGrooverClient.Views  ;
properties*clr-namespace:NodeGrooverClient.Properties    �� 	Resources   �� MergedDictionaries �� Source1   +NodeGrooverClient.Views.VisibilityConverter   Key+  %NodeGrooverClient.Properties.Settings �� 
TargetType �� Property �� Value T� X T� Y �� 
TargetType'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   States   System.Windows.VisualState   
Storyboard g� Duration	 �� To �� TargetProperty �� 
TargetName ��Name  GroupHeaderTextStyle W� From	 W� To �� Triggers :� RoutedEvent 
 FadeIn P� Property P� Value$  Elysium.Controls.CommandButton N� ExitActions  FadeOut N� EnterActions��  �� $1 +/Framework.UI;component/Themes/Generic.xaml?���   VisibilityConverter    Settings  �� GroupHeaderTextStyle  " ��.���  � ��$ Segoe UI Light)���  � ��$ WordEllipsis=���  � ��$ NoWrap=���  �@K�StylisticSet20 . ��  �@K�DiscretionaryLigatures . ��  �@K�CaseSensitiveForms . ��  � ��$ 36(���  �@��LineStackingStrategy$ BlockLineHeight=���  � ��$ Light"���  �@��
LineHeight$ 30����  � z� T� $ -1Q�$ 6Q��� TabRadioButtonStyle  " 	�.���  � �� �� " 	�.R�� 	   CheckStates��.
   	Unchecked��. �� .���� $ 0D�$
 GrayX�$4 .(TextBlock.Foreground).(SolidColorBrush.Color)�$ TabButtonText��  Indeterminate��. �� .���� $ 0D�$ WhiteX�$4 .(TextBlock.Foreground).(SolidColorBrush.Color)�$ TabButtonText��  Checked��. �� .���� $ 0D�$ WhiteX�$4 .(TextBlock.Foreground).(SolidColorBrush.Color)�$ TabButtonText��.+��� $ TabButtonText��#��z��#��[ $
��Left=��� 
FadeIn  .��W� $ Opacity�$ 0X�$ 1X�$ 0:0:.3D��� FadeOut  .��W� $ Opacity�$ 1X�$ 0X�$ 0:0:.3D��� FadeInTrans  .��W� $ Opacity�$ 0X�$
 0.75X�$ 0:0:.3D��� FadeOutTrans  .��W� $ Opacity�$
 0.75X�$ 0X�$ 0:0:.3D��� " �
FadeInGrid   :� $ FrameworkElement.Loaded��.[��� #��[ �� " ��FadeInCanvas   :� $ FrameworkElement.Loaded��.[��� #��[ �� WhiteButton  " ��.���  � ��
 ����� P�  � �� . . ���  � ��
 �   ���  � ��
 ������� " ��FadeInImage   :� $ FrameworkElement.Loaded��.[��� #��[ �� "  FadeInButton  .���  � ��
 ���� ��  � ��
 �������  � ��
 ����� P�  � y�$ Visible=� �� #��[  �� #��[ P�  � �� . . ���  � ��
 �������  � ��
 �   ��� $ Simple Styles.xaml?�%(   '�       '��       '��       '        