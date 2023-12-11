using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFramework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*myTextBlock.Text = "Hi from the CS side";
            myTextBlock.Foreground = Brushes.Blue;

            TextBlock myTb = new TextBlock();
            myTb.Text = "Hi world";
            myTb.Inlines.Add(" another line");
            myTb.Inlines.Add(new Run(" Run text from Code Behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BurlyWood;
            this.Content = myTb;*/

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Foreground = Brushes.Coral;
            double myFont = myLabel.FontSize;
            myLabel.FontSize = myFont + 1;
        }

        private void btn2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            myLabel.Foreground = Brushes.Coral;
            double myFont = myLabel.FontSize;
            myLabel.FontSize = myFont - 4;

        }

        private void btn2_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground= Brushes.White;
        }

        private void btn2_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.Black;
        }

        private void rbLem_Checked(object sender, RoutedEventArgs e)
        {
            lbLem.Background = Brushes.Aquamarine;
        }

        private void rbLem_Unchecked(object sender, RoutedEventArgs e)
        {
            lbLem.Background = Brushes.White;
        }


        private void cbCheese_Checked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.Gray;
        }

        private void cbCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            lbCheese.Background = Brushes.White;
        }

        private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbHam.IsChecked = newVal;
            cbTuna.IsChecked = newVal;
            cbMushroom.IsChecked = newVal;
        }

        /*private void cbToppingsCheckedChanged(object sender, RoutedEventArgs e)
         {
        cbParent.isChecked = null;
        if(all checked) cbParent.IsChecked = true;
        if(all unchecked) cbParent.IsChecked = false;
        }*/
    }
}
