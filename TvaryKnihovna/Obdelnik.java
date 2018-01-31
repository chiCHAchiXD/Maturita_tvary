 

public class Obdelnik extends Tvar
{
    public Obdelnik()
    {
        super();
    }
    
    public Obdelnik(int sirka, int vyska)
    {
        //super();
        //this.sirka = sirka;
        //this.vyska = vyska;
        super(sirka, vyska);
    }
    
    @Override
    public void nakreslit()
    {
        for (int y = 0; y < this.vyska; y++)
        {
            for (int x = 0; x < this.sirka; x++)
            {
                System.out.print("X");
            }
            System.out.println();
        }
        System.out.println();
    }

    @Override
    public double vypocitatObvod()
    {
        return 2 * (this.sirka + this.vyska);
    }

    @Override
    public double vypocitatObsah()
    {
        return this.sirka * this.vyska;
    }
    
    @Override
    public String toString()
    {
        return "obdelnik: " + super.toString();
    }    
}
