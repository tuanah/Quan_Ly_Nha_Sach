   M S B A M L   `   `   `  ����U  QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5   	   > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI 5   	      GUI.LapPhieuNhapSach   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5   	   FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   localclr-namespace:GUI   5   	   -   5        $��402.732��5
      $��690.81��6+   $��14(�6:     � 
ResizeMode$  NoResize=�6H    � WindowStartupLocation$ CenterScreen=�6^    � Title$ Nhập sách��6�   ��.     MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      ���	#FFFAFAFA  MaterialDesignFont#���  5      .��5      � $	��375��6   $	��685��6   $��0,1,0,-2q�6$   .+�5   
   �� $��Số Lượng Nhập:��6   $
��Left=�6)   $��	24,74,0,0q�6D   $	��Top=�6W   $��Calibri)�6o   $��14(�6�   �� 5   
   -   5         ��Name$ txbSoLuongNhap��5      $
��Left=�6*   $��23��6E   $��
130,74,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $��76��6�   $��Calibri)�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgNhapSach��5         CanUserAddRows . $
��Left=�6>   $	��178��6Y   $��
24,162,0,0q�6f   $	��Top=�6z   $	��634��6�   	   RowDetailsVisibilityMode$	 Visible=�6�   
   AutoGenerateColumns
 .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *STT+6J     5      $ 	Mã Sách��6%    66   �� *MaSach+  5      $ 
Tên Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 67    .  6C   �� *	TenSach+6_     5      $ 
Tác Giả��6%   $	 120 66    .  6B   �� *TacGia+6]     5      $ Số Lượng Tồn Cũ��6%    .  6>   �� *SoLuongTonCu+6_     5      $ Số Lượng Nhập��6%    6<   �� *SoLuongNhap+  5      $ Số Lượng Tồn Mới��6%    .  6?   �� *SoLuongTonMoi+6a   5!      �� 5"   
   $�� ��6   $
��Left=�6   $��
238,25,0,0q�66   $	��Top=�6J   �� 5#   
   $-��'Số lượng nhập tối thiểu: 150��6   $
��Left=�67   $��
424,77,0,0q�6R   $	��Top=�6f   $��Calibri)�6~   $��14(�6�   �� 5$   
   $<��6Số lượng tồn tối đa trước khi nhập: 300��6   $
��Left=�6B   $��
424,25,0,0q�6]   $	��Top=�6q    J� RenderTransformOrigin$ 0.61,-0.006&�6�   $��Calibri)�6�   $��14(�6�   �� 5%   
   -   5         ��Name$ btnNhap��5%      $��Nhập��6"   $
��Left=�61   $��
276,77,0,0q�6L   $	��Top=�6`   $��90��6x   �� 5&   
   $��
Mã Sách:��6   $
��Left=�6#   $��	24,25,0,0q�6>   $	��Top=�6Q   �� 5'   
   -   5        $ 	txbMaSach��5'      )   #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Mã Sách��6%    �� TextAlignment$ Center=�6C   $
��Left=�6Z   $��23��6u   $��	91,25,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��115��6�   �� 5(   
   $��Ngày Nhập��6   $
��Left=�6$   $��
222,29,0,0q�6?   $	��Top=�6S   �� 5)   
   -   5        $ txbNgayNhap��5)      $
��Left=�6'   $��23��6B   $��
299,30,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��108��6�   �� 5*   
   $(��"Danh sách các sách đã nhập:��6   $
��Left=�66   $��
24,121,0,0q�6Q   $	��Top=�6e   �� 5+   
   $
��Left=�6   $ asdasdsd��6.   $��396,119,0,0q�6M   $	��Top=�6b   $	��120��6z   .@�5,      �� .��6   	asdasds6$   �� 5-      .��6   	asdasds6$   �� 5.      .��6   	asdasds6$   �� 5/      .��6   	asdasds6$   �� 50      .��6   	asdasds6$   51      54      55      