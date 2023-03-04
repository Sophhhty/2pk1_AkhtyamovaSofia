using System;
using System.Collections.Generic;
using System.Data;
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


namespace PZ_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach( UIElement el in GroupButton.Children) {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            string textButton =((Button)e.OriginalSource).Content.ToString();
            if (textButton == "c")
            {
                text.Clear();
            }
            else if (textButton == "x")
            {
                text.Text = text.Text.Substring(text.Text.Length - 1);
            }
            else if (textButton == "=")
            {
                text.Text = new DataTable().Compute(text.Text, null).ToString();
            }
            else text.Text += textButton;
        }
    }
}
