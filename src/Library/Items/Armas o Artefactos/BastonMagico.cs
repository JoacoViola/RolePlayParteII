namespace Library.Items.Armas_o_Artefactos;

public class BastonMagico : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get;  }
    public int ValorMagia { get; }

    //Construtor
    public BastonMagico()
    {
        this.EsMagico = true;
        this.ValorAtaque = 0; 
        this.ValorDefensa= 0;
        this.ValorMagia = 70;
    }
}