   M S B A M L   `   `   `  ????E  AToyShopWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ToyShopWpf
ToyShopWpf  5   	       ToyShopWpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ToyShopWpf     5   	     ? Title$  Авторизация??5   	   $	??450??6   $	??800??6*    ? Icon$ /Resources/logo.png??66    ? WindowStartupLocation$ CenterScreen=?6Q    ? 	Resources 5	      ??%    5      .??5      ? ???#fadb ? RowDefinitions 5   
   ?? 5      ?? 5      $	??200 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      $	??400 ?6   ?? 5      .+?5   
   ?? $??0??6   $??1??6   $??Игруша??6-   $??40(?6>   $??Center=?6L   $??20q?6i   ?? 5   
   $??Resources/logo.png??6   6.   ?? 5   
   $??1??6   $??1??6"   $??Center=?62   .+?5      ?? $??
Логин??6   $??20(?6$   $??0,0,0,10q?62   ?? 5      -   5         ??Name$ LoginBox??5      $??30??6(    ?? TextAlignment$
 Left=?64   ?? 5      $??Пароль??6   $??20(?6%   $??0,0,0,10q?63   ? 5       .+?5!      G? -   5        $??PassBox??5!      $??30??6-   $??0,0,0,10q?69   ?? 5"      -   5        $??PassBox1??5"      $??30??6*   $??0,0,0,10q?66   $y?Hidden=?6H   5#      ?? 5%      -   5         ??Name$ LookPass??5%      $#??Показать пароль??6)   $??Right=?6C   6z   5&      ? 5(   
   $??2??6   $??1??6    5)      ?? 5*      ?? 5+      .+?5-      ?? -   5        $??0??5-      $
??Left=?6(   $??
Войти??6C   	 ? Cursor$
	 Hand??6h   ?? 5.      -   5        $??1??5.      $??Right=?6&   $??Регистрация??6B   $
	 Hand??6X   6f   5/      ?? 50   
   -   5        $??2??50      $??
Выход??6!   $
	 Hand??6H   52      53      