using System;

namespace my_csharp_project.src.prevozna_sredstva
{
    public class Motor : Vozilo
    {
        private int ZapreminaMotora { get; set; }
        private string TipMotora { get; set; }
        private string TipMenjaca { get; set; }
        private string TipGoriva { get; set; }

        public Motor() : base()
        {
            this.ZapreminaMotora = 0;
            this.TipMotora = "";
            this.TipMenjaca = "";
            this.TipGoriva = "";
        }
        public Motor(string registracija, string marka, string model, int godinaProizvodnje, double kilometraza, double zapreminaRezervoara, double potrosnjaGoriva, int zapreminaMotora, string tipMotora, string tipMenjaca, string tipGoriva) : base(registracija, marka, model, godinaProizvodnje, kilometraza, zapreminaRezervoara, potrosnjaGoriva)
        {
            this.ZapreminaMotora = zapreminaMotora;
            this.TipMotora = tipMotora;
            this.TipMenjaca = tipMenjaca;
            this.TipGoriva = tipGoriva;
        }
        public override void Ubrzaj(int kmh)
        {
            this.setBrzina(this.getBrzina() + kmh);
            Console.WriteLine("Motor je ubrzao na " + this.getBrzina() + " km/h");
        }

        public int getZapreminaMotora()
        {
            return this.ZapreminaMotora;
        }

        public void setZapreminaMotora(int zapreminaMotora)
        {
            this.ZapreminaMotora = zapreminaMotora;
        }

        public string getTipMotora()
        {
            return this.TipMotora;
        }

        public void setTipMotora(string tipMotora)
        {
            this.TipMotora = tipMotora;
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

        public void motorToString()
        {
            base.toString();
            Console.WriteLine("Zapremina motora: " + this.getZapreminaMotora());
            Console.WriteLine("Tip motora: " + this.getTipMotora());
            Console.WriteLine("Tip menjaca: " + this.getTipMenjaca());
            Console.WriteLine("Tip goriva: " + this.getTipGoriva());
        }

    }
}