using Library.Items.Armaduras_o_Ropajes;
using Library.Items.Armas_o_Artefactos;
using Library.Personajes;
using NUnit.Framework;
namespace UnitTests;

public class TestMago
{
    [Test]
    public void TestDeConstructorYGetters()
    {
        Mago mago = new Mago("HarryPotter");
        Assert.That(mago.Nombre, Is.EqualTo("HarryPotter"));
        Assert.That(mago.ValorVida, Is.EqualTo(170));
        Assert.That(mago.ValorMagia, Is.EqualTo(25));
        Assert.That(mago.ValorAtaque, Is.EqualTo(35));
        Assert.That(mago.ValorDefensa, Is.EqualTo(22));
    }

    [Test]
    public void MagoAtacadoYCurado()
    {
        Mago mago = new Mago("Harry Potter");
        mago.SufrirDaño(50);
        Assert.That(mago.ValorVida, Is.EqualTo(124)); // le resta 46 por la defensa
        mago.RecuperarVida(26);
        Assert.That(mago.ValorVida, Is.EqualTo(150)); // le suma 26
    }
    
    [Test]
    public void AgregarYQuitarItems()
    {
        Mago mago = new Mago("Harry Potter");
        
        LibroDeHechizos libro = new LibroDeHechizos();
        BastonMagico baston = new BastonMagico();
        TunicaDeCuero tunica = new TunicaDeCuero();
        CuchillasDobles cuchillos = new CuchillasDobles();
        MartilloPesado martillo = new MartilloPesado();
        
        libro.AgregarHechizo(new Hechizo("Aturdir", 10)); 
        libro.AgregarHechizo(new Hechizo("Incinerar", 13));
        libro.AgregarHechizo(new Hechizo("Congelar", 10));
        libro.AgregarHechizo(new Hechizo("Clonar", 2));
        libro.AgregarHechizo(new Hechizo("Sepultar", 5));
        mago.AgregarItem(libro);
        mago.AgregarItem(baston);
        mago.AgregarItem(tunica);
        mago.AgregarItem(cuchillos);     // Chequea que acepte cualquier item, sin restricción
        
        Assert.That(mago.Inventario.Count, Is.EqualTo(4));  // debe agregar solo 3, el bastón no
        Assert.That(mago.ValorMagia, Is.EqualTo(155));      // le suma 70 + 40 + 20 
        Assert.That(mago.ValorAtaque, Is.EqualTo(230));     // le suma 65 + 130
        Assert.That(mago.ValorDefensa, Is.EqualTo(127));    // le suma 40 + 130 / 2
        
        mago.QuitarItem(libro);
        mago.QuitarItem(baston);
        mago.QuitarItem(tunica);
        mago.QuitarItem(cuchillos);
        mago.QuitarItem(martillo);
        
        Assert.That(mago.Inventario.Count, Is.EqualTo(0));  // el inventario queda vacío
        Assert.That(mago.ValorMagia, Is.EqualTo(25));       // vuelve al valor inicial
        Assert.That(mago.ValorAtaque, Is.EqualTo(35));      // vuelve al valor inicial
        Assert.That(mago.ValorDefensa, Is.EqualTo(22));     // vuelve al valor inicial
    }
}
