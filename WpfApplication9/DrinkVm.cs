using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WpfApplication9
{
    [ImplementPropertyChanged]
    public class DrinkVm
    {
        public Drink Drink { get; set; }
        public bool IsChecked { get; set; }

        public DrinkVm(Drink drink, bool isChecked = false)
        {
            Drink = drink;
            IsChecked = isChecked;
        }
    }
}
