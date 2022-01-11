using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mark1
{
    public class MainWindowVM
    {

        public ICommand abrir { get; private set; }
        public MainWindowVM()
        {

            abrir = new RelayCommand((object param) =>
            {
                Janela1 win1 = new Janela1();
                win1.Show();
            });
        }

    }
}
