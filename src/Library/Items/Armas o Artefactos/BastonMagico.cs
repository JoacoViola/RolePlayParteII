namespace Library.Items.Armas_o_Artefactos;

public class BastonMagico : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get;  }
    public int ValorMagia { get; }

    //Construtor
    public BastonMagico()
    {
        this.ValorAtaque = 0; 
        this.ValorDefensa= 0;
        this.ValorMagia = 70;
    }
}