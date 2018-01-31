
public class Ctverec extends Obdelnik
{    
    public Ctverec()
    {
        super();
    }
    
    public Ctverec(int sirka)
    {
        //super();
        //this.sirka = sirka;
        //this.vyska = sirka;
        super(sirka, sirka);
    }
    
    @Override
    public String toString()
    {
        return "ctverec je specialni -> " + super.toString();
    }    
}
