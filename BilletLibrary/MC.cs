using System;
using BilletLibrary;

public class MC : Base
{
    public override decimal Pris()
    {

        decimal pris = 125;

        return pris;
    }

    public override string Køretøj()
    {
        string vehicle = "MC";

        return vehicle;
    }
}
