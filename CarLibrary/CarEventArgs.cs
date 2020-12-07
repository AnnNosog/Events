using System;

namespace CarLibrary
{
    internal class CarEventArgs : EventArgs
    {
        public string Message { get; }
        public int Distance { get; }

        public CarEventArgs(string mes, int dist)
        {
            Message = mes;
            Distance = dist;
        }
    }
}
