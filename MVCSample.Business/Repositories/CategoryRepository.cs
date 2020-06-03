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
using MVCSample.Business.Models;

namespace MVCSample.Business.Repositories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        bool IsExistCateName(string name);
        //bool IsExist(Category category);
        bool IsExist(string name, int cateId);

        IEnumerable<Category> GetAllCategories();

        IEnumerable<Category> SearchByName(string search,int pageNumber, int pageSize);
        IEnumerable<Category> GetCategories(int pageNumber, int pageSize);
        //IEnumerable<Category> ToPagination(int currentPage);
    }

    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory factory) : base(factory)
        {

        }

        public bool IsExist(string name, int cateId)
        {
            using (var session =  Factory.Create<IAppSession>())
            {
                //var exist = session.Query<Category>("Select * from categories where category_id = '" + cateId + "' and category_name='" + name + "'");
                var exist = session.Find<Category>(c => c.Where($"{nameof(Category.category_id)}='{cateId}' and {nameof(Category.category_name)}='{name}'"));
                if (exist.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsExistCateName(string name)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                var exist = session.Find<Category>(p => p.Where($"{nameof(Category.category_name)}='{name}'"));
                if (exist.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        //List category
        public IEnumerable<Category> GetAllCategories()
        {
            using (var session = Factory.Create<IAppSession>())
            {
                //var items = session.Query<Category>("Select * from categories");
                var items = session.Find<Category>();
                return items;
            }
        }

        public IEnumerable<Category> SearchByName(string search,int pageNumber,int pageSize)
        {
            using (var session = Factory.Create<IAppSession>())
            {
                //return session.Query<Category>("Select * from categories where LOWER(category_name) like LOWER ('%" + search + "%')");
                return session.Find<Category>(c => c
                .Where($"LOWER({nameof(Category.category_name)}) LIKE LOWER ('%{search}%')")
                .Skip((pageNumber-1)*pageSize)
                .Top(pageSize)
                );
            }
        }
        
        public IEnumerable <Category> GetCategories(int pageNumber, int pageSize)
        {
          
            using (var session = Factory.Create<IAppSession>())
            {
                //Category cateModel = new Category();
                //var listCategory = session.Find<Category>();
                return session.Find<Category>(c => c
                .Skip((pageNumber - 1) * pageSize)
                .Top(pageSize)
                );
                //int pageCount = (int)Math.Ceiling((double)listCategory.Count() / pageSize);
                //cateModel.PageCount = pageCount;
                //cateModel.CurrentPage = pageNumber;
                //return cateModel;
            }
        }

        //public IEnumerable<Category> ToPagination(int currentPage)
        //{
        //    using (var session = Factory.Create<IAppSession>())
        //    {
        //        var listCategory = session.Find<Category>();
        //        int pageSize = 5;
        //        //int totalPage = (int)Math.Ceiling((double)listCategory.Count() / pageSize);
        //        var pageList = session.Query<Category>("Select * from products offset " + (currentPage - 1) * pageSize + " limit " + pageSize + "");
        //        return pageList;
        //    }
        //}


    }
}
