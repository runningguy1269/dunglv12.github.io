using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.FastCrud;
using Microsoft.AspNetCore.Mvc;
using MVCSample.Business.Entities;
using MVCSample.Business.Models;
using MVCSample.Business.Repositories;
using MVCSample.Business.Repositories.Session;
using Smooth.IoC.UnitOfWork.Interfaces;
using static MVCSample.Business.Repositories.SupplierRepository;
using X.PagedList.Mvc.Core;
using X.PagedList;
using X.PagedList.Mvc.Core.Common;
namespace MVCSample.Controllers
{
    public class ProductController : BaseController
    {

        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(
            IDbFactory dbFactory,
            ProductRepository productRepository,
            SupplierRepository supplierRepository,
            CategoryRepository categoryRepository
            ) : base(dbFactory)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public ActionResult Index(string searchString, int catId, int? page)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                ViewBag.GetCategory = _categoryRepository.GetAll(session);
                var pageNumber = (page ?? 1);
                var pageSize = 10;
                ViewData["CurrentFilter"] = searchString;
                ViewData["CategoryId"] = catId;
                var listProduct = _productRepository.GetAllProduct();
                //var ls = session.Find<Product>(stm => stm.Include<Category>(j => j.LeftOuterJoin()));

                if (catId != 0)
                {
                    var cateName = _productRepository.FilterByCateName(catId);
                    return PartialView("_ResultTable", cateName.ToPagedList(pageNumber, pageSize));
                }

                if (!String.IsNullOrEmpty(searchString))
                {
                    var products = _productRepository.SearchByName(searchString, catId);
                    return View(products.ToPagedList(pageNumber, pageSize));
                }

                return View(listProduct.ToPagedList(pageNumber, pageSize));
            }
        }


        public ActionResult GetTable(string searchString, int cateId, int? page)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                ViewBag.GetCategory = _categoryRepository.GetAllCategories();
                var pageNumber = (page ?? 1);
                var pageSize = 10;
                ViewData["CurrentFilter"] = searchString;
                ViewData["CategoryId"] = cateId;
                var listProduct = _productRepository.GetAllProduct();
                //var ls = session.Find<Product>(stm => stm.Include<Category>(j => j.LeftOuterJoin()));

                if (cateId != 0)
                {
                    var cateName = _productRepository.FilterByCateName(cateId);
                    return PartialView("_ResultTable", cateName.ToPagedList(pageNumber, pageSize));
                }

                if (!String.IsNullOrEmpty(searchString))
                {
                    var products = _productRepository.SearchByName(searchString, cateId);
                    return PartialView("_ResultTable", products.ToPagedList(pageNumber, pageSize));
                }

                return PartialView("_ResultTable", listProduct.ToPagedList(pageNumber, pageSize));
            }
        }


        [HttpGet]
        public ActionResult Create()
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                ViewBag.GetSupplier = _supplierRepository.GetAll(session);
                ViewBag.GetCategory = _categoryRepository.GetAll(session);
            }
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(/*[FromBody]*/Product product)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                using (var uow = session.UnitOfWork())
                {

                    try
                    {
                        ViewBag.GetSupplier = _supplierRepository.GetAll(session);
                        ViewBag.GetCategory = _categoryRepository.GetAll(session);
                        if (_productRepository.IsExistProduct(product))
                        {
                            ModelState.AddModelError("", "Tên sản phẩm đã tồn tại !");
                            return View(product);
                        }
                         _productRepository.SaveOrUpdate(product, uow);
                        return RedirectToAction("Index");
                    }
                    catch (Exception e)
                    {
                        return Json(new { success = false, message = "Cập nhật thất bại!" });
                    }



                }
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                ViewBag.GetListSup = _supplierRepository.GetAll(session);
                ViewBag.GetListCate = _categoryRepository.GetAll(session);

                var product = _productRepository.GetKey(id, session);
                return View(product);
            }
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                using (var uow = session.UnitOfWork())
                {


                    if (ModelState.IsValid)
                    {

                        if (_productRepository.IsExistProduct(product))
                        {
                            return RedirectToAction("Index"); 
                        }
                        else
                        {
                            ModelState.AddModelError("", "Tên sản phầm đã tồn tại");

                            ViewBag.GetListSup = _supplierRepository.GetAll(session);
                            ViewBag.GetListCate = _categoryRepository.GetAll(session);
                            return View(product);
                        }
                       
                    }
                    var products = _productRepository.SaveOrUpdate(product, uow);
                    return RedirectToAction("Index");
                }
            }
        }
        public ActionResult Delete(int id)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                try
                {
                    var product = _productRepository.DeleteKey(id, session);
                    return Json(new { success = true, message = "Xóa thành công!" });
                }
                catch (Exception)
                {
                    return Json(new { success = false, message = "Xóa thất bại !" });
                }
            }
        }

    }
}