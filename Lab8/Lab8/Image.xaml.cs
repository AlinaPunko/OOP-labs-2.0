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

namespace Lab8
{
    /// <summary>
    /// Логика взаимодействия для Image.xaml
    /// </summary>
    public partial class OwnerImage : Window
    {
        public OwnerImage(MainWindow mw)
        {
            InitializeComponent();
            if (mw.PathImage != null)
            {
                string path = mw.PathImage;
                image.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute)); 
            }
        }
    }
}
