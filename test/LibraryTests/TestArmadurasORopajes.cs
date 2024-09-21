using Library.Items.Armaduras_o_Ropajes;
using NUnit.Framework;
namespace UnitTests;

public class TestArmadurasORopajes
{
    [Test]
    public void TunicaDeCuero_ConstructorYGetters()
    {
        TunicaDeCuero tunica = new TunicaDeCuero();
        Assert.That(tunica.GetMagic(), Is.EqualTo(20));
        Assert.That(tunica.GetDefense(), Is.EqualTo(40));
    }
    
    [Test]
    public void ArmaduraDelBosque_ConstructorYGetters()
    {
        ArmaduraDelBosque armadura = new ArmaduraDelBosque();
        Assert.That(armadura.GetMagic(), Is.EqualTo(10));
        Assert.That(armadura.GetDefense(), Is.EqualTo(55));
    }
    
    [Test]
    public void ArmaduraDeHierro_ConstructorYGetters()
    {
        ArmaduraDeHierro armadura = new ArmaduraDeHierro();
        Assert.That(armadura.GetDefense(), Is.EqualTo(80));
    }
}