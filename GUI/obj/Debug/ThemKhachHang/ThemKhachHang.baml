   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.ThemKhachHang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   -   5          � Title$  ThemKhachHang��5   	   $	��380��6   $	��550��6,    � WindowStartupLocation$ CenterScreen=�68   .��5	      � .+�5
   
   �� $
��Left=�6   $��
208,21,0,0q�6/   $
��Wrap=�6C   $��Mã KH:��6W   $	��Top=�6e   �� 5   
   -   5         ��Name$ lblMaKH��5      $��adasdasd��6!   $��273,16,182,303q�64   $��30��6L   �� 5   
   $
��Left=�6   $��	41,56,0,0q�6/   $
��Wrap=�6B   $��Tên KH:��6V   $	��Top=�6e   �� 5   
   -   5         ��Name$ txbTenKhachHang��5      $
��Left=�6+   $��23��6F   $��
106,52,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��
308,56,0,0q�6/   $
��Wrap=�6C   $��SĐT:��6W   $	��Top=�6c   �� 5   
   -   5        $ txbSDT��5      $
��Left=�6"   $��23��6=   $��
373,52,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   $
��Left=�6   $��
308,86,0,0q�6/   $
��Wrap=�6C   $��Email:��6W   $	��Top=�6e   �� 5   
   -   5        $ txbEmail��5      $
��Left=�6$   $��23��6?   $��
373,82,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   $
��Left=�6   $��	41,86,0,0q�6/   $
��Wrap=�6B   $��Địa Chỉ:��6V   $	��Top=�6f   �� 5   
   -   5        $ 	txbDiaChi��5      $
��Left=�6%   $��23��6@   $��
106,82,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgThemKhachHang��5         
IsReadOnly .    AutoGenerateColumns .  $
��Left=�6[   $	��167��6v   $��
23,163,0,0q�6�   $	��Top=�6�   $	��494��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 STT��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *STT+  5      $	 Mã KH��6%   $

 Auto 64    6A   �� *MaKH+  5      $	 Tên KH��6%   $

 Auto 65    6B   �� *TenKH+  5      $
	 SĐT��6%   $

 Auto 62    6?   �� *	DienThoai+  5      $	 Địa Chỉ��6%   $

 Auto 66    6C   �� *DiaChi+  5      $	 Email��6%   $

 Auto 64    6A   �� *Email+5      �� 5   
   -   5         ��Name$ btnThem��5      $��Thêm��6"   $
��Left=�61   $��123,118,0,0q�6L   $	��Top=�6a   $��75��6y   �� 5   
   -	   5        $ btnXoa��5      $��Xóa KH Vừa Thêm��6!   $
��Left=�6;   $��280,118,0,0q�6V   $	��Top=�6k   $
��Auto��6�   5       5!      