   M S B A M L   `   `   `  ����  
TestClient     TestClient.Dovidnik_Posadi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  Dovidnik_Posadi��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��1* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   o� $��2��6   .@�5      m� -   5        
��� � �
������� m� Icon 5      �� 5      $;��5C:\Users\Vladislav\Desktop\vladislav\project\data.png��6   ��5      �� 5      $��Database��6    $��0,2,0,0q�60   .@�5      m� -   5        $
��p_ch��5   4   $��Change DataBase��6   
��� � �
���   �6S   m� 5      -   5        $��Add data for verification��5      
��� � �
���   �6o   m� 5      -   5        $&�� Delete DataBase and close window��5      
��� � �
���   �6y   5      m� 5      -   5        
��� ���
������� 5       �� 5!      $;��5C:\Users\Vladislav\Desktop\vladislav\project\save.png��6   ��5#      �� 5$      $��Save change to DataBase��6    $��0,2,0,0q�6?   5&      5'      &   System.Windows.Controls.DataGrid  5(   
   -   5        $��	dg_groups��5(      $��5q�6      AutoGenerateColumns .  $��1��6K   $��2��6X      Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ Name position��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *name+  5,      $ Name ��6%    64   �� *name_surname+5/      51      52      