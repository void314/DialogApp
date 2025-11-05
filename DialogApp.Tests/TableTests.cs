using DialogApp.BLL;
using DialogApp.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class DalTests
{
    [Test]
    public void GetTables_ShouldReturn_AllThreeTables()
    {
        // Arrange
        var repository = new TableRepository();
        int expectedCount = 3; // Мы знаем, что в фиктивном списке 3 столика

        // Act
        var result = repository.GetTables();

        // Assert
        Assert.That(result.Count, Is.EqualTo(expectedCount), "DAL должен вернуть 3 элемента.");
    }
}

[TestFixture]
public class BllIntegrationTests
{
    [Test]
    public void GetAllAvailableTables_ShouldFilterOut_VIPTables()
    {
        // Arrange
        var manager = new TableManager();
        int expectedCount = 2; // BLL должен отфильтровать 1 VIP столик (3-1=2)

        // Act
        var result = manager.GetAllAvailableTables();

        // Assert
        Assert.That(result.Count, Is.EqualTo(expectedCount), "BLL должен применить бизнес-правило и вернуть только 2 доступных столика.");
        Assert.That(result.Any(t => t.Contains("VIP")), Is.False, "В списке не должно быть VIP столиков.");
    }
}