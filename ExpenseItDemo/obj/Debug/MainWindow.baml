   M S B A M L   `   `   `  ����H  DExpenseItDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ExpenseItDemoExpenseItDemo  5      C&clr-namespace:ExpenseItDemo.ValidationExpenseItDemo.Validation  5          ExpenseItDemo.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:ExpenseItDemo     5      BlocalValidation&clr-namespace:ExpenseItDemo.Validation     5         ExpenseData  � DataContext#  [  5       � Title$ ExpenseIt Standalone��5      $	��480��5	      $	��260��6    � SizeToContent$ WidthAndHeight=�5
       � Icon$ Watermark.png��5       � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5        EmployeeList �� 
TargetType �� Property �� Value  CostCenterList  HorizontalRadio	 d� 	IsChecked
 �� Path �� RelativeSource �� Mode  HorizontalRadioList �� 
TargetType-  'System.Windows.Input.KeyboardNavigation   TabNavigation K� IsItemsHost �� Orientation  	InputText �� Triggers P� Property P� Value  EmployeeItemTemplate �� XPath  CostCenterTemplate��%�  &	       &	 q     &	 �     &	 �    &	 �    &	 �    &	 !    �� 5   
   " ��6%   .�5      ��  � ��$ 0,5,5,0q�6'   �� 5       � ��$ 50��6*   5      �� 5   
   " ��6'   .�5      ��  � ��$ 0,5,5,0q�6'   5      �� 5   
   " ��6(   .�5      ��  � ��$ 0,5,5,0q�6'   �� 5       � �� 5      �� 5      .R�5      	� |�.  #��z��5   &   $��Center=�5    &   	 5!   &   �� $
 
IsSelected� �� *TemplatedParent+$ TwoWay=�5"      5$      5%      �� 5'   
   " ��6,   .�5(      ��  � �� .  6*   �� 5)       � ��$ 0q�6'   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� $
 Once=�6%    . $ 
Horizontal=�6`   $��25��5.   %   5/      51      52      �� 54   
   " ��6"   .�55      ��  � ��$ Trebuchet MS)�6+   �� 56       � �� �#0066CC6+   �� 57       � ��$
 10pt(�6)   �� 58       � ��$ 0,5,5,0q�6'    59      P� 5:       �@=�HasError . . �5;      ��  �@�ToolTip 5<      ��  �� *Self+$)
 #(Validation.Errors)[0].ErrorContent�5=      P� 5>       �@=�HasError .  . �5?      ��  �@�ToolTip 5@      ��  �� *Self+$
 ToolTip.Content�5A      5C      �� 5E   
   .R�5F      �� ��6   �� $ @Name��5G      �� 5I   
   .R�5J      �� ��6   �� $ @Name��5K      5M      .��5O      � .+�5R   
   ��   WatermarkImage#��[ 6   ]� 5T   
   .+�5W      o� $	��Top=�6   .@�5Z      m� $��_File��6   .@�5[      m�  m� Command$1 +local:MainWindow.CreateExpenseReportCommand��6   �� 5\      m� 5]      $" local:MainWindow.ExitCommand��6   5^      m� 5a      $��_Help��6   .@�5b      m� $# local:MainWindow.AboutCommand��6   5c      5e      � 5h       	 WindowContentGrid#��[	 6    � ColumnDefinitions 5j      �� 5k      $	��250 �6'   �� 5l       � RowDefinitions 5n      �� 5o      $
��Auto �6$   �� 5p      $
��Auto �6$   �� 5q      $
��Auto �6$   �� 5r      $
��Auto �6$   �� 5s      �� 5t      $
��Auto �6$   .+�5x      ��  	
 Label#��[
 6   $��0��6c   $��0��5y       �� Target 5x   7   ��  �� ElementName$ emailTextBox��.��5y   %   	_Email:5{      �� 5|      -   5        $��emailTextBox��5|      #��[ 6.   $��1��6Q   $��0��6a   .��6n   ��5}      �� 5~      $
 Alias�6"    �� UpdateSourceTrigger$ PropertyChanged=�6/    �� ValidationRules 5�      2   ,ExpenseItDemo.Validation.EmailValidationRule  5�   "   5�      .��5�   $    � ToolTip$ Enter email.��5�   D   .��5�      �� 5�      #��[
 6   $��0��5�      $��1��6(    5�   7   �� $ employeeNumberTextBox��.��5�   5   Employee _Number:5�      �� 5�      -   5        $��employeeNumberTextBox��5�      #��[ 67   $��1��6Z   $��1��6j   .��6w   ��5�      �� 5�      $
 EmployeeNumber�6"   $ PropertyChanged=�68    5�      3   -ExpenseItDemo.Validation.NumberValidationRule  5�   "      IsFixedLength .    Length$ 5��6\   5�      .��5�   $   $ Enter employee number.��5�   N   .��5�      �� 5�      #��[
 6   $��0��6h   $��2��5�       5�   7   �� $ costCenterTextBox��.��5�   %   _Cost Center:5�      �� 5�      -   5        $��costCenterTextBox��5�      #��[ 5�      $��1��5�      $��2��6+   #��[ 5�       �� SelectedValuePath$ @Number��5�      ��5�      ��   CostCenters  �� Source#  [ ! �� SelectedValue! 5�      �� $
 
CostCenter� 5�      �� 5�      Choose cost center.69   ��5�      �� 5�      .�5�      �� 4  .System.Windows.Automation.AutomationProperties �@ Name 6J   �� $ @Name��5�      5�      �� 5�      #��[
 6   $��0��5�      $��3��6(    5�   7   �� $ employeeTypeRadioButtons��.��5�   5   E_mployees:5�      �� 5�      -   5        $��employeeTypeRadioButtons��5�      #��[ 6:   $��1��6g   $��3��5�      .@�5�      �� #��[ 6"   .��6K   FTE 5�      �� 5�      FTE employee type6;   5�      �� 5�      #��[ 6"   .��6K   CSG 5�      �� 5�      CSG employee type6;   5�      �� 5�      #��[ 6"   .��6K   Vendor 5�      �� 5�      Vendor employee type6>   5�      5�      �� 5�      #��[ 6   $��1��5�      $��4��6*   #��[ 5�      ��5�      ��   	Employees#  [  5�      �� 5�      Choose employee name.6;   ��5�      �� 5�      .�5�      ��  �@ Name 6J   �� $ @Name��5�      5�      �� 5�      -   5        $��createExpenseReportButton��5�        CommandButton#��[ 6:   $��1��6a   $��5��5�      $1��+local:MainWindow.CreateExpenseReportCommand��6&   .��6\   Create Expense _Report 5�      �� 5�      Create Expense Report.6<   5�      5�      5�      5�      5�      