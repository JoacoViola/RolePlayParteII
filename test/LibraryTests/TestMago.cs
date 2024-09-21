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
        Assert.That(mago.GetName(), Is.EqualTo("HarryPotter"));
        Assert.That(mago.GetHealth(), Is.EqualTo(170));
        Assert.That(mago.GetMagic(), Is.EqualTo(25));
        Assert.That(mago.GetDamage(), Is.EqualTo(35));
        Assert.That(mago.GetDefense(), Is.EqualTo(22));
    }

    [Test]
    public void MagoAtacadoYCurado()
    {
        Mago mago = new Mago("Harry Potter");
        mago.SufrirDaño(50);
        Assert.That(mago.GetHealth(), Is.EqualTo(124)); // le resta 46 por la defensa
        mago.RecuperarVida(26);
        Assert.That(mago.GetHealth(), Is.EqualTo(150)); // le suma 26
    }

    [Test]
    public void AgregarYQuitarBaston()
    {
        Mago mago = new Mago("Harry Potter");
        BastonMagico baston = new BastonMagico();
        mago.AgregarBastonMagico(baston);
        Assert.That(mago.GetMagic(), Is.EqualTo(95));   // le suma 70
        Assert.That(mago.GetDamage(), Is.EqualTo(105)); // le suma 70 (magia)
        Assert.That(mago.GetDefense(), Is.EqualTo(57)); // le suma 35 (mitad de la magia)
        mago.QuitarBastonMagico(baston);
        Assert.That(mago.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(mago.GetMagic(), Is.EqualTo(25));   // vuelve al valor inicial
        Assert.That(mago.GetDamage(), Is.EqualTo(35));  // vuelve al valor inicial
        Assert.That(mago.GetDefense(), Is.EqualTo(22)); // vuelve al valor inicial
    }
    
    [Test]
    public void AgregarYQuitarLibroDeHechizos()
    {
        Mago mago = new Mago("Harry Potter");
        LibroDeHechizos libro = new LibroDeHechizos();
        libro.AgregarHechizo("Aturdir"); 
        libro.AgregarHechizo("Incinerar");
        libro.AgregarHechizo("Congelar");
        libro.AgregarHechizo("Clonar");
        libro.AgregarHechizo("Sepultar");
        mago.AgregarLibroDeHechizos(libro);
        Assert.That(mago.GetMagic(), Is.EqualTo(35));   // le suma 10 (2 por cada hechizo)
        Assert.That(mago.GetDamage(), Is.EqualTo(45));  // le suma 10 (magia)
        Assert.That(mago.GetDefense(), Is.EqualTo(27)); // le suma 5 (mitad de la magia)
        mago.QuitarLibroHechizos(libro);
        Assert.That(mago.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(mago.GetMagic(), Is.EqualTo(25));   // vuelve al valor inicial
        Assert.That(mago.GetDamage(), Is.EqualTo(35));  // vuelve al valor inicial
        Assert.That(mago.GetDefense(), Is.EqualTo(22)); // vuelve al valor inicial
        
    }
    
    [Test]
    public void AgregarYQuitarTunicaDeCuero()
    {
        Mago mago = new Mago("Harry Potter");
        TunicaDeCuero tunica = new TunicaDeCuero();
        mago.AgregarTunicaDeCuero(tunica);
        Assert.That(mago.GetMagic(), Is.EqualTo(45));   // le suma 20
        Assert.That(mago.GetDamage(), Is.EqualTo(55));  // le suma 20 (magia)
        Assert.That(mago.GetDefense(), Is.EqualTo(72)); // le suma 10 (mitad de la magia)
        mago.QuitarTunicaDeCuero(tunica);
        Assert.That(mago.GetItemCount(),Is.EqualTo(0)); // el inventario queda vacío
        Assert.That(mago.GetMagic(), Is.EqualTo(25));   // vuelve al valor inicial
        Assert.That(mago.GetDamage(), Is.EqualTo(35));  // vuelve al valor inicial
        Assert.That(mago.GetDefense(), Is.EqualTo(22)); // vuelve al valor inicial
    }
}
