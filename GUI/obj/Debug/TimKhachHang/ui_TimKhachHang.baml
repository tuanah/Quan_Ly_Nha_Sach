   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.ui_TimKhachHang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      $��577.302��5      $��339.683��6/   .��5      � .+�5	   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dtgTimKH��5	   �      
IsReadOnly . $ �� IsSynchronizedWithCurrentItem$
 TrueY�6K      AutoGenerateColumns .  $
��Left=�6�   $	��161��6�   $��
34,163,0,0q�6�   $	��Top=�6�   $	��503��6�      AreRowDetailsFrozen . ��6   �� *listKhachHang+   Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã KH��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *MaKhachHang+  5      $ Tên Khách Hàng��6%    6=   �� *HoTenKhachHang+  5      $ Địa Chỉ��6%    66   �� *DiaChi+  5      $ Điện Thoại��6%    69   �� *	DienThoai+  5      $ Email��6%    64   �� *Email+  5      $ Số Tiền Nợ��6%    69   �� *
SoTienNo+5      �� 5   
   $
��Left=�6   $��	57,26,0,0q�6/   $
��Wrap=�6B   $��Mã KH:��6V   $	��Top=�6d   �� 5   
   -   5         ��Name$ txbMaKhachHang��5      $
��Left=�6*   $��23��6E   $��
122,22,0,0q�6Q   	 �� TextWrapping$
	 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��	57,56,0,0q�6/   $
��Wrap=�6B   $��SĐT:��6V   $	��Top=�6b   �� 5   
   -   5        $ txbSDT��5      $
��Left=�6"   $��23��6=   $��
122,52,0,0q�6I   $
	 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   $
��Left=�6   $��
327,26,0,0q�6/   $
��Wrap=�6C   $��Tên KH:��6W   $	��Top=�6f   �� 5   
   -   5        $ txbTenKhachHang��5      $
��Left=�6+   $��23��6F   $��
392,22,0,0q�6R   $
	 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��
327,56,0,0q�6/   $
��Wrap=�6C   $��Địa Chỉ:��6W   $	��Top=�6g   �� 5   
   -   5        $ 	txbDiaChi��5      $
��Left=�6%   $��23��6@   $��
392,52,0,0q�6L   $
	 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        
 ��Name$
 btnTimKH��5      $��Tìm KH��6#   $
��Left=�64   $��
75,114,0,0q�6O   $	��Top=�6c   $
��Auto��6{   6�   �� 5   
   -   5        $
 btnSuaKH��5      $��Sửa KH��6#   $
��Left=�64   $��241,114,0,0q�6O   $	��Top=�6d   $
��Auto��6|   {�.  6�   �� 5   
   -   5        $
 btnXoaKH��5      $��Xóa KH��6#   $
��Left=�64   $��411,114,0,0q�6O   $	��Top=�6d   $
��Auto��6|   {�.  6�   �� 5   
   $
��Left=�6   $��	57,86,0,0q�6/   $
��Wrap=�6B   $��Email:��6V   $	��Top=�6d   �� 5   
   -	   5        $ txbEmail��5      $
��Left=�6$   $��23��6?   $��
122,82,0,0q�6K   $
	 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5    
   $
��Left=�6   $��
327,86,0,0q�6/   $
��Wrap=�6C   $��
Số nợ:��6W   $	��Top=�6e   �� 5!   
   -
   5        $ txbSoNo��5!      $
��Left=�6#   $��23��6>   $��
392,82,0,0q�6J   $
	 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   5#      5$      