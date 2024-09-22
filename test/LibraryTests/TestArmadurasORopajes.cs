using Library.Items.Armaduras_o_Ropajes;
using NUnit.Framework;
namespace UnitTests;

public class TestArmadurasORopajes
{
    [Test]
    public void TunicaDeCuero_ConstructorYGetters()
    {
        TunicaDeCuero tunica = new TunicaDeCuero();
        Assert.That(tunica.ValorMagia, Is.EqualTo(20));
        Assert.That(tunica.ValorDefensa, Is.EqualTo(40));
    }
    
    [Test]
    public void ArmaduraDelBosque_ConstructorYGetters()
    {
        ArmaduraDelBosque armadura = new ArmaduraDelBosque();
        Assert.That(armadura.ValorMagia, Is.EqualTo(10));
        Assert.That(armadura.ValorDefensa, Is.EqualTo(55));
    }
    
    [Test]
    public void ArmaduraDeHierro_ConstructorYGetters()
    {
        ArmaduraDeHierro armadura = new ArmaduraDeHierro();
        Assert.That(armadura.ValorDefensa, Is.EqualTo(80));
    }
}