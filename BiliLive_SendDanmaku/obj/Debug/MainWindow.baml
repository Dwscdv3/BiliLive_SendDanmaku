   M S B A M L   `   `   `  ����  BiliLive_SendDanmaku%    BiliLive_SendDanmaku.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  	发弹幕��5   	   $��42��6   $	��320��6!    � AllowsTransparency .  � WindowStyle$
 None=�6G   ���	#667F7F7F � ShowInTaskbar .   � 
ResizeMode$ NoResize=�6�    � Topmost . .��5      � .+�5   
   �� -   5         ��Name$ DanmakuTextBox��5      $��22��6*    �� TextWrapping$
 Wrap=�66   $	��Top=�6J   $��
31,10,10,0q�6b    �� SelectionBrush �	#99FF33FF$��0,0,0,2q�6�   ���	#997F7F7F���	#CCFFFFFF	 �� 	MaxLength$	 20��6�   ��6�   Z� .��6   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 2Q�6#      ShadowDepth$ 1Q�62      RenderingBias$ Quality=�6B   .��5	      5
      �� 5   
   -   5         ��Name$ 
SendButton��5      $��发送��6%   $��Right=�62   $��	0,10,10,0q�6N   $	��Top=�6a      CommonButtonStyle#���   6y   ���	#99FFFFFF K� ZIndex$ 1��6�   $��30��6�   ��6�   Z� 
 5        5      $ 2Q�6#   $ 1Q�62   $ Quality=�6B   5      �� 5   
   -   5        $ CloseButton��5      $��×��6&   $
��Left=�62   $	��Top=�6M   $��21��6e   #���   6p   $��23(�6�   $��27��6�   $��0q�6�   $��0,-6,0,0q�6�   $��0q�6�   $��Center=�6  $��Center=�6&  �� 5   
   -   5        $ SettingButton��5      $	��设��6(   $
��Left=�64   $��0,21,0,0q�6O   $	��Top=�6a   $��21��6y   #���   6�   $��21��6�   $��0q�6�   $��0q�6�   6�   5      5      