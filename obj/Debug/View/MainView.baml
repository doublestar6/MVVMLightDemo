   M S B A M L   `   `   `  ����H  DMVVMLightDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MVVMLightDemo.ViewMVVMLightDemo.View  5   	   !    MVVMLightDemo.View.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MVVMLightDemo.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  68     � Title$  MainView��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $	��UI1��6   ��6#   �� *
UI1Command+�� 5      $	��UI2��6   ��6#   �� *
UI2Command+5      �� 5   
   $��0��6   $��1��6$   $��5��64   $
��Left=�6>   $��Stretch=�6Y   ���	#FFC1BDC5$��2��6�   � 5   
   $��1��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $	��100 �6    .+�5      �� $��5��6   $��0��6&   $��1��63   ���	#FFC1BDC5$��Stretch=�6Z   $��Bottom=�6x   �� 5      $��0��6   
�������$��1q�68   ._�5      �� $	��5,0q�6@   ��6$   �� *	Content+6@   5      �� 5      $��1��6   
�������$��1q�67   ._�5      �� -   5         ��Name$ 
LogTextBox��5      " �� VerticalScrollBarVisibility$
 Auto=�6G   $ �� HorizontalScrollBarVisibility$
 Auto=�6j   ��6.   �� *	TextLog+.��6�   .  (System.Windows.Interactivity.Interaction   Triggers 5       /  )System.Windows.Interactivity.EventTrigger  5!         	EventName$ Loaded��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5"      6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 64   �� 
 �� Path$
 TextBoxLoadedCommand�   CommandParameter 5#   $   ��  �� ElementName$ 
LogTextBox��5$      5%      .��5&   .   5'      5(      5)      5*      5+      