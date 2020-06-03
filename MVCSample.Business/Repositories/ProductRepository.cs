
using MVCSample.Business.Entities;
using Smooth.IoC.Repository.UnitOfWork;
using Smooth.IoC.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MVCSample.Business.Repositories.Session;
using Dapper.FastCrud;
using System.Linq;
using Dapper;

namespace MVCSample.Business.Repositories
{

    public interface IProductRepository : IRepository<Product, int>
    {
        bool IsExistProductName(string name);
        bool IsExistProduct(Product product);

        IEnumerable<Product> SearchByName(string search,int cateId);
        IEnumerable<Product> FilterByCateName(int cateId);

        IEnumerable<Product> FilterCateByName2(string name);
        IEnumerable<Product> GetAllProduct();
        Product GetItem(int id);
    }
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(IDbFactory factory) : base(factory)
        {

        }


        public IEnumerable<Product> GetAllProduct()
        {
            using (var session = Factory.Create<IAppSession>())
            {
                var ls = session.Find<Product>(c => c.Include<Category>(join => join.LeftOuterJoin()).Include<Supplier>(join => join.LeftOuterJoin()));
                return ls;
            }
        }

        public Product GetItem(int id)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                return session.Find<Product>(c => c
                                                    .Where($"{nameof(Product.product_id)}={id}")
                                                    .Include<Category>(join => join.LeftOuterJoin())
                                                    .Include<Supplier>(join => join.LeftOuterJoin())
                                                    )
                                .FirstOrDefault();
            }
        }


        public bool IsExistProductName(string name)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                try
                {
                    var existProduct = session.Find<Product>(p => p.Where($"{nameof(Product.product_name)}='{name}'"));
                    if (existProduct.Count() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public IEnumerable<Product> SearchByName(string search, int cateId)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                try
                {
                    //var item = session.Find<Product>(p => p.Where($"LOWER({nameof(Product.product_name)}) LIKE LOWER ('%{search}%') OR {nameof(Product.category_id)}='{cateId}'"));
                    var item = session.Find<Product>(p => 
                                                    p.Include<Category>(join => join.LeftOuterJoin())
                                                    .Include<Supplier>(join => join.LeftOuterJoin())
                                                    .Where($"LOWER({Sql.Table<Product>()}.{nameof(Product.product_name)}) LIKE LOWER ('%{search}%') OR LOWER({Sql.Table<Supplier>()}.{nameof(Supplier.company_name)}) LIKE LOWER ('%{search}%') OR LOWER({Sql.Table<Category>()}.{nameof(Category.category_name)}) LIKE LOWER ('%{search}%') OR {Sql.Table<Product>()}.{nameof(Product.category_id)}='{cateId}'"));
                    return item;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public IEnumerable<Product> FilterByCateName(int cateId)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                //var items = session.Query<Product>("Select * from products where category_id =" + cateId);
                //var items = session.Find<Product>(p => p.Where($"{nameof(Product.category_id)}='{cateId}'"));
                //var items = session.Query<Product>("Select * from products p join categories c on p.category_id = c.category_id join suppliers s on p.supplier_id = s.supplier_id where p.category_id = '" + cateId + "'");
                var items = session.Find<Product>(c => 
                                                c.Include<Category>(join => join.LeftOuterJoin())
                                                .Include<Supplier>(join => join.LeftOuterJoin())
                                                .Where($"{Sql.Table<Product>()}.{nameof(Product.category_id)}={cateId}"));
                return items;
            }
        }

        public IEnumerable<Product> FilterCateByName2(string name)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                var items = session.Find<Product>(c => c.Include<Category>(join => join.LeftOuterJoin()).Include<Supplier>(join=>join.LeftOuterJoin()).Where($"{nameof(Category.category_name)}='{name}'"));
                return items;
            }
        }

        public bool IsExistProduct(Product product)
        {
            using (var session = Factory.Create<IAppSession>())
            {

                var condition = $"{nameof(Product.product_name)}='{product.product_name}'";
                if (product.product_id > 0)
                    condition += $"and {nameof(Product.product_id)}={product.product_id}";
                var existItems = session.Find<Product>(p => p.Where($"{condition}"));
                return existItems.Count() > 0;
 

                // IEnumerable <Product> existProducts;
                //if (product.product_id == 0)
                //{
                //    existProducts = session.Find<Product>(p => p.Where($"{nameof(Product.product_name)}='{product.product_name}'"));
                //}
                //else
                //{
                //    existProducts = session.Find<Product>(p => p.Where($"{nameof(Product.product_name)}='{product.product_name}'and {nameof(Product.product_id)}='{product.product_id}'"));
                //}
                //if (existProducts.Count() > 0)
                //{
                //    return true;
                //}
                //return false;
            }
        }

  


    }
}
