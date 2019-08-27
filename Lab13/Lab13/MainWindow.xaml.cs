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

namespace Lab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickCreate(object sender, RoutedEventArgs e)
        {
            Add newItem = new Add();

            if (newItem.ShowDialog() == true)
            {
                Figure red = new Figure(new RedFigure());
                Figure green = new Figure(new GreenFigure());

                if ("Red ellipse" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Ellipse ellipseNew = red.getCircle();
                        g = g + 100;
                        ellipseNew.Margin = new Thickness(0, g, 340, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Green ellipse" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Ellipse ellipseNew = green.getCircle();
                        g = g + 100;
                        ellipseNew.Margin = new Thickness(-150, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Red rectangle" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 1; i < newItem.FigureCount + 1; i++)
                    {
                        Rectangle ellipseNew = red.getSquary();
                        g = g + 110;
                        ellipseNew.Margin = new Thickness(150, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
                if ("Green rectangle" == newItem.FirureName)
                {
                    int g = -400;
                    for (int i = 0; i < newItem.FigureCount; i++)
                    {
                        Rectangle ellipseNew = green.getSquary();
                        g = g + 110;
                        ellipseNew.Margin = new Thickness(340, g, 0, 0);
                        Greed.Children.Add(ellipseNew);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error open window");
            }

        }
        //(Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных объектов с определенными интерфейсами без указания конкретных типов данных объектов.

        //Abstract factory

        //определяет интерфейс для классов, объекты которых будут создаваться в программе
        abstract class Circle
        {
            public abstract Ellipse DrawCircle();
        }

        abstract class Square
        {
            public abstract Rectangle DrawSquary();
        }


        //представляет конкретную реализацию абстрактных классов
        class RedCircle : Circle
        {
            public override Ellipse DrawCircle()
            {
                Ellipse ellipseRed = new Ellipse();
                ellipseRed.Width = 50;
                ellipseRed.Height = 50;
                ellipseRed.Fill = Brushes.Red;
                return ellipseRed;
            }
        }

        class GreenCircle : Circle
        {
            public override Ellipse DrawCircle()
            {
                Ellipse ellipseGreen = new Ellipse();
                ellipseGreen.Width = 50;
                ellipseGreen.Height = 50;
                ellipseGreen.Fill = Brushes.Green;
                return ellipseGreen;
            }
        }

        class RedSquare : Square
        {
            public override Rectangle DrawSquary()
            {
                Rectangle squareRed = new Rectangle();
                squareRed.Width = 50;
                squareRed.Height = 50;
                squareRed.Fill = Brushes.Red;
                return squareRed;
            }
        }
        class GreenSquare : Square
        {
            public override Rectangle DrawSquary()
            {
                Rectangle squareGreen = new Rectangle();
                squareGreen.Width = 50;
                squareGreen.Height = 50;
                squareGreen.Fill = Brushes.Green;
                return squareGreen;
            }
        }

        //класс абтрактной фабрики - определяет методы для создания объектов
        //причём методы возвращают абстрактные продукты, а не их конкретные реалзиацию
        abstract class FigureFactory
        {
            public abstract Circle CreateCircle();
            public abstract Square CreateSquare();
        }

        //конкретные классы фабрик реализуют абстрактные матоды базового класса
        //и непосредственно определяют какие конкретные продукты использовать
        class RedFigure : FigureFactory
        {
            public override Circle CreateCircle()
            {
                return new RedCircle();
            }

            public override Square CreateSquare()
            {
                return new RedSquare();
            }

        }
        class GreenFigure : FigureFactory
        {
            public override Circle CreateCircle()
            {
                return new GreenCircle();
            }

            public override Square CreateSquare()
            {
                return new GreenSquare();
            }

        }

        //класс фигуры исп класс фабрики для созд объектов.
        //при этом он исп исключительно абстрактный класс фабрики и абстрактные классы
        //фигур и никак не зависит от их конкретных реализаций
        class Figure
        {
            private Circle circle;
            private Square square;
            public Figure(FigureFactory factory)
            {
                circle = factory.CreateCircle();
                square = factory.CreateSquare();
            }
            public Ellipse getCircle()
            {
                return circle.DrawCircle();
            }
            public Rectangle getSquary()
            {
                return square.DrawSquary();
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////

        //Prototype

        interface IFigure
        {
            IFigure Clone();
            String GetInfo();
        }

        class Rectangles : IFigure
        {
            int width;
            int height;
            public Rectangles(int w, int h)
            {
                width = w;
                height = h;
            }

            public IFigure Clone()
            {
                return new Rectangles(this.width, this.height);
            }
            public string GetInfo()
            {
                String s = System.String.Format("Прямоугольник длиной {0} и шириной {1}", height, width);
                return s;
            }
        }

        class Circles : IFigure
        {
            int radius;
            public Circles(int r)
            {
                radius = r;
            }

            public IFigure Clone()
            {
                return new Circles(this.radius);
            }
            public String GetInfo()
            {
                String s = System.String.Format("Круг радиусом {0}", radius);
                return s;
            }
        }

        private void ButtonClickClone(object sender, RoutedEventArgs e)
        {
            IFigure figure = new Rectangles(50, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();


            IFigure figures = new Circles(50);
            IFigure clonedFigures = figures.Clone();
            tb.Text = System.String.Format(" {0} \n {1} \n {2} \n {3}", figures.GetInfo(), clonedFigures.GetInfo(), figure.GetInfo(), clonedFigure.GetInfo());

        }

        //Singleton/////////////////////////////////////////////
        class Singleton
        {
            private static Singleton instance;

            private Singleton()
            { }

            public static Singleton getInstance()
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        class GoldObject
        {
            public Color Color { get; set; }
            public void DrawColor(string osName)
            {
                Color = Color.getInstance(osName);
            }
        }

        class Color
        {
            private static Color instance;

            public string Name { get; private set; }

            protected Color(string name)
            {
                this.Name = name;
            }

            public static Color getInstance(string name)
            {
                if (instance == null)
                    instance = new Color(name);
                return instance;
            }
        }

        private void ButtonClickCreateGpld(object sender, RoutedEventArgs e)
        {
            GoldObject comp = new GoldObject();
            comp.DrawColor("Gold");

            String color = comp.Color.Name;

            comp.Color = Color.getInstance("Black");

            tb.Text = System.String.Format("Цвет {0} и при попытке изменить цвет на Black \n он останеться {1}", color, comp.Color.Name);
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        //Bilder


        class Color2
        {
            public string Color { get; set; }
        }

        class Area2
        {
            public string Area { get; set; }
        }

        class Circletes
        {
            public string Color { get; set; }
            public Ellipse ellipse = new Ellipse();
        }

        class Figure2
        {
            public Color2 color { get; set; }
            public Area2 area { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                if (color != null)
                    sb.Append("Цвет: " + color.Color + "\n");
                if (area != null)
                    sb.Append("Площадь: " + area.Area + "\n");
                return sb.ToString();
            }
        }

        // абстрактный класс строителя
        abstract class FigureBuilder
        {
            public Figure2 figure2 { get; private set; }
            public void CreateFigure()
            {
                figure2 = new Figure2();
            }
            public abstract void SetColor();
            public abstract void SetArea();

            public abstract Ellipse SetCircletes();
        }

        //Создатель
        class Creator
        {
            public Figure2 create(FigureBuilder figureBuilder)
            {
                figureBuilder.CreateFigure();
                figureBuilder.SetColor();
                figureBuilder.SetArea();
                return figureBuilder.figure2;
            }
        }

        //строитель для красного круга
        class RedCircleBuilder : FigureBuilder
        {
            public override void SetColor()
            {
                this.figure2.color = new Color2 { Color = "Красный" };
            }
            public override void SetArea()
            {
                this.figure2.area = new Area2 { Area = "50см^2" };
            }

            public override Ellipse SetCircletes()
            {
                Ellipse ellipseRed = new Ellipse();
                ellipseRed.Width = 50;
                ellipseRed.Height = 50;
                ellipseRed.Fill = Brushes.Red;
                return ellipseRed;
            }
        }

        class GreenCircleBuilder : FigureBuilder
        {
            public override void SetColor()
            {
                this.figure2.color = new Color2 { Color = "Зелёный" };
            }
            public override void SetArea()
            {
                this.figure2.area = new Area2 { Area = "100см^2" };
            }

            public override Ellipse SetCircletes()
            {
                Ellipse ellipseRed = new Ellipse();
                ellipseRed.Width = 100;
                ellipseRed.Height = 100;
                ellipseRed.Fill = Brushes.Green;
                ellipseRed.Margin = new Thickness(0, 0, 300, 0);
                return ellipseRed;
            }
        }


        private void ButtonClickCreateComplexObject(object sender, RoutedEventArgs e)
        {
            Creator creator = new Creator();
            FigureBuilder figureBuilder = new RedCircleBuilder();
            Figure2 figure1 = creator.create(figureBuilder);
            Greed.Children.Add(figureBuilder.SetCircletes());
            tb.Text = figure1.ToString();

            figureBuilder = new GreenCircleBuilder();
            Figure2 figure2 = creator.create(figureBuilder);
            Greed.Children.Add(figureBuilder.SetCircletes());
            tb.Text += figure2.ToString();
        }
    }
}
