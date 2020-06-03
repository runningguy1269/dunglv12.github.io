using Dapper;
using Dapper.FastCrud;
using MVCSample.Business.Entities;
using MVCSample.Business.Repositories.Session;
using Smooth.IoC.Repository.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCSample.Business.Repositories
{
    public interface ISupplierRepository : IRepository<Supplier, int>
    {
        IEnumerable<Supplier> GetAllSupplier();

        //IEnumerable<Supplier> GetSupplierName();
    }
    public class SupplierRepository : Repository<Supplier, int>, ISupplierRepository
    {
        public SupplierRepository(IDbFactory factory) : base(factory)
        {

        }

        //Get List Suppliers
        public IEnumerable<Supplier> GetAllSupplier()
        {
            using (var session = Factory.Create<IAppSession>())
            {
                IEnumerable<Supplier> items = session.Find<Supplier>();
                return items;
            }
        }


        //public IEnumerable<Supplier> GetSupplierName()
        //{
        //    using (var session = Factory.Create<IAppSession>())
        //    {
        //        var lst = session.Find<Supplier>(p => p.Include<Product>(join => join.LeftOuterJoin()));
        //        return lst;
        //    }
        //}


    }

}
