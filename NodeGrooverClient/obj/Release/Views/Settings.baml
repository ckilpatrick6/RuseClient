   M S B A M L   `   `   `  ���� L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  I)clr-namespace:NodeGrooverClient.ViewModelNodeGrooverClient.ViewModel  &     NodeGrooverClient.Views.Settings   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5tab%clr-namespace:NodeGrooverClient.Views     8vm)clr-namespace:NodeGrooverClient.ViewModel        SettingsViewModel  � DataContext#  �    � 	Resources 3   -NodeGrooverClient.ViewModel.SettingsViewModel  WhiteButton �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   &	        &	        �� " ��.���  � ��
 ����� P�  �@J�IsMouseOver . . ���  � ��
 �������  � ��
 ���� .���  � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��3* ��� $	��100 �	 � ColumnDefinitions	 �� $��* ��� $��* ��� $��* �.+��� $��Hostname��$��1��
�������$��36(�$��Center=�$��Segoe UI Light)��� -   $��hostBox��$��1��$��1��$��10,10,10,10q����� *
Hostname+
 �� UpdateSourceTrigger$
 PropertyChanged=��� $
��Port��
�������$��36(�$��Center=�$��2��$��Segoe UI Light)��� -   $��portBox��$��2��$��1��$��10,10,10,10q����� *Port+$
 PropertyChanged=��� $��3��$��2��$��10,10,10,10q�$
��Save��$��30(�$	��Top=�$��Segoe UI Light)�
������ ���� *SaveCommand+