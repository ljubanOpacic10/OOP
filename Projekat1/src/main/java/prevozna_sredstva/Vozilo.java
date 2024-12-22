package prevozna_sredstva;

public abstract class Vozilo {
	private String Ime;
	private String RegistarskeTablice;
	private String Marka;
	
	public Vozilo() {
		
	}
	
	public Vozilo(String ime, String registarskeTablice, String marka) {
		super();
		this.Ime = ime;
		this.RegistarskeTablice = registarskeTablice;
		this.Marka = marka;
	}

	abstract void Ubrzaj(int povecanjeBrzine);
	abstract void Uspori(int smanjenjeBrzine);
	
	public String getIme() {
		return Ime;
	}
	public void setIme(String ime) {
		Ime = ime;
	}
	public String getRegistarskeTablice() {
		return RegistarskeTablice;
	}
	public void setRegistarskeTablice(String registarskeTablice) {
		RegistarskeTablice = registarskeTablice;
	}
	public String getMarka() {
		return Marka;
	}
	public void setMarka(String marka) {
		Marka = marka;
	}

	@Override
	public String toString() {
		return "Vozilo [Ime=" + Ime + ", RegistarskeTablice=" + RegistarskeTablice + ", Marka=" + Marka + "]";
	}
	
	
	
	
}
