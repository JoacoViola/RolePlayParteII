namespace Library.Items.Armas_o_Artefactos;

public class Hechizo : IItem
{
    public string Nombre { get; }
    public int ValorAtaque { get; }
    public int ValorDefensa { get; }
    public int ValorMagia { get; }
    
    //Constructor
    public Hechizo(string nombre, int valMagia)
    {
        this.Nombre = nombre;
        this.ValorAtaque = 0;
        this.ValorDefensa = 0;
        this.ValorMagia = valMagia;
    }
}