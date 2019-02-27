using System;

namespace BilletLibrary
{
    public class Bil : Base
    {

        public override decimal Pris()
        {
            decimal pris = 240;

            return pris;
        }

        public override string Køretøj()
        {
            string bil = "bil";

            return bil;
        }
    }
}
