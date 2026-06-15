using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AddressBook;
namespace AddressBook.Tests
{
    [TestFixture]
    public class AddressBookManagerTests
    {
        [Test]
        public void Save_ThenLoad_ReturnsSameContact()
        {
            // Arrange - hazırlık
            var manager = new AddressBookManager();
            var original = new Contact { Name = "Meryem", Phone = "555-1234", Email = "meryem@example.com" };

            // Act - çalıştır
            string xml = manager.Save(original);
            Contact? loaded = manager.Load(xml);

            // Assert - doğrula
            Assert.That(loaded, Is.Not.Null);
            Assert.That(loaded!.Name, Is.EqualTo("Meryem"));
            Assert.That(loaded.Phone, Is.EqualTo("555-1234"));
            Assert.That(loaded.Email, Is.EqualTo("meryem@example.com"));
        }
    }
}
