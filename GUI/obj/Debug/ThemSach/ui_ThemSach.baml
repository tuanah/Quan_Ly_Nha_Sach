   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.ui_ThemSach   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      $	��475��5   7   $	��560��6D   .��5	      � $	��475��6   $	��560��6     � ColumnDefinitions  5
   
   �� 5      $
��131* �6   �� 5      $
��161* �6   .+�5   
   �� $��
Mã Sách:��6   $
��Left=�6#   $��
209,21,0,0q�6>   $	��Top=�6R   $��26��6j   $��2��6v   �� 5   
   $��Tên Sách:��6   $
��Left=�6$   $��	65,62,0,0q�6?   $	��Top=�6R   $��1��6j   �� 5   
   $��Thể Loại:��6   $
��Left=�6$   $��	45,62,0,0q�6?   $	��Top=�6R   �� 5   
   $��Tác Giả:��6   $
��Left=�6#   $��	65,98,0,0q�6>   $	��Top=�6Q   $��1��6i   �� 5   
   $��Đơn Giá:��6   $
��Left=�6#   $��
45,104,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ 
txbTenSach��5      $
��Left=�6&   $��23��6A   $��
135,62,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��1��6�   �� 5   
   -   5        $ 
txbTheLoai��5      $
��Left=�6&   $��23��6A   $��
115,62,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 	txbTacGia��5      $
��Left=�6%   $��23��6@   $��
135,98,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   $��1��6�   �� 5   
   -   5        $ 	txbDonGia��5      $
��Left=�6%   $��23��6@   $��115,104,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5         ��Name$ 	tblMaSach��5      $
��Left=�6'   $��	31,26,0,0q�6B   $
��Wrap=�6U   $	��Top=�6i    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��asdasd��6�   $��1��6�   �� 5   
   -   5         ��Name$ btnThem��5      $
��Left=�6"   $	��Top=�6=   $��122,153,0,0q�6U   $	��100��6j   $��35��6v   $��Thêm sách��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgThemSach��5         AutoGenerateColumns .  $��2��6i   $
��Left=�6}   $	��213��6�   $��
30,240,0,0q�6�   $	��Top=�6�   $	��497��6�   ��6(   �� *listSachThem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 STT��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 62   �� *STT+  5      $	 	Mã Sách��6%   
 66   �� *MaSach+  5      $	 
Tên Sách��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 67   
 6D   �� *	TenSach+  5      $	 Thể Loại��6%   $
 Auto 67   
 6D   �� *	TheLoai+  5      $	 
Tác Giả��6%   $
 Auto 66   
 6C   �� *TacGia+  5       $	 
Đơn Giá��6%   $
 Auto 66   
 6C   �� *DonGia+5$      �� 5%   
   $
��Left=�6   $��
30,209,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $'��!Danh sách các sách đã thêm:��6o   �� 5&   
   -   5        $ btnXoa��5&      $��Xóa sách vừa thêm��6!   $��1��6=   $
��Left=�6M   $��
52,153,0,0q�6h   $	��Top=�6|   $��35��6�   $
��Auto��6�   6�   5'      5(      