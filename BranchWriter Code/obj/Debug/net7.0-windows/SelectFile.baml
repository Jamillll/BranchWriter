   M S B A M L   `   `   `  ����L  HBranchWriter Code, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BranchWriter_CodeBranchWriter_Code  5      "    BranchWriter_Code.SelectFile   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BranchWriter_Code     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
SelectFile��5      $	��600��5	      $	��350��5
       � 
ResizeMode$ NoResize=�5       � WindowStyle$
 None=�5      .��5      �    Body#��[  6    � RowDefinitions 5   
   �� 5      $��0.045* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $��* �6   .+�5   
   �� $��2��6   ���#2222226(   �� 5   
   -   5          	SmallText#��[ 5      $��Select a file��5      �� 5   
   -   5        $��1��5       $��Center=�5!      $��x��5#      $��10(�5$       
 Button#��[ 5%      � 5'   
   $��1��6   $��4��6    5(      �� 5)      $��* �6     5+      �� 5,      $��* �6#   .+�5/      �� -   5         �� Padding$ 20q�50      $��Center=�51       J� 	AllowDrop$
 True��52        Text#��[ 54      $��Drag a leaf file here��55      �� 57      -   5        $	��200��58      $��50��59      ���#222222$!��Click to open file explorer��5<      #��[ 5=      �� 5?      -   5        $��50��5@      $��30��5A      $��0,85,0,0q�5B      $ 15,0,0,0q�5C      $
 True��5D      #��[ 5F      $��Or��5G      �� 5I      -   5        $	��200��5J      $��50��5K      $��	0,170,0,0q�5L      ���#222222$��Click to Create a file��5O      #��[ 5P      5Q      5R      5S      