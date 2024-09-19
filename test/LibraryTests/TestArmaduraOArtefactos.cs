using Program.Items.Armas_o_Artefactos;

namespace UnitTests;

public class TestArmasOArtefactos
{
    [Test]
    public void BastonMagico_ConstructorYGetters() 
    {
        BastonMagico baston = new BastonMagico();
        Assert.That(baston.GetMagic(), Is.EqualTo(70));
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
        Assert.That(arco.GetDamage(), Is.EqualTo(60));
        Assert.That(arco.GetMagic(), Is.EqualTo(20));
    }
    
    [Test]
    public void CuchillasDobles_ConstructorYGetters()
    {
        CuchillasDobles cuchillas = new CuchillasDobles();
        Assert.That(cuchillas.GetDamage(), Is.EqualTo(65));
    }
    
    [Test]
    public void HachaDeCombate_ConstructorYGetters()
    {
        HachaDeCombate hacha = new HachaDeCombate();
        Assert.That(hacha.GetDamage(), Is.EqualTo(75));
    }
    
    [Test]
    public void MartilloPesado_ConstructorYGetters()
    {
        MartilloPesado martillo = new MartilloPesado();
        Assert.That(martillo.GetDamage(), Is.EqualTo(90));
        Assert.That(martillo.GetDefense(), Is.EqualTo(20));
    }