   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.TImSach   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  TImSach��5   	   $��379.568��6   $��548.622��6*    � WindowStartupLocation$ CenterScreen=�6:   .��5	      � $	��540��6   $	��350��6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtgTimSach��5
   u   $ �� IsSynchronizedWithCurrentItem$
 TrueY�64      AutoGenerateColumns .  $
��Left=�6�   $	��161��6�   $��
18,163,0,0q�6�   $	��Top=�6�   $	��503��6�      AreRowDetailsFrozen . ��6   �� *
listSach+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã Sách��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *MaSach+  5      $ 
Tên Sách��6%    67   �� *	TenSach+  5      $ Thể Loại��6%    67   �� *	TheLoai+  5      $ 
Tác Giả��6%    66   �� *TacGia+  5      $ Số Lượng Tồn��6%    6;   �� *	SoLuong+  5      $ 
Đơn Giá��6%    66   �� *DonGia+5      �� 5   
   $
��Left=�6   $��	41,26,0,0q�6/   $
��Wrap=�6B   $��	Mã Sách��6V   $	��Top=�6e   �� 5   
   -   5        	 ��Name$	 	txbMaSach��5      $
��Left=�6%   $��23��6@   $��
106,22,0,0q�6L   
 �� TextWrapping$

 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $
��Left=�6   $��	41,73,0,0q�6/   $
��Wrap=�6B   $��Thể Loại��6V   $	��Top=�6f   �� 5   
   -   5        $	 
txbTheLoai��5      $
��Left=�6&   $��23��6A   $��
106,69,0,0q�6M   $

 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   $
��Left=�6   $��
311,26,0,0q�6/   $
��Wrap=�6C   $��
Tên Sách��6W   $	��Top=�6g   �� 5   
   -   5        $	 
txbTenSach��5      $
��Left=�6&   $��23��6A   $��
376,22,0,0q�6M   $

 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   $
��Left=�6   $��
311,73,0,0q�6/   $
��Wrap=�6C   $��
Tác Giả��6W   $	��Top=�6f   �� 5   
   -   5        $	 	txbTacGia��5      $
��Left=�6%   $��23��6@   $��
376,69,0,0q�6L   $

 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $��
Tìm Sách��5      $
��Left=�6$   $��
59,114,0,0q�6?   $	��Top=�6S   $
��Auto��6k   6x   �� 5   
   -   5         ��Name$ 
btnSuaSach��5      $��Sửa Sách��6%   $
��Left=�68   $��225,114,0,0q�6S   $	��Top=�6h   $
��Auto��6�   {�.  6�   �� 5   
   -   5        $ 
btnXoaSach��5      $��
Xóa Sách��6%   $
��Left=�68   $��395,114,0,0q�6S   $	��Top=�6h   $
��Auto��6�   {�.  6�   5       5!      