using Library.Items.Armas_o_Artefactos;
using NUnit.Framework;
namespace UnitTests;

public class TestArmasOArtefactos
{
    [Test]
    public void BastonMagico_ConstructorYGetters()
    {
        BastonMagico baston = new BastonMagico();
        Assert.That(baston.ValorMagia, Is.EqualTo(70));
        Assert.That(baston.ValorDefensa, Is.EqualTo(0));
        Assert.That(baston.ValorAtaque, Is.EqualTo(0));
        Assert.That(baston.EsMagico, Is.EqualTo(true));
    }
    

    [Test]
    public void LibroDeHechizos_ConstructorYGetters()
    {
        LibroDeHechizos libro = new LibroDeHechizos();
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(0));
        Assert.That(libro.ValorDefensa, Is.EqualTo(0));
        Assert.That(libro.ValorAtaque, Is.EqualTo(0));
        Assert.That(libro.EsMagico, Is.EqualTo(true));
    }

    [Test]
    public void LibroDeHechizos_AgragarYQuitarHechizo()
    {
        LibroDeHechizos libro = new LibroDeHechizos();
        Hechizo escupitajo = new Hechizo("Escupitajus Pegajosus", 5);
        libro.AgregarHechizo(escupitajo);
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(1));
        libro.QuitarHechizo(escupitajo);
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(0));
    }

    [Test]
    public void Arco_ConstructorYGetters()
    {
        Arco arco = new Arco();
        Assert.That(arco.ValorAtaque, Is.EqualTo(60));
        Assert.That(arco.ValorMagia, Is.EqualTo(0));
        Assert.That(arco.ValorDefensa, Is.EqualTo(0));
        Assert.That(arco.EsMagico, Is.EqualTo(false));
    }

    [Test]
    public void CuchillasDobles_ConstructorYGetters()
    {
        CuchillasDobles cuchillas = new CuchillasDobles();
        Assert.That(cuchillas.ValorAtaque, Is.EqualTo(65));
        Assert.That(cuchillas.ValorMagia, Is.EqualTo(0));
        Assert.That(cuchillas.ValorDefensa, Is.EqualTo(0));
        Assert.That(cuchillas.EsMagico, Is.EqualTo(false));
    }

    [Test]
    public void HachaDeCombate_ConstructorYGetters()
    {
        HachaDeCombate hacha = new HachaDeCombate();
        Assert.That(hacha.ValorAtaque, Is.EqualTo(75));
        Assert.That(hacha.ValorMagia, Is.EqualTo(0));
        Assert.That(hacha.ValorDefensa, Is.EqualTo(0));
        Assert.That(hacha.EsMagico, Is.EqualTo(false));
    }

    [Test]
    public void MartilloPesado_ConstructorYGetters()
    {
        MartilloPesado martillo = new MartilloPesado();
        Assert.That(martillo.ValorAtaque, Is.EqualTo(90));
        Assert.That(martillo.ValorDefensa, Is.EqualTo(20));
        Assert.That(martillo.ValorMagia, Is.EqualTo(0));
        Assert.That(martillo.EsMagico, Is.EqualTo(false));
    }
}