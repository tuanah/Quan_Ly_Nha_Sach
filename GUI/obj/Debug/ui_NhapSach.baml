   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.ui_NhapSach   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      $	��427��5   3   $	��685��6@   .��5      � $	��685��6   $	��427��6   $	��Top=�6$   .+�5	   
   �� $��Số Lượng Nhập:��6   $
��Left=�6)   $��	24,74,0,0q�6D   $	��Top=�6W   $��Calibri)�6o   $��14(�6�   �� 5
   
   -   5          ��Name$  txbSoLuongNhap��5
      $
��Left=�6*   $��23��6E   $��
130,77,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $��76��6�   $��Calibri)�6�   $��14(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgNhapSach��5      $
��Left=�6(   $	��195��6C   $��
24,162,0,0q�6P   $	��Top=�6d   $	��634��6|      RowDetailsVisibilityMode$ Visible=�6�      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *STT+  5      $ 	Mã Sách��6%    66   �� *MaSach+  5      $ 
Tên Sách��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 67    6C   �� *	TenSach+  5      $ 
Tác Giả��6%   $		 120 66    6B   �� *TacGia+  5      $ Số Lượng Tồn Cũ��6%    6>   �� *SoLuongTonCu+  5      $ Số Lượng Nhập��6%    6<   �� *SoLuongNhap+  5      $ Số Lượng Tồn Mới��6%    6?   �� *SoLuongTonMoi+5      �� 5   
   $�� ��6   $
��Left=�6   $��
238,25,0,0q�66   $	��Top=�6J   �� 5   
   $-��'Số lượng nhập tối thiểu: 150��6   $
��Left=�67   $��
424,77,0,0q�6R   $	��Top=�6f   $��Calibri)�6~   $��14(�6�   �� 5   
   $<��6Số lượng tồn tối đa trước khi nhập: 300��6   $
��Left=�6B   $��
424,25,0,0q�6]   $	��Top=�6q   
 J� RenderTransformOrigin$
 0.61,-0.006&�6�   $��Calibri)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ btnNhap��5      $��Nhập��6"   $
��Left=�61   $��
276,77,0,0q�6L   $	��Top=�6`   $��90��6x   6�   �� 5   
   $��
Mã Sách:��6   $
��Left=�6#   $��	24,25,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Ngày Nhập��6   $
��Left=�6$   $��
222,29,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $  txbNgayNhap��5      $
��Left=�6'   $��23��6B   $��
299,30,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��108��6�   �� 5   
   $(��"Danh sách các sách đã nhập:��6   $
��Left=�66   $��
24,121,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ btnHoanThanh��5      $��Hoàn thành��6'   $
��Left=�6<   $��276,381,0,0q�6W   $	��Top=�6l   $
��Auto��6�   6�   �� 5   
   -   5         ��Name$ 	cmbMaSach��5      $
��Left=�6&   $��	97,23,0,0q�6A   $	��Top=�6T   $	��109��6l   5"      5#      