   M S B A M L   `   `   `  ????J  FVectorChallenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:VectorGUI	VectorGUI  5   	       VectorGUI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:VectorGUI     5   	     ? Title$  Vektor Kreuzprodukt??5   	   $	??249??6%   $	??731??62    ? WindowStartupLocation$ CenterScreen=?6>    ? Icon$ /Vector-icon.png??6c   .??5	      ? $??0,0,22,2q?6   .+?5
   
   ?? $??0,0,-5,0q?6   $	??208??6#   $	??Top=?60   .+?5      ?? -   5         ??Name$ txtBoxVector1X??5      $
??Left=?6.   $??	64,52,0,0q?6I    ?? TextWrapping$
 Wrap=?6\   $?? ??6p   $	??Top=?6x   $	??120??6?   6?   ?? 5      -   5        $ txtBoxVector1Y??5      $
??Left=?6.   $??	64,87,0,0q?6I   $
 Wrap=?6\   $?? ??6p   $	??Top=?6x   $	??120??6?   6?   ?? 5      -   5        $ txtBoxVector1Z??5      $
??Left=?6.   $??
64,121,0,0q?6I   $
 Wrap=?6]   $?? ??6q   $	??Top=?6y   $	??120??6?   6?   ?? 5      -   5        $ txtBoxVector2X??5      $
??Left=?6.   $??
280,52,0,0q?6I   $
 Wrap=?6]   $?? ??6q   $	??Top=?6y   $	??120??6?   6?   ?? 5      -   5        $ txtBoxVector2Y??5      $
??Left=?6.   $??
280,87,0,0q?6I   $
 Wrap=?6]   $?? ??6q   $	??Top=?6y   $	??120??6?   6?   ?? 5      -   5        $ txtBoxVector2Z??5      $
??Left=?6.   $??280,121,0,0q?6I   $
 Wrap=?6^   $?? ??6r   $	??Top=?6z   $	??120??6?   6?   ?? 5      -   5         ??Name$ lblVector1X??5      $??X:??6)   $
??Left=?66   $??	39,48,0,0q?6Q   $	??Top=?6d   ?? 5      -   5        $ lblVector1Y??5      $??Y:??6)   $
??Left=?66   $??	39,83,0,0q?6Q   $	??Top=?6d   ?? 5      -	   5        $ lblVector1Z??5      $??Z:??6)   $
??Left=?66   $??
39,117,0,0q?6Q   $	??Top=?6e   ?? 5      -
   5        $ lblVector2X??5      $??X:??6)   $
??Left=?66   $??
255,48,0,0q?6Q   $	??Top=?6e   ?? 5      -   5        $ lblVector2Y??5      $??Y:??6)   $
??Left=?66   $??
255,83,0,0q?6Q   $	??Top=?6e   ?? 5      -   5        $ lblVector2Z??5      $??Z:??6)   $
??Left=?66   $??255,117,0,0q?6Q   $	??Top=?6f   ?? 5      -   5        $ 
lblVector1??5      $??Vektor 1??6(   $
??Left=?6;   $??	64,21,0,0q?6V   $	??Top=?6i   ?? 5      -   5        $ 
lblVector2??5      $??Vektor 2??6(   $
??Left=?6;   $??
280,21,0,0q?6V   $	??Top=?6j   ?? 5      -   5         ??Name$ btnCalcCrossProduct??5      $??Kreuzprod. Berechnen??62   $
??Left=?6Q   $??
64,166,0,0q?6l   $	??Top=?6?   $	??120??6?   $??28??6?   6?   ?? 5      -   5         ??Name$ rectLeft??5      $
??Left=?6*   $	??206??6E   $??10,0,0,0q?6R   
???   ?$??Center=?6s   $	??418??6?   ?? 5      -   5        $ 	rectRight??5      $??Center=?6+   $	??206??6H   
???   ?$??Center=?6d   $	??276??6    ?? Left$	 428??6?   ?? 5      -   5        $ 
lblVector3??5      $%??Neuer Vektor aus Kreuzprodukt
??6(   $	 486??6Z   
	 ?? Top$	 10??6l   ?? 5      -   5        $ txtBoxVector3X??5      $	 514??6.   $
 Wrap=?6@   $?? ??6T   $	 52??6\   $	??120??6l   $
??Left=?6x   $??Center=?6?   ?? 5      -   5        $ txtBoxVector3Y??5      $	 514??6.   $
 Wrap=?6@   $?? ??6T   $	 78??6\   $	??120??6l   $??Center=?6x   $	??Top=?6?   ?? 5      -   5        $ txtBoxVector3Z??5      $	 514??6.   $
 Wrap=?6@   $?? ??6T   $		 106??6\   $	??120??6m   $??Center=?6y   $	??Top=?6?   ?? 5       -   5        $ lblVector3X??5       $??X:??6)   $	 490??66   $	 48??6H   $
??Left=?6X   $??Center=?6s   ?? 5!      -   5        $ lblVector3Y??5!      $??Y:??6)   $	 490??66   $	 74??6H   $
??Left=?6X   $??Center=?6s   ?? 5"      -   5        $ lblVector3Z??5"      $??Z:??6)   $	 490??66   $		 102??6H   $
??Left=?6Y   $??Center=?6t   ?? 5#      -   5        $ btnClose??5#      $??Beenden??6'   $	 280??69   $		 166??6K   $
??Left=?6\   $??28??6w   $	??Top=?6?   $	??120??6?   6?   5$      5&      5'      