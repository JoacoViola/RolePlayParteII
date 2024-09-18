namespace Program.Items.Armaduras_o_Ropajes;

public class TunicaDeCuero
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
    public TunicaDeCuero() 
    {
        this.valorAtaque = 0; 
        this.valorMagia = 20;
        this.valorDefensa= 40;
    }
}