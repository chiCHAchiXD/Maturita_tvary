 

import java.util.Scanner;

public class Program
{
    public static void main(String[] args)
    {
        //interaktivni zadavani hodnot
        Scanner sc = new Scanner(System.in);
        
        System.out.println("---start programu---\n");     

        System.out.println("VSTUPY");
        System.out.print("obdelnik1 zadej sirka=");
        int sirka = sc.nextInt(); 
        System.out.print("obdelnik1 zadej vyska=");
        int vyska = sc.nextInt();     
        //System.out.println();  
         //test tridy Obdelnik
         Obdelnik o1 = new Obdelnik(sirka, vyska);
//         System.out.println(o1.toString());
//         System.out.println("obvod " + o1.vypocitatObvod());
//         System.out.println("obsah " + o1.vypocitatObsah());
//         o1.nakreslit();     
//         System.out.println();
        
        System.out.print("ctverec1 zadej sirka=");
        sirka = sc.nextInt();         
        //System.out.println();  
         //test tridy Ctverec
        Ctverec c1 = new Ctverec(sirka);
//         System.out.println(c1.toString());
//         System.out.println("obvod " + c1.vypocitatObvod());
//         System.out.println("obsah " + c1.vypocitatObsah());
//         c1.nakreslit();     
//         System.out.println();    
        
        System.out.print("kruh1 zadej sirka=");
        sirka = sc.nextInt();       
        //System.out.println();  
        //test tridy Kruh
        Kruh k1 = new Kruh(sirka);
//         System.out.println(k1.toString());
//         System.out.println("obvod " + k1.vypocitatObvod());
//         System.out.println("obsah " + k1.vypocitatObsah());
//         k1.nakreslit();
//         System.out.println();
        
        System.out.println("\nZPRACOVANI A VYSTUPY");
        //1.
        Tvar[] poleTvaru = new Tvar[6];
        
        //2.
        poleTvaru[0] = o1;
        poleTvaru[1] = new Obdelnik(10, 1);
        poleTvaru[2] = c1;
        poleTvaru[3] = new Ctverec(3);
        poleTvaru[4] = k1;
        poleTvaru[5] = new Kruh(8);
        //3.
        for (int i = 0; i < poleTvaru.length; i++)
        {
            System.out.println("metoda toString() pro => " + poleTvaru[i].toString());
            System.out.println("obvod je " + poleTvaru[i].vypocitatObvod());            
            System.out.println("obsah je " + poleTvaru[i].vypocitatObsah());
            poleTvaru[i].nakreslit();         
        }     
        
        System.out.println("---konec programu---");
    }
}
