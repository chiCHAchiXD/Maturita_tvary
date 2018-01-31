 

public class Kruh extends Tvar
{
    public Kruh()
    {
        super();
    }
    
    public Kruh(int sirka)
    {
        //super();
        //this.sirka = sirka;
        //this.vyska = sirka;
        super(sirka, sirka);
    }    
    
    @Override
    public void nakreslit()
    {
        //System.out.println("kruh o polomeru=" + this.sirka/2.0  + " nejde jednoduse nakreslit\n");
        System.out.println("kruh neni jednoduche v konsoli nakreslit\n");
    }

    @Override
    public double vypocitatObvod()
    {
        double obvod = 3.14 * this.sirka;
        return obvod;
    }

    @Override
    public double vypocitatObsah()
    {
        double r = this.sirka / 2.0;
        double obsah = 3.14 * r * r;
        return obsah;
    }

    @Override
    public String toString()
    {
        return "kruh: " + super.toString();
    }
}
