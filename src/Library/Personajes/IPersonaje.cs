using Library.Items;
namespace Library.Personajes;

public interface IPersonaje
{
    int ValorVida { get; set; }
    string Nombre { get; set; }
    int ValorAtaque { get; set; }
    int ValorDefensa { get; set; }
    int ValorMagia { get; set; }
    IList<IItem> Inventario { get; }
    void SufrirDaño(int daño);
    void RecuperarVida(int vida);
    
}