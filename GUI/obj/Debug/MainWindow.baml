   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.186, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nulleHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5   	   > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI 5
   	      GUI.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f8metro,http://metro.mahapps.com/winfx/xaml/controls  5   	   7dragablz(clr-namespace:Dragablz;assembly=Dragablz  5   	   RwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf  5   	   FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   localclr-namespace:GUI  5
   	   -   5          � Title$  Quan Ly Nha Sach��5   	   $	��700��6"   $
��1080��6/   $��Calibri)�6<    � 
ResizeMode$ CanMinimize=�6Q    � WindowStartupLocation$ CenterScreen=�6j    � Cursor$  ��6�   $��15(�6�    � WindowStyle$ ThreeDBorderWindow=�6�   ���	#FF31BCB7���	#FFFAFAFA(  "MahApps.Metro.Controls.MetroWindow   NonActiveBorderBrush �	#FF31BCB7   NonActiveGlowBrush �	#FF31BCB7    NonActiveWindowTitleBrush �	#FF31BCB7.��5         Dragablz.TabablzControl   J� 	AllowDrop .   %  !MaterialDesignTabablzControlStyle#��[  60   ���	#FF31BCB7	   InterTabController	 5   
   !   Dragablz.InterTabController  5      .@�5   
   �� $��
Bán sách��6   
 �� 
IsSelected
 . $
 Hand��66   .��5      � $��0,0,0,0q�6   .+�5        GUI.ui_BanSach  -   5          Name$ bansach��5   #   $
��Left=�64   $	��Top=�6O   $	��513��6g   $	��679��6t   5      5      �� 5   
   $��Khách hàng��6   .��5        GUI.ui_TimKhachHang  $
��Left=�6$   $	��Top=�6?   5      �� 5   
   $��Thay đổi quy định��6   .��5        GUI.ui_ThayDoiQuyDinh  $
��Left=�6&   $	��Top=�6A   5      �� 5   
   $��Nhập sách��6   .��5      � .+�5        GUI.ui_NhapSach  -   5          Name$ ui_nhapsach��5   $   $
��Left=�69   $	��Top=�6T   5      5       5"      5$      