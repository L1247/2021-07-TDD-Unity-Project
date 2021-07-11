using Game.Scripts.Domain;
using NUnit.Framework;
using Utilities.Contract;

public class CharacterTests
{
    [Test]
    public void CreateCharacter_Should_Have_Hp()
    {
        var character = new Character(999);
        Assert.AreEqual(999 , character.CurrentHp);
    }

    [Test]
    public void DealDamage_With_Passtive_Number()
    {
        var character = new Character(100);
        character.DealDamage(9);
        Assert.AreEqual(91 , character.CurrentHp);
    }

    [Test]
    public void DealDamage_With_Negetive_Number()
    {
        var character = new Character(100);
        Assert.Throws<PreconditionViolationException>(() =>
        {
            character.DealDamage(-5);
        });
    }
}