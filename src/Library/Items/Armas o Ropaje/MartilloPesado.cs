namespace Library.Items.Armas_o_Artefactos;

public class MartilloPesado
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetDamage() 
    {
        return this.valorAtaque;
    }
    public int GetDefense()
    {
        return this.valorDefensa;
    }
    
    //Construtor
    public MartilloPesado() 
    {
        this.valorAtaque = 90; 
        this.valorMagia = 0;
        this.valorDefensa= 20;
    }
}