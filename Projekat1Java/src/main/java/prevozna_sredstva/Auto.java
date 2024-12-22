package prevozna_sredstva;

public class Auto extends Vozilo {
	private String Model;
	private int Brzina;
	private int BrojVrata;
	private String Karoserija;

	//konstruktor, koristi se da bi instancirao objekat ove klase
	//prefiks this. sluzi kako bi kompajler znao kojoj vrednosti dodeljujemo koju, jer se isto zovu pa da ih ne pomesa
	//potrebno je dakle obelezju iz ove klase dodeliti prosldjenu vrednost iz konstruktora, a ne obrnuto.
	public Auto(String ime, String registarskeTablice, String marka, String model, String Karoserija, int brzina, int brojVrata) {
		super( ime,  registarskeTablice,  marka);
		this.Model = model;
		this.Brzina = brzina;
		this.BrojVrata = brojVrata;
		this.Karoserija = Karoserija;
	}
	
	public Auto() {
		//default konstruktor, nema nikakve parametre
	}
	//ovo su primeri preklopljenih konstruktora, isto se zovu samo primaju razlicite parametre
	// recimo ovaj ces koristiti kad neces da postavis broj vrata i brzinu odmah pri kreiranju objekta
	public Auto(String ime, String registarskeTablice, String marka, String model, String Karoserija) {
		super( ime,  registarskeTablice,  marka);
		this.Model = model;
		this.Karoserija = Karoserija;
	}

	//implementacija nadredjene metode, ovde se postuje pravilo polimorfizma, ovu metodu ce drugacije da izvrsava svaka klasa koja nasledjuje Vozilo
	//istu radnju objekti razlictih klasa rade na razlicite nacine, motori na jedan nacin a auti na drugi
	@Override
	void Ubrzaj(int povecanjeBrzine) {
		Brzina = Brzina + povecanjeBrzine;
		System.out.println(this.toString());
	}

	@Override
	void Uspori(int smanjenjeBrzine) {
		Brzina = Brzina - smanjenjeBrzine;
		System.out.println(this.toString());
	}

	//getteri i setteri, sluze za dohvatanje i menjanje objekta ove klase, ovo postuje princip ucaurenja
	public String getModel() {
		return Model;
	}

	public void setModel(String model) {
		Model = model;
	}

	public int getBrzina() {
		return Brzina;
	}

	public void setBrzina(int brzina) {
		Brzina = brzina;
	}

	@Override
	public String toString() {
		return super.toString() + "Auto [Model=" + Model + ", Brzina="  + ", Karoserija= " + Karoserija + ", Brzina= " + Brzina +  ", Broj vrata= " + BrojVrata + "]";
	}

}
