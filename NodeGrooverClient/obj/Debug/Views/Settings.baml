   M S B A M L   `   `   `  ����L  HNodeGrooverClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:NodeGrooverClient.ViewsNodeGrooverClient.Views  5      I)clr-namespace:NodeGrooverClient.ViewModelNodeGrooverClient.ViewModel  5      &     NodeGrooverClient.Views.Settings   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5tab%clr-namespace:NodeGrooverClient.Views     5      8vm)clr-namespace:NodeGrooverClient.ViewModel     5         SettingsViewModel  � DataContext#  �   5
       � 	Resources 5      3   -NodeGrooverClient.ViewModel.SettingsViewModel  WhiteButton �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�   &	        &	        5   
   6   �� 5   
   " ��6$   .�5      ��  � ��
 �����6+    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �����63   �� 5       � ��
 ���� 63   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��3* �6   �� 5#      $	��100 �6   	 � ColumnDefinitions	 5%   
   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   .+�5-   
   �� $��Hostname��6   $��1��6$   
�������$��36(�6C   $��Center=�6R   $��Segoe UI Light)�6m   �� 5.   
   -   5        $��hostBox��5.   D   $��1��6   $��1��6   $��10,10,10,10q�6/   ��6S   �� *
Hostname+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5/   
   $
��Port��6   
�������$��36(�62   $��Center=�6@   $��2��6[   $��Segoe UI Light)�6h   �� 50   
   -   5        $��portBox��50   D   $��2��6   $��1��6   $��10,10,10,10q�6/   ��6S   �� *Port+$
 PropertyChanged=��� 51   
   $��3��6   $��2��6   $��10,10,10,10q�6.   $
��Save��6C   $��30(�6R   $	��Top=�6`   $��Segoe UI Light)�6�   
������ ��6   �� *SaveCommand+6�   52      53      