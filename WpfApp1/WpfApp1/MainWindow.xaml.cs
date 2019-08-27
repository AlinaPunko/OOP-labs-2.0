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
        using System.IO;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


private void text_PreviewDragEnter(object sender, DragEventArgs e)
    {
        bool isCorrect = true;

        if (e.Data.GetDataPresent(DataFormats.FileDrop, true) == true)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            foreach (string filename in filenames)
            {
                if (File.Exists(filename) == false)
                {
                    isCorrect = false;
                    break;
                }
                FileInfo info = new FileInfo(filename);
                if (info.Extension != ".txt")
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        if (isCorrect == true)
            e.Effects = DragDropEffects.All;
        else
            e.Effects = DragDropEffects.None;
        e.Handled = true;
    }

    private void text_PreviewDrop(object sender, DragEventArgs e)
    {
        string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
        foreach (string filename in filenames)
            text.Text += File.ReadAllText(filename);
        e.Handled = true;
    }
    public MainWindow()
        {
            InitializeComponent();
        }
    }
}
