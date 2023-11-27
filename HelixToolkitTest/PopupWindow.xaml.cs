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
using System.Windows.Shapes;

namespace HelixToolkitTest
{
    /// <summary>
    /// Interaction logic for PopupWindow.xaml
    /// </summary>
    public partial class PopupWindow : Window
    {
        private UserControl control;
        private MainWindow mainWindow;

        public PopupWindow(MainWindow mainWindow, UserControl control)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.control = control;

            this.mainPanel.Children.Add(this.control);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.mainPanel.Children.Remove(control);
            this.mainWindow.AddPanelBack();
            Close();
        }
    }
}
