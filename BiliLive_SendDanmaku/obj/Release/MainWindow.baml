   M S B A M L   `   `   `  ����   BiliLive_SendDanmaku%    BiliLive_SendDanmaku.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  	发弹幕��$��42��$	��320�� � AllowsTransparency .  � WindowStyle$
 None=����	#667F7F7F � ShowInTaskbar .   � 
ResizeMode$ NoResize=� � Topmost . .��� .+��� -    ��Name$ DanmakuTextBox��$��22�� �� TextWrapping$
 Wrap=�$	��Top=�$��
31,10,10,0q� �� SelectionBrush �	#99FF33FF$��0,0,0,2q����	#997F7F7F���	#CCFFFFFF	 �� 	MaxLength$	 20����Z� .��
 J� Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 2Q�   ShadowDepth$ 1Q�   RenderingBias$ Quality=�.���� -    ��Name$ 
SendButton��$��发送��$��Right=�$��	0,10,10,0q�$	��Top=�   CommonButtonStyle#���   ���	#99FFFFFF K� ZIndex$ 1��$��30����Z� 
   $ 2Q�$ 1Q�$ Quality=��� -   $ CloseButton��$��×��$
��Left=�$	��Top=�$��21��#���   $��23(�$��27��$��0q�$��0,-6,0,0q�$��0q�$��Center=�$��Center=��� -   $ SettingButton��$	��设��$
��Left=�$��0,21,0,0q�$	��Top=�$��21��#���   $��21��$��0q�$��0q�