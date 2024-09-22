namespace Library.Items.Armas_o_Artefactos;

public class CuchillasDobles : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    
    //Construtor
    public CuchillasDobles() 
    {
        this.ValorAtaque = 65; 
        this.ValorMagia = 0;
        this.ValorDefensa= 0;
    }

    
}