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

namespace DZ_5
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();


            result.Add(new BusRoute(1, "Тверь", "Москва", 90));
            result.Add(new BusRoute(2, "Зеленоград", "Москва", 36));
            result.Add(new BusRoute(3, "Зеленоград", "Тверь", 59));
            result.Add(new BusRoute(4, "Тверь", "Зеленоград", 71));
            result.Add(new BusRoute(5, "Москва", "Ярославль", 30));
            result.Add(new BusRoute(6, "Ярославль", "Москва", 98));
            result.Add(new BusRoute(7, "Краснодар", "Москва", 77));
            result.Add(new BusRoute(8, "Владивосток", "Москва", 10));
            result.Add(new BusRoute(9, "Москва", "Владивосток", 93));
            result.Add(new BusRoute(10, "Владивосток", "Хабаровск", 20));
        }
        List<BusRoute> result = new List<BusRoute>();
        

        //private void Grid_Loaded(object sender, RoutedEventArgs e)
        //{

        //    List<BusRoute> result = new List<BusRoute>();
        //    result.Add(new BusRoute(1, "Тверь", "Москва", 90));

        //    dgrid.ItemsSource = result;

        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            dgrid.ItemsSource = result;



        }

        private void Button_Cliick_Max(object sender, RoutedEventArgs e)
        {
            List<BusRoute> result1 = new List<BusRoute>();
            result1.AddRange(result);
            List<BusRoute> max = new List<BusRoute>();
            result1.Sort((x, y) => -x.sum.CompareTo(y.sum));
            if (result[0] != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    max.Add(result1[i]);
                }
                dgrid2.ItemsSource = max;
            }
        }

        private void Button_Cliick_Search(object sender, RoutedEventArgs e)
        {
            
            string punkt = tb1.Text;

            List < BusRoute > foundbus = result.FindAll((x) => x.pointdep == punkt);
            dgrid2.ItemsSource = foundbus;
        }





        //List<MyTable> result = new List<MyTable>(3);
        //result.Add(new MyTable(1, "Майкл Джексон", "Thriller", 1982));
        //    result.Add(new MyTable(2, "AC/DC", "Back in Black", 1980));
        //    result.Add(new MyTable(3, "Bee Gees", "Saturday Night Fever", 1977));
        //    result.Add(new MyTable(4, "Pink Floyd", "The Dark Side of the Moon", 1973));
        //    grid.ItemsSource = result;


        //Loaded="grid_Loaded"


    }
} 