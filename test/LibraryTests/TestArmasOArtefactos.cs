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
    }

    [Test]
    public void LibroDeHechizos_ConstructorYGetters()
    {
        LibroDeHechizos libro = new LibroDeHechizos();
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(0));
    }

    [Test]
    public void LibroDeHechizos_AgragarYQuitarHechizo()
    {
        LibroDeHechizos libro = new LibroDeHechizos();
        libro.AgregarHechizo("Escupitajus Pegajosus");
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(1));
        libro.QuitarHechizo("Escupitajus Pegajosus");
        Assert.That(libro.GetNumeroHechizos(), Is.EqualTo(0));
    }

    [Test]
    public void ArcoMagico_ConstructorYGetters()
    {
        ArcoMagico arco = new ArcoMagico();
        Assert.That(arco.ValorAtaque, Is.EqualTo(60));
        Assert.That(arco.ValorMagia, Is.EqualTo(20));
    }

    [Test]
    public void CuchillasDobles_ConstructorYGetters()
    {
        CuchillasDobles cuchillas = new CuchillasDobles();
        Assert.That(cuchillas.ValorAtaque, Is.EqualTo(65));
    }

    [Test]
    public void HachaDeCombate_ConstructorYGetters()
    {
        HachaDeCombate hacha = new HachaDeCombate();
        Assert.That(hacha.ValorAtaque, Is.EqualTo(75));
    }

    [Test]
    public void MartilloPesado_ConstructorYGetters()
    {
        MartilloPesado martillo = new MartilloPesado();
        Assert.That(martillo.ValorAtaque, Is.EqualTo(90));
        Assert.That(martillo.ValorDefensa, Is.EqualTo(20));
    }
}