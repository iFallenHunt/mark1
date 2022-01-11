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

namespace mark1
{
    /// <summary>
    /// Lógica interna para Janela1.xaml
    /// </summary>
    public partial class Janela1 : Window
    {
        public Janela1()
        {
            InitializeComponent();
            DataContext = new Janela1VM();
        }
    }
}
