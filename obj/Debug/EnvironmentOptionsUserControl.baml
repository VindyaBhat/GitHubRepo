   M S B A M L   `   `   `  ����L  HEnvironmentConfig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EnvironmentConfigEnvironmentConfig  5      5    /EnvironmentConfig.EnvironmentOptionsUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:EnvironmentConfig     5      .��5	      �   � 	Resources  5
   
      BoolToVisibilityConverter  	lineStyle �� 
TargetType �� Property �� Value  horizontalLineStyle �� BasedOn��%P  &	        &	      &	 �     7  �� 5      6+   �� 5      " ��6&   .�5      ��  � ��
 �����6+   �� 5       �@��Stretch$
 Fill=�6,   �� 5       �@K�ZIndex$	 100��60   5      �� 5      " ��60   8   .�5      �� 
 �@��X2$ 1��6'   �� 5       � ��$ Bottom=�66   5      5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   ��. ��6"   �� *Items+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6p   �� *'%SelectedEnvironmentOptionHolder.Value+$ TwoWay=�$ PropertyChanged=���5      �� 5      " ��6   .�5      ��  � ��$ 17(�61   �� 5       � ��$ Stretch=�6<   �� 5        � ��
 �����63   �� 5!       � ��$ DemiBold"�63   5"      5$      �� 5%   
   $��1��6   ��. ��6'   �� *ListOfOptions+��5&      �� 5'      .R�5(      ]� .+�5)      � $��5q�6    5*      �� 5+   "   $	��150 �63   �� 5,   "   $��* �63   .+�5.      �� $��0��6(   $��Roboto)�6Z   
�������$
��Left=�6�   $��14(�6�   $��5q�6�   ��68   �� *NameHolder.Value+6�   	� 5/      $��1��6*   	 	� 	GroupName$	 Toggle��6:   $��2q�6�   ���#005CA9$��5q�6�   
 d� 	IsChecked
 6M   �� *IsSelectedHolder.Value+$ TwoWay=�$ PropertyChanged=�6�   50      51      52      54      55      56      