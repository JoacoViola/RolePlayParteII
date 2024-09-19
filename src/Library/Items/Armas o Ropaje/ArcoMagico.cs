namespace Library.Items.Armas_o_Artefactos;

public class ArcoMagico
{
    private int valorAtaque;
    private int valorDefensa;
    private int valorMagia;
   
    //Getters
    public int GetDamage()
    {
        return this.valorAtaque;
    }
    public int GetMagic()
    {
        return this.valorMagia;
    }
    
    //Construtor
    public ArcoMagico() 
    {
        this.valorAtaque = 60; 
        this.valorMagia = 20;
        this.valorDefensa= 0;
    }
}