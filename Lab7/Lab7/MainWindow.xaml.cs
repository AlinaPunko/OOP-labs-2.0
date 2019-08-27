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

namespace Lab7
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            City city = (City)this.Resources["Minsk"]; // получаем ресурс по ключу
            MessageBox.Show(city.Temperature.ToString());
        }
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }
        private void Control_Mouse(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Это новая комнада");
        }
    }
    public class NewCustomCommand
    {
        private static RoutedUICommand pnvCommand;
        static NewCustomCommand()
        {
            InputGestureCollection inputs =new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.P, ModifierKeys.Alt, "Alt+P"));
            pnvCommand = new RoutedUICommand("PNV", "PNV", typeof(NewCustomCommand), inputs);
        }
        public static RoutedUICommand PnvCommand
        {
            get { return pnvCommand; }
        }
    }
    public class City : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty TemperatureProperty;

        static City()
        {
            NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(City));

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            TemperatureProperty = DependencyProperty.Register("Temperature", typeof(int), typeof(City), metadata,
                new ValidateValueCallback(ValidateValue));
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 40 || currentValue < (-20))  
                return 0;
            return currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public int Temperature
        {
            get { return (int)GetValue(TemperatureProperty); }
            set { SetValue(TemperatureProperty, value); }
        }
    }

}
