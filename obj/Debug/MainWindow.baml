   M S B A M L   `   `   `  ����B  >QuizApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QuizAppQuizApp  5   	       QuizApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QuizApp     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��600��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%T   '��       �� 5
   
   " ��6   .�5      ��  � ��$
 5, 2q�6'   5      5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   .+�5   
   �� -   5        $��questionApp��5      $��Center=�5      $��Center=�5      $��20(�5      $��Black"�5      
��� � �$
��Wrap=�5       �� TextAlignment$ Center=�5      
Question !5       �� 5!   
   -   5        $��
answerApp1��5#      $��Black"�5$      $��15(�5%      $��1��5&      $	��200��5'      $
��Left=�5(      
�������
�������.��5*   !   
A ) Test5,      �� 5-   
   -   5        $��
answerApp2��5/      $��2��50      $��Black"�51      $��15(�52      $	��200��53      $
��Left=�54      
�������
�������.��56   !   
A ) Test58      �� 59   
   -   5        $��
answerApp3��5;      $��3��5<      $��Black"�5=      $��15(�5>      $	��200��5?      $
��Left=�5@      
�������
�������.��5B   !   
A ) Test5D      �� 5E   
   -   5        $��
answerApp4��5G      $��4��5H      $��Black"�5I      $��15(�5J      $	��200��5K      $
��Left=�5L      
�������
�������.��5N   !   
A ) Test5P      �� 5Q   
   -   5        $��	scoreView��5R      $ Right=�5S       �� Padding$ 8q�5T      $��Black"�5U      05W      5X      5Y      