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

namespace SubtitleHider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.VisualOpacity = 0.5;
                this.Opacity = 0.5;
                this.DragMove();
                this.VisualOpacity = 1.0;
                this.Opacity = 1.0;
            }
        }

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Topmost = true;
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                this.Close();
            }
        }

       
    }
}
