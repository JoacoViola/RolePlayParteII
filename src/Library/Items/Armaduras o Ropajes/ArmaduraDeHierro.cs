namespace Library.Items.Armaduras_o_Ropajes;

public class ArmaduraDeHierro : IItem
{
    public bool EsMagico { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Construtor
    public ArmaduraDeHierro()
    {
        this.EsMagico = false;
        this.ValorAtaque = 0; 
        this.ValorMagia = 0;
        this.ValorDefensa= 80;
    }
}