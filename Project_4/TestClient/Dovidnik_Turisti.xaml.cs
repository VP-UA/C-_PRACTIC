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

namespace TestClient
{
    /// <summary>
    /// Логика взаимодействия для Dovidnik_Turisti.xaml
    /// </summary>
    public partial class Dovidnik_Turisti : Window
    {
        

        public Dovidnik_Turisti()
        {
            InitializeComponent();
        }

        public Dovidnik_Turisti(dynamic dt)
        {
            InitializeComponent();
            DataContext = dt;
        }
    }
}
