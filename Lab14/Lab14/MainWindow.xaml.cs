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

namespace Lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tomato.Visibility = Visibility.Collapsed;
            Cheese.Visibility = Visibility.Collapsed;
            Both.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var district = new Map { Title = "District" };
            district.AddComponent(new MapComponent { Title = "Cube 1" });
            district.AddComponent(new MapComponent { Title = "Cube 2" });
            var map = new Map { Title = "New Map of Objects" };
            map.AddComponent(district);
            map.Draw();
            var find = map.Find("Cube 1");
            find.Draw();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // путешественник
                        Driver driver = new Driver();
                        // машина
                        Auto auto = new Auto();
                        // отправляемся в путешествие
                        driver.Travel(auto);
                        // встретились пески, надо использовать верблюда
                        Camel camel = new Camel();
                        // используем адаптер
                        ITransport camelTransport = new CamelToTransportAdapter(camel);
                        // продолжаем путь по пескам пустыни
                        driver.Travel(camelTransport);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Tomato.Visibility = Visibility.Visible;
            Cheese.Visibility = Visibility.Visible;
            Both.Visibility = Visibility.Visible;
        }
        #region Map and Component
        public interface IComponent
        {
            string Title { get; set; }
            void Draw();
            IComponent Find(string title);
        }
        public class MapComponent : IComponent
        {
            public string Title { get; set; }
            public void Draw()
            {
                MessageBox.Show(Title);
            }
            public IComponent Find(string title)
            {
                return Title == title ? this : null;
            }
        }
        public class Map : IComponent
        {
            private readonly List<IComponent> _map = new List<IComponent>();
            public string Title { get; set; }
            public void AddComponent(IComponent component)
            {
                _map.Add(component);
            }
            public void Draw()
            {
                MessageBox.Show(Title);
                foreach (var component in _map)
                {
                    component.Draw();
                }
            }
            public IComponent Find(string title)
            {
                if (Title.Equals(title))
                {
                    return this;
                }
                foreach (var component in _map)
                {
                    var found = component.Find(title);
                    if (found != null)
                    {
                        return found;
                    }
                }
                return null;
            }
        }
        abstract class Pizza
        {
            public Pizza(string n)
            {
                this.Name = n;
            }
            public string Name { get; protected set; }
            public abstract int GetCost();
        }

        class ItalianPizza : Pizza
        {
            public ItalianPizza() : base("Итальянская пицца")
            { }
            public override int GetCost()
            {
                return 10;
            }
        }

        abstract class PizzaDecorator : Pizza
        {
            protected Pizza pizza;
            public PizzaDecorator(string n, Pizza pizza) : base(n)
            {
                this.pizza = pizza;
            }
        }

        class TomatoPizza : PizzaDecorator
        {
            public TomatoPizza(Pizza p)
                : base(p.Name + ", с томатами", p)
            { }

            public override int GetCost()
            {
                return pizza.GetCost() + 3;
            }
        }

        class CheesePizza : PizzaDecorator
        {
            public CheesePizza(Pizza p)
                : base(p.Name + ", с сыром", p)
            { }

            public override int GetCost()
            {
                return pizza.GetCost() + 5;
            }
        }

        ////adapter
        interface ITransport
        {
            void Drive();
        }
        // класс машины
        class Auto : ITransport
        {
            public void Drive()
            {
                MessageBox.Show ("Машина едет по дороге");
            }
        }
        class Driver
        {
            public void Travel(ITransport transport)
            {
                transport.Drive();
            }
        }
        // интерфейс животного
        interface IAnimal
        {
            void Move();
        }
        // класс верблюда
        class Camel : IAnimal
        {
            public void Move()
            {
                MessageBox.Show("Верблюд идет по пескам пустыни");
            }
        }
        // Адаптер от Camel к ITransport
        class CamelToTransportAdapter : ITransport
        {
            Camel camel;
            public CamelToTransportAdapter(Camel c)
            {
                camel = c;
            }

            public void Drive()
            {
                camel.Move();
            }
        }


        ////composite
        abstract class Component
        {
            protected string name;

            public Component(string name)
            {
                this.name = name;
            }

            public virtual void Add(Component component) { }

            public virtual void Remove(Component component) { }

            public virtual void Print()
            {
                MessageBox.Show(name);
            }
        }
        #endregion

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("итальянская пицца с томатами");
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            MessageBox.Show("Название: " + pizza1.Name + "Цена: "+ pizza1.GetCost());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("итальянская пицца с сыром");
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new CheesePizza(pizza1);
            MessageBox.Show("Название: " + pizza1.Name + "Цена: " + pizza1.GetCost());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("итальянская пицца с томатами и сыром");
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            pizza1 = new CheesePizza(pizza1);
            MessageBox.Show("Название: " + pizza1.Name + "Цена: " + pizza1.GetCost());
        }
    }

}
