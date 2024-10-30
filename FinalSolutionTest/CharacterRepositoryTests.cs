using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using TheFinalSolution.DataAccessLayer;
using TheFinalSolution.Entities;
using TheFinalSolution.Repository;
using TheFinalSolution.Repository.Interfaces;

namespace FinalSolutionTest;

public class CharacterRepositoryTests
{
    Mock<RpgContext>? _contextMock;
    
    [SetUp]
    public void Setup()
    {
        _contextMock = new Mock<RpgContext>();
        _contextMock.Setup<DbSet<Character>>(x => x.Characters)
            .ReturnsDbSet(new List<Character>
            {
                new Character
                {
                    Id = Guid.Parse("b6335947-12b4-4e90-a41c-2fd48de69704"),
                    Name = "Jack",
                    Class = "Mage",
                    Stamina = 100
                }
            });
    }

    [Test]
    public void CanGetCharacterById()
    {
       // Arrange
       ICharacterRepository repo = new CharacterRepository(_contextMock.Object);
       var actual = new Character
       {
           Id = Guid.Parse("b6335947-12b4-4e90-a41c-2fd48de69704"),
           Name = "Jack",
           Class = "Mage",
           Stamina = 100
       };

       // Act
       var expected = repo.GetById(Guid.Parse("b6335947-12b4-4e90-a41c-2fd48de69704"));

       // Assert 
       Assert.That(expected.Stamina, Is.EqualTo(actual.Stamina));
    }
}