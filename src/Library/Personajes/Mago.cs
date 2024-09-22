using Library.Items;
using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
namespace Library.Personajes;

public class Mago : IPersonaje
{
    public string Nombre { get; set; }
    public int ValorVida { get; set; }
    public int ValorMagia { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public IList<IItem> Inventario { get; }

    //Constructor
    public Mago(string nombreDelMago)
    {
        this.Nombre = nombreDelMago;
        this.ValorVida = 170;
        this.ValorMagia = 25;
        this.ValorAtaque = 10 + ValorMagia;
        this.ValorDefensa = 10 + ValorMagia/2;
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
    public void AgregarBastonMagico(BastonMagico baston)
    {
        this.Inventario.Add(baston);
        this.ValorMagia += baston.ValorMagia;
        this.ValorAtaque += baston.ValorMagia;
        this.ValorDefensa += baston.ValorMagia/2;
    }
    public void AgregarLibroDeHechizos(LibroDeHechizos libro)
    {
        this.Inventario.Add(libro);
        this.ValorMagia += 2 * (libro.GetNumeroHechizos());
        this.ValorAtaque += 2 * (libro.GetNumeroHechizos());
        this.ValorDefensa += libro.GetNumeroHechizos();
    }
    public void AgregarTunicaDeCuero(TunicaDeCuero tunica)
    {
        this.Inventario.Add(tunica);
        this.ValorDefensa += tunica.ValorDefensa;
        this.ValorMagia += tunica.ValorMagia;
        this.ValorAtaque += tunica.ValorMagia;
        this.ValorDefensa += tunica.ValorMagia/2;
    }
    
    //Remover Items del Inventario
    public void QuitarBastonMagico(BastonMagico baston)
    {
        int aux = this.Inventario.IndexOf(baston);
        if (aux != 1)
        {
            this.Inventario.Remove(baston);
            this.ValorMagia -= baston.ValorMagia;
            this.ValorAtaque -= (baston.ValorMagia);
            this.ValorDefensa -= (baston.ValorMagia/2);
        }
    }
    public void QuitarLibroHechizos(LibroDeHechizos libro)
    {
        int aux = this.Inventario.IndexOf(libro);
        if (aux != 1)
        {
            this.Inventario.Remove(libro);
            this.ValorMagia -= 2 * (libro.GetNumeroHechizos());
            this.ValorAtaque -= 2 * (libro.GetNumeroHechizos());
            this.ValorDefensa -= libro.GetNumeroHechizos();
        }
    }
    public void QuitarTunicaDeCuero(TunicaDeCuero tunica)
    {
        int aux = this.Inventario.IndexOf(tunica);
        if (aux != 1)
        {
            this.Inventario.Remove(tunica);
            this.ValorDefensa -= tunica.ValorDefensa;
            this.ValorMagia -= tunica.ValorMagia;
            this.ValorAtaque -= (tunica.ValorMagia);
            this.ValorDefensa -= (tunica.ValorMagia/2);
        }
    }
}