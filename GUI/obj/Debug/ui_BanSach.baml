   M S B A M L   `   `   `  ����U  QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf  5      > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI 5         GUI.ui_BanSach   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5      #localclr-namespace:GUI     5      $��678.902��5      $��512.711��6/   .��5
      � ��5   
   �� 5        �� EndPoint$  0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFF3F1F1��6   � 5      $ 	#FFF5F1F1��6    � Offset$ 1Q�61   5      .+�5   
   �� $
��Left=�6   $��	43,34,0,0q�6/   $
��Wrap=�6B   $��Ngày lập hóa đơn: ��6V   $	��Top=�6p   �� 5   
   -   5         ��Name$ txbNgayLapHoaDon��5      $
��Left=�6,    �� TextAlignment$ Center=�6G   )   #MaterialDesignThemes.Wpf.HintAssist   Hint$         04.05.2017��6^   $��23��6�   $��
234,30,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��
424,34,0,0q�6/   $
��Wrap=�6C   $��Mã KH:��6W   $	��Top=�6e   �� 5   
   -   5        $��cbbMaKH��5      $��Center=�6"    �� 
IsEditable . $ Chọn mã khách hàng��6V   $��496,28,63,457q�6   �� 5   
   $
��Left=�6   $��	43,69,0,0q�6/   $
��Wrap=�6B   $��Tên KH:��6V   $	��Top=�6e   �� 5   
   -   5        $ txbTenKH��5      $
��Left=�6$   {�.  $ Center=�6Q   $��23��6h   $��
234,65,0,0q�6t   $
 Wrap=�6�      MaterialDesignTextBox#��[  6�   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��
424,69,0,0q�6/   $
��Wrap=�6C   $��Tiền nợ:��6W   $	��Top=�6g   �� 5   
   -   5        $ 	txbTienNo��5      $
��Left=�6%   $ Center=�6@   {�.  $��23��6i   $��
496,65,0,0q�6u   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��
43,148,0,0q�6/   $
��Wrap=�6C   $5��/Số lượng tồn tối thiểu sau khi bán:��6W   $	��Top=�6�   �� 5   
   $��20��6   $��265,143,370,340q�6   �� 5   
   $
��Left=�6   $��424,148,0,0q�6/   $
��Wrap=�6D   $!��Số tiền nợ tối đa:��6X   $	��Top=�6r   �� 5   
   $��20,000��6   $��537,143,63,340q�6!   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 
dtgBanSach��5      
   AutoGenerateColumns
 .  $
��Left=�6C   $	��221��6^   $��
18,238,0,0q�6k   $	��Top=�6   $	��643��6�      
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *STT+  5       $ 	Mã sách��6%    66   �� *MaSach+  5!      $ 
Tên sách��6%    67   �� *	TenSach+  5"      $ Số lượng bán��6%    6;   �� *
SoLuongBan+  5#      $&  Số lượng tồn sau khi bán��6%    6G   �� *SoLuongTonSauKhiBan+  5$      $ 
Đơn giá��6%    66   �� *DonGia+  5%      $ Thành tiền��6%    69   �� *	ThanhTien+5'      �� 5(   
   -   5         ��Name$ 
btnXacNhan��5(      $��Thêm vào danh sách��6%   $
��Left=�6B   $��103,172,0,0q�6]   $	��Top=�6r   $
��Auto��6�   �� 5)   
   $
��Left=�6   $��
43,106,0,0q�6/   $
��Wrap=�6C   $��
Mã sách:��6W   $	��Top=�6g   �� 5*   
   $
��Left=�6   $��424,106,0,0q�6/   $
��Wrap=�6D   $��Số lượng:��6X   $	��Top=�6i   �� 5+   
   -   5        $ txbSoLuongBan��5+      $
��Left=�6)   $ Center=�6D   $��23��6[   $��496,102,0,0q�6g   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5,   
   -   5         ��Name$ cbbMaSachBan��5,       . $��Center=�6;   $ Chọn mã sách��6]   $��234,100,325,385q�6�   �� 5-   
   $
��Left=�6   $��
18,215,0,0q�6/   $
��Wrap=�6C   $!��Danh sách các sách bán:��6W   $	��Top=�6v   �� 5.   
   -	   5        $ btnXoaSachVuaBan��5.      $��Xóa sách vừa bán��6+   $
��Left=�6F   $��392,172,0,0q�6a   $	��Top=�6v   $	��159��6�   6�   �� 5/   
   $��Tổng tiền:��6   $
��Left=�6%   $��
57,469,0,0q�6@   $	��Top=�6T   �� 50   
   -
   5         ��Name$ lblTongTien��50      $
��0 đ��6%   $
��Left=�63   $��130,469,0,0q�6N   $	��Top=�6c   �� 51   
   -   5        $ btnHoanThanh��51      $��Hoàn thành��6'   $
��Left=�6<   $��444,469,0,0q�6W   $	��Top=�6l   $
��Auto��6�   53      54      