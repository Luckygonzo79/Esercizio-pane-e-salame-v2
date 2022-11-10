string Prodotto;
float Quantità=0, Prezzo;

Console.WriteLine("Che prodotto desidera? Pane oppure Salame");

    Prodotto = Console.ReadLine();

if (Prodotto == "Pane")
{
    Console.WriteLine("Quanti pz. desidera?");
    Quantità = Convert.ToSingle(Console.ReadLine());
    if(Quantità>0)
    {
        Prezzo = (float)(Quantità * 1.50);
        Console.WriteLine("Il prezzo è: " + Prezzo + " Euro");
    }
    else
    {
        Console.WriteLine("Quantità non disponibile");
    }
}

else
{
    if (Prodotto == "Salame")
    {
        Console.WriteLine("Quanti etti desidera?");
        Quantità = Convert.ToSingle(Console.ReadLine());

        if(Quantità>0)
        {
            Prezzo = (float)(Quantità * 2.50);
            Console.WriteLine("Il prezzo è: "+Prezzo+ " Euro");
        }
        else
        {
            Console.WriteLine("Quantità non disponibile");
        }
    }
    else
    {
        Console.WriteLine("Prodotto non disponibile");          
    }

}

    
 
