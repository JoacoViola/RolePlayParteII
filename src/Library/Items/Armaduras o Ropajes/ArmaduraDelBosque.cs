namespace Library.Items.Armaduras_o_Ropajes;

public class ArmaduraDelBosque : IItem
{
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    
    //Construtor
    public ArmaduraDelBosque() 
    {
        this.ValorAtaque = 0; 
        this.ValorMagia = 10;
        this.ValorDefensa= 55;
    }

    
}