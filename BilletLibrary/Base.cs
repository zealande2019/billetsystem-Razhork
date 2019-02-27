using System;

namespace BilletLibrary
{
    public abstract class Base
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }

        public abstract decimal Pris();
        public abstract string Køretøj();
    }
}