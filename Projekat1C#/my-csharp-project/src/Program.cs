using System;
using my_csharp_project.src.prevozna_sredstva;

namespace MyCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Motor motor = new Motor("BG123", "Yamaha", "R1", 2015, 10000, 20, 5, 1000, "Sport", "Manuelni", "Benzin");

            auto.setRegistracija("BG123");
            auto.setMarka("Audi");
            auto.setModel("A4");
            auto.setGodinaProizvodnje(2010);
            auto.setKilometraza(150000);
            auto.setZapreminaRezervoara(60);
            auto.setPotrosnjaGoriva(6.5);
            auto.setBrojVrata(4);
            auto.setBrojSedista(5);
            auto.setTipMenjaca("Automatski");
            auto.setTipGoriva("Dizel");
            auto.setBrzina(0);
            auto.toString();
            auto.Ubrzaj(100);

            motor.toString();
            motor.setBrzina(0);

            Console.WriteLine("Zapremina motora: " + motor.getZapreminaMotora());

            motor.Ubrzaj(100);

        }
    }
}