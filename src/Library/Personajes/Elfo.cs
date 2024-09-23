using Library.Items;

namespace Library.Personajes;

public class Elfo : IPersonaje
{
    public string Nombre{ get; set; }
    public int ValorVida{ get; set; }
    public List<IItem> Inventario{ get; }
    public int ValorMagia{ get; set; }
    public int ValorAtaque{ get; set; }
    public int ValorDefensa{ get; set; }
    
    //Constructor
    public Elfo(string nombreDelElfo)
    {
        this.Nombre = nombreDelElfo;
        this.ValorVida = 200;
        this.ValorMagia = 10;
        this.ValorAtaque = 15 + ValorMagia;
        this.ValorDefensa = 20 + ValorMagia/2;
        this.Inventario = new List<IItem>();
    }
    
    //Ser atacado
    public void SufrirDaño(int daño)
    {
        daño -= this.ValorDefensa / 5;
        this.ValorVida -= daño; 
    }

    //Ser curado
    public void RecuperarVida(int vida)
    {
        this.ValorVida += vida;
    }

    //Agregar Items al Inventario
    public void AgregarItem(IItem item)
    {
        if (item.EsMagico)      // Tiene la restricción de no poder portar items mágicos
        {
            Console.WriteLine("Este personaje no puede usar objetos mágicos");
        }
        else
        {
            this.Inventario.Add(item);
            this.ValorMagia += item.ValorMagia;
            this.ValorAtaque += item.ValorAtaque + item.ValorMagia;
            this.ValorDefensa += item.ValorDefensa + item.ValorMagia/2;
        }
    }

    //Remover Items del Inventario
    public void QuitarItem(IItem item)
    {
        int aux = this.Inventario.IndexOf(item);
        if (aux != 1)
        {
            this.Inventario.Remove(item);
            this.ValorMagia -= item.ValorMagia;
            this.ValorAtaque -= item.ValorAtaque + item.ValorMagia;
            this.ValorDefensa -= item.ValorDefensa + item.ValorMagia/2;
        }
        else
        {
            Console.WriteLine("El item no está en el inventario");
        }
    }
}