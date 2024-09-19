namespace Library.Items.Armaduras_o_Ropajes;

public class ArmaduraDelBosque
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetDefense() 
    {
        return this.valorDefensa;
    }
    public int GetMagic() 
    {
        return this.valorMagia;
    }
    
    //Construtor
    public ArmaduraDelBosque() 
    {
        this.valorAtaque = 0; 
        this.valorMagia = 10;
        this.valorDefensa= 55;
    }
}