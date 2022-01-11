using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mark1
{
    public class Janela1VM : INotifyPropertyChanged
    {
        public ObservableCollection<Pessoas> lista_pessoas { get; set; }

        public ICommand adiciona { get; private set; }
        public ICommand remover { get; private set; }
        public string nome_digitado { get; set; }
        public Pessoas PessoaSelecionada { get; set; }
        public Janela1VM()

        {
            lista_pessoas = new ObservableCollection<Pessoas>();
            adiciona = new RelayCommand((object param) =>
           {
               lista_pessoas.Add(new Pessoas()
               {
                   Nome = nome_digitado
               });
           });

            remover = new RelayCommand((object param) =>
            {
                lista_pessoas.Remove(PessoaSelecionada);
            });
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void notifica(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
