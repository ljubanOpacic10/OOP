using System;

namespace my_csharp_project.src.prevozna_sredstva
{
    public class Auto : Vozilo
    {
        private int BrojVrata { get; set; }
        private int BrojSedista { get; set; }
        private string TipMenjaca { get; set; }
        private string TipGoriva { get; set; }

        public Auto() : base()
        {
            this.BrojVrata = 0;
            this.BrojSedista = 0;
            this.TipMenjaca = "";
            this.TipGoriva = "";
        }

        public Auto(string registracija, string marka, string model, int godinaProizvodnje, double kilometraza, double zapreminaRezervoara, double potrosnjaGoriva, int brojVrata, int brojSedista, string tipMenjaca, string tipGoriva) : base(registracija, marka, model, godinaProizvodnje, kilometraza, zapreminaRezervoara, potrosnjaGoriva)
        {
            this.BrojVrata = brojVrata;
            this.BrojSedista = brojSedista;
            this.TipMenjaca = tipMenjaca;
            this.TipGoriva = tipGoriva;
        }

        public override void Ubrzaj(int kmh)
        {
            this.setBrzina(this.getBrzina() + kmh);
            Console.WriteLine("Auto je ubrzao na " + this.getBrzina() + " km/h");
        }

        public int getBrojVrata()
        {
            return this.BrojVrata;
        }

        public void setBrojVrata(int brojVrata)
        {
            this.BrojVrata = brojVrata;
        }

        public int getBrojSedista()
        {
            return this.BrojSedista;
        }

        public void setBrojSedista(int brojSedista)
        {
            this.BrojSedista = brojSedista;
        }

        public string getTipMenjaca()
        {
            return this.TipMenjaca;
        }

        public void setTipMenjaca(string tipMenjaca)
        {
            this.TipMenjaca = tipMenjaca;
        }

        public string getTipGoriva()
        {
            return this.TipGoriva;
        }

        public void setTipGoriva(string tipGoriva)
        {
            this.TipGoriva = tipGoriva;
        }

        public void autoToString()
        {
            base.toString();
            Console.WriteLine("Auto: " + this.getMarka() + " " + this.getModel() + " " + this.getRegistracija() +
                                     ", Broj Vrata: " + this.BrojVrata +
                                     ", Broj Sedista: " + this.BrojSedista +
                                     ", Tip Menjaca: " + this.TipMenjaca +
                                     ", Tip Goriva: " + this.TipGoriva +
                                     ", Brzina: " + this.getBrzina());
        }

    }
}