using System;

namespace Task_02
{
    public delegate void PropertyEventHandler (object sender, PropertyEventArgs e);

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
