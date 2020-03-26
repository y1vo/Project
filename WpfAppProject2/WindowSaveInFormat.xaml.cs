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

namespace WpfAppProject2
{
    /// <summary>
    /// Логика взаимодействия для WindowSaveInFormat.xaml
    /// </summary>
    public partial class WindowSaveInFormat : Window
    {
        public WindowSaveInFormat()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            /* здесь нужно на последнее открытое окно переходить
            WindowSaveInFormat window = new WindowSaveInFormat();
            this.Close();
            window.Show();
            */
        }
    }
}
