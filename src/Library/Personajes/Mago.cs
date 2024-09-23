using Library.Items;

namespace Library.Personajes;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int ValorVida { get; set; }
    public int ValorMagia { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public List<IItem> Inventario { get; }

    //Constructor
    public Mago(string nombreDelMago)
    {
        this.Nombre = nombreDelMago;
        this.ValorVida = 170;
        this.ValorMagia = 25;
        this.ValorAtaque = 10 + ValorMagia;
        this.ValorDefensa = 10 + ValorMagia/2;
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
    public void AgregarItem(IItem item)     // No tiene restricciones, puede aceptar cualquier item
    {
        this.Inventario.Add(item); 
        this.ValorMagia += item.ValorMagia;
        this.ValorAtaque += item.ValorAtaque + item.ValorMagia;
        this.ValorDefensa += item.ValorDefensa + item.ValorMagia/2;
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
