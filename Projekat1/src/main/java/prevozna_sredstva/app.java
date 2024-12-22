package prevozna_sredstva;

public class app {

	public static void main(String[] args) {
		Vozilo bmvX3 = new Auto("BMW X3", "LO/041/KB", "BMW", "X3", "Dzip", 0, 5);
		bmvX3.Ubrzaj(100);
		bmvX3.Uspori(20);
		
		//Vozilo harleyDavidson = new Motor();
		//harleyDavidson.Ubrzaj(100);	
		//harleyDavidson.Uspori(20);
		
		//ovde dodaj jos neke operacije na ovim objektima i mozes jos razl objekata napraviti
	}

}
