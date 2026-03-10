
using System;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        List<int> fakturak = new List<int> { 400, 500, 800 }; // Faktura berriak
        int deskontua = 10;
        int guztira = 0;

     foreach (int faktura in fakturak)
    {
        int prezioFinala;
        if (faktura >= 450) // Deskontua 450tik aurrera aplikatu
    {
        prezioFinala = AplikatuDeskontua(faktura, deskontua);
    }
    else
    {
        prezioFinala = faktura;
    }
    guztira += prezioFinala;
}

Console.WriteLine("Guztira: " + guztira);

    }

    static int AplikatuDeskontua(int zenbatekoa, int deskontua)
    {
        if (zenbatekoa > 100)
        {
            return zenbatekoa - deskontua;
        }
        return zenbatekoa;
    }
}
