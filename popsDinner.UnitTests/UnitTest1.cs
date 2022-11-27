using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using popsDiner.Models;

namespace popsDinner.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var connectionstring = "Server=WIN-S12PPN71OHI\\CRISTIAN;Database=PopsDinerShop;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var bl = new ItemRepository(db);

                Assert.AreEqual(15, bl.GetItemById(15).ItemId);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var connectionstring = "Server=WIN-S12PPN71OHI\\CRISTIAN;Database=PopsDinerShop;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var bl = new ItemRepository(db);

                Assert.AreEqual("Burger", bl.GetItemByName("Burger").Name);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var connectionstring = "Server=WIN-S12PPN71OHI\\CRISTIAN;Database=PopsDinerShop;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);


            using (var db = new AppDbContext(optionsBuilder.Options))
            {
                var bl = new ItemRepository(db);

                Assert.AreEqual(123, bl.GetItemByPrice(123).Price);
            }
        }

    }
}
