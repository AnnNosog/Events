using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class TestClass : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;

        private int number;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                PropertyChanged?.Invoke(this, new PropertyEventArgs(nameof(Number)));
            }
        }

        public TestClass()
        {
            PropertyChanged += OnPropertyChanged;
        }

        public virtual void OnPropertyChanged(Object obj, EventArgs ev)
        {
            PropertyEventArgs propertyEventArgs = ev as PropertyEventArgs;
            Console.WriteLine($"Изменено {propertyEventArgs.Name}");
        }
    }
}
