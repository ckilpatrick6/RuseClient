   M S B A M L   `   `   `  ����   NodeGrooverClient"    NodeGrooverClient.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Q MElysium, Version=2.0.1042.2, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  7params*http://schemas.codeplex.com/elysium/params     Elysium.Parameters.Manager    Theme$
  DarkX�  Elysium.AccentBrushes   Blue   AccentBrush# Z    ContrastBrush$ White�� � Title$ Ruse 0.1��$	��768��$
��1024�� � 
ResizeMode$ CanMinimize=� � 	Resources    searchItemTemplate � ColumnDefinitions � RowDefinitions$  Elysium.Controls.CommandButton
	 � Tag��%�  &	        �� .R�� $
��1000�� �� $��6* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��WordEllipsis=�$��24(�$��Segoe UI Light)�$��Light"�
����������� *Name+�� $��1��$��WordEllipsis=�$��16(�$��Segoe UI Light)�$��Light"�
����������� *
ArtistName+  -   $	����$��Segoe UI Symbol)�$��1��$��2��$��Center=�	 �� *Count+  -   $	����$��Segoe UI Symbol)�$��2��$��2��$��Center=�	 �� *Count+.���  �� $��2* ��� $��* ��� $��8* ��� $��2* � �� $��9* ��� $��* �.+�"  Elysium.Controls.ProgressBar  -   $��progressBar��$��10��$	��Top=�$��2��.  (Elysium.Controls.Primitives.ProgressBase
   State$

 Busy=�$y�	Collapsed=��� -   $��	searchBox��$��1���� -   $��1��$��2��$��18(�
������ $��Segoe UI Symbol)�$	������ -   $��listView��$��2��$��2��#��[  $��
10,0,-10,0q���Z� � $��3��$��2�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��4* � �� $��* ��� $��* �.+�  -   $��
PrevButton��$��Segoe UI Symbol)�$��30(�$	����$��
20,6,20,10q�$��0��$��2��  -   $��PauseButton��$��Segoe UI Symbol)�$��30(�$	����$��20,10,20,10q�$��1��$��2��  -	   $��
NextButton��$��Segoe UI Symbol)�$��30(�$	����$��20,10,20,10q�$��2��$��2��  -
   $��SongScrubber��$��1��$��4��$��40��$��	50,0,50,0q��� -   $��songTimeBlock��$��1��$��4��$��Center=�$��5,-2,0,0q��� -   $��songMaxBlock��$��1��$��4��$��Center=�$��Right=�$��0,-2,5,0q��� -   $��nowPlayingBlock��$��4��$��Center=�$
��Left=�$��50,0,0,0q�$��24(�$��Segoe Ui Light)�$��Light"�$��
Song Title���� -   $��VolumeSlider��$��
0,10,20,10q�$��3��$��Right=�$��2�� �� Orientation$ Vertical=� � Maximum$	 100Q��� $��3��$	����$��24(�$��30,0,0,0q�$��Center=�$��Segoe UI Symbol)��� -   $��VolumeLabel��$��3��$��1��$�� �� �� TextAlignment$ Center=�$��Center=�$��	-40,0,0,0q�$��24(�  Elysium.Controls.Window   ApplicationBar %  Elysium.Controls.ApplicationBar     IsOpen . 