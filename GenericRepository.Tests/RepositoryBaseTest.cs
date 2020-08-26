using GenericRepository.DataAccess;
using GenericRepository.Entities;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;

namespace GenericRepository.Tests
{
    [TestClass]
    public class RepositoryBaseTest
    {
        [TestMethod]
        public void Composition()
        {
            NorthwindContext context = new NorthwindContext();
            RepositoryBase<Suppliers> repo = new RepositoryBase<Suppliers>(context);
            Assert.IsNotNull(repo.Context);
        }

        [TestMethod]
        public void GetAllSuppliers()
        {
            NorthwindContext context = new NorthwindContext();
            RepositoryBase<Suppliers> repo = new RepositoryBase<Suppliers>(context);
            int count = repo.GetAll().Count();
            Assert.AreEqual(30, count);
        }

        [TestMethod]
        public void GetSupplierById()
        {
            string expectedCompanyName =  "Lyngbysild";
            int expectedSupplierID = 21;

            NorthwindContext context = new NorthwindContext();
            RepositoryBase<Suppliers> repo = new RepositoryBase<Suppliers>(context);

            Suppliers s = repo.GetBy(expectedSupplierID);
            Assert.AreEqual(expectedSupplierID, s.SupplierId);
            Assert.AreEqual(expectedCompanyName, s.CompanyName);
        }
    }
}