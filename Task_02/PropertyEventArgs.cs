using System;

namespace Task_02
{
    public class PropertyEventArgs : EventArgs
    {
        public string Name { get; }

        public PropertyEventArgs(string name)
        {
            Name = name;
        }
    }
}
