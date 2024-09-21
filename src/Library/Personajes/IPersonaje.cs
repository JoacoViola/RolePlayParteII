using Library.Items;
namespace Library.Personajes;

public interface IPersonaje
{
    string Nombre { get; set; }
    int ValorVida { get; set; }
    int ValorAtaque { get; set; }
    int ValorDefensa { get; set; }
    int ValorMagia { get; set; }
    IList<IItem> Inventario { get; }
    void SufrirDaño(int daño);
    void RecuperarVida(int vida);
}