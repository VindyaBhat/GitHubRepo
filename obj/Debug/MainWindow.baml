   M S B A M L   `   `   `  ����L  HEnvironmentConfig, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EnvironmentConfigEnvironmentConfig  5   	   K*clr-namespace:EnvironmentConfig.ViewModelsEnvironmentConfig.ViewModels  5   	   "    EnvironmentConfig.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:EnvironmentConfig     5   	   A
viewModels*clr-namespace:EnvironmentConfig.ViewModels     5   	   $	��600��5      $	��750��6'     � WindowStartupLocation$  CenterScreen=�63    � 	Resources 5
         BoolToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �  5   
     	lineStyle �� 
TargetType �� Property �� Value  horizontalLineStyle �� BasedOn �� DataType>   8EnvironmentConfig.ViewModels.EnvironmentOptionsViewModel5   /EnvironmentConfig.EnvironmentOptionsUserControl=   7EnvironmentConfig.ViewModels.InstrumentOptionsViewModel4   .EnvironmentConfig.InstrumentOptionsUserControl��%�  &	       &	 �     7  (��     5      *, +)(�� M    5      *, +)�� 5      " ��6&   .�5      ��  � ��
 �����6+   �� 5       �@��Stretch$
 Fill=�6,   �� 5       �@K�ZIndex$	 100��60   5      �� 5      " ��60   8   .�5      �� 
 �@��X2$ 1��6'   �� 5       � ��$ Bottom=�66   5      �� 5      "  6   .R�5        5      �� 5      "  6   .R�5        5      5        � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#      �� 5$      $
��Auto �6   .+�5&   
   � $��0��6   ���#224059.+�5'      �� $��0��6   $.��(Environment and Instrument Configuration��6!   $��Center=�6T   $
��Bold"�6q   $��20(�6�   
�������6�   5(      � 5)   
   $��1��6    � ColumnDefinitions 5*      �� 5+      $
��Auto �6#   �� 5,      $��* �6#   .+�5.      �� 
�������$	��0.5q�6(   ._�5/      � $��0��6   .+�50      �� ��6   �� *ListOfConfigurationSettings+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedItem 6�   �� *SelectedItem.Value+$	 TwoWay=�$
 PropertyChanged=���51      �� 52      " ��6$   .�53   "   ��  � ��$ 17(�6=   �� 54   "    � ��$ Stretch=�6H   �� 55   "    � ��
 �����6?   �� 56   "    � ��$ DemiBold"�6?   57      59      5:      5;      � 5<      $��1��6   .+�5=      �� ��6!   �� *CurrentViewModel+5>      5?      � 5@   
   $��2��6   .+�5A      �� #��[ 6   $	��Top=�6@   $��Stretch=�6X   �� 5B       �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Bottom=�6N   .+�5C      �� $��OK��6   $��50��6'   $��30��65   $��0,0,8,0q�6A   $��16(�5D   7   $��DemiBold"�6F   $��Roboto)�6\   ���#005CA9
���������6   �� *	OkCommand+ 5E      ��%^   '��       �� 5F      " ��6    .�5G      ��  �@��CornerRadius$ 5��6=   5H      5I      5J      �� 5K      $��Cancel��6   $��90��6*   $��30��68   $��10q�6D   $��16(�6P   $��DemiBold"�6�   ���#005CA9$��Roboto)�6�   
���������6^   �� *CancelCommand+ 5L      ��%^   '��       �� 5M      " ��6    .�5N      ��  �@��CornerRadius$ 5��6=   5O      5P      5Q      5R      5S      5T      5U      