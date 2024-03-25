using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog
            {
                Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
            };
            bool? текст = x.ShowDialog();
            if (текст == true)
            {
                string имя = x.FileName;
                string содержимое = File.ReadAllText(имя);
                rtd.Text = содержимое;
            }
        }

        private void Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog y = new SaveFileDialog();
            y.DefaultExt = ".txt";
            y.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            bool? текст = y.ShowDialog();
            if (текст == true)
            {
                string имя = y.FileName;
                string i = rtd.Text;
                File.WriteAllText(имя, i);
            }
        }

        private void Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void rtd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

