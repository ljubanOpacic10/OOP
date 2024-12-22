using System;

namespace my_csharp_project.src.prevozna_sredstva
{
    public abstract class Vozilo
    {
        private string Registracija { get; set; }
        private string Marka { get; set; }
        private string Model { get; set; }
        private int GodinaProizvodnje { get; set; }
        private double Kilometraza { get; set; }
        private double ZapreminaRezervoara { get; set; }
        private double PotrosnjaGoriva { get; set; }
        private int Brzina { get; set; }

        public Vozilo()
        {
            this.Registracija = "";
            this.Marka = "";
            this.Model = "";
            this.GodinaProizvodnje = 0;
            this.Kilometraza = 0;
            this.ZapreminaRezervoara = 0;
            this.PotrosnjaGoriva = 0;
        }
        public Vozilo(string registracija, string marka, string model, int godinaProizvodnje, double kilometraza, double zapreminaRezervoara, double potrosnjaGoriva)
        {
            this.Registracija = registracija;
            this.Marka = marka;
            this.Model = model;
            this.GodinaProizvodnje = godinaProizvodnje;
            this.Kilometraza = kilometraza;
            this.ZapreminaRezervoara = zapreminaRezervoara;
            this.PotrosnjaGoriva = potrosnjaGoriva;
        }

        public abstract void Ubrzaj(int kmh);

        public string getRegistracija()
        {
            return this.Registracija;
        }

        public void setRegistracija(string registracija)
        {
            this.Registracija = registracija;
        }

        public string getMarka()
        {
            return this.Marka;
        }
        public void setMarka(string marka)
        {
            this.Marka = marka;
        }

        public string getModel()
        {
            return this.Model;
        }

        public void setModel(string model)
        {
            this.Model = model;
        }

        public int getGodinaProizvodnje()
        {
            return this.GodinaProizvodnje;
        }

        public void setGodinaProizvodnje(int godinaProizvodnje)
        {
            this.GodinaProizvodnje = godinaProizvodnje;
        }

        public double getKilometraza()
        {
            return this.Kilometraza;
        }

        public void setKilometraza(double kilometraza)
        {
            this.Kilometraza = kilometraza;
        }

        public double getZapreminaRezervoara()
        {
            return this.ZapreminaRezervoara;
        }

        public void setZapreminaRezervoara(double zapreminaRezervoara)
        {
            this.ZapreminaRezervoara = zapreminaRezervoara;
        }

        public double getPotrosnjaGoriva()
        {
            return this.PotrosnjaGoriva;
        }

        public void setPotrosnjaGoriva(double potrosnjaGoriva)
        {
            this.PotrosnjaGoriva = potrosnjaGoriva;
        }

        public int getBrzina()
        {
            return this.Brzina;
        }
        public void setBrzina(int kmh)
        {
            this.Brzina = kmh;
        }

        public void toString()
        {
            Console.WriteLine("Registracija: " + this.getRegistracija());
            Console.WriteLine("Marka: " + this.getMarka());
            Console.WriteLine("Model: " + this.getModel());
            Console.WriteLine("Godina proizvodnje: " + this.getGodinaProizvodnje());
            Console.WriteLine("Kilometraza: " + this.getKilometraza());
            Console.WriteLine("Zapremina rezervoara: " + this.getZapreminaRezervoara());
            Console.WriteLine("Potrosnja goriva: " + this.getPotrosnjaGoriva());
        }

    }
}