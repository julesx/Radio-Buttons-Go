using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using PropertyChanged;

namespace WpfApplication9
{
    public enum Drink { Coke, Pepsi, MountainDew }

    [ImplementPropertyChanged]
    public class MainWindowVm
    {
        private RelayCommand _cmdCheckCommand;
        public ICommand CmdCheckCommand => _cmdCheckCommand ?? (_cmdCheckCommand = new RelayCommand(CheckCommand));

        private void CheckCommand(object obj)
        {
            var drinkVm = (DrinkVm)obj;

            foreach (var drink in Drinks)
                drink.IsChecked = false;

            drinkVm.IsChecked = true;
            SelectedDrink = drinkVm;
        }

        public ObservableCollection<DrinkVm> Drinks { get; set; } = new ObservableCollection<DrinkVm>();

        public DrinkVm SelectedDrink { get; set; }

        public MainWindowVm()
        {
            Drinks.Add(new DrinkVm(Drink.Coke, true));
            Drinks.Add(new DrinkVm(Drink.Pepsi));
            Drinks.Add(new DrinkVm(Drink.MountainDew));

            SelectedDrink = Drinks.First();
        }
    }
}
