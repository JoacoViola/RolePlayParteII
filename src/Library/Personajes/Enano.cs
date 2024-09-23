using Library.Items;
namespace Library.Personajes;

public class Enano : IPersonaje
{
    public string Nombre{ get; set; }
    public int ValorVida { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorMagia { get; set; }
    public List<IItem> Inventario { get; }
    
    //Constructor
    public Enano(string nombreDelEnano)
    {
        this.Nombre = nombreDelEnano;
        this.ValorVida = 230;
        this.ValorMagia = 0;
        this.ValorAtaque = 25;
        this.ValorDefensa = 30;
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