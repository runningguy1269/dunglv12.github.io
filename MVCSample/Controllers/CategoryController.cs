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



namespace MVCSample.Controllers
{
    public class CategoryController : BaseController
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(IDbFactory dbFactory, CategoryRepository categoryRepository) : base(dbFactory)
        {
            _categoryRepository = categoryRepository;
        }

       [HttpGet]
        public ActionResult Index(string thisFilter, string searchString, int? page)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                var cates = _categoryRepository.GetAll(session);
               
                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = thisFilter;
                }
                var pageNumber = (page ?? 1);
                var pageSize = 5;
                ViewData["CurrentFilter"] = searchString;
                if (!String.IsNullOrEmpty(searchString))
                {
                    var categories = _categoryRepository.SearchByName(searchString,pageNumber,pageSize);
                    return View(categories);
                    //return Json(new { success = true });
                }
                return View(cates);
            }
            
        }

        public ActionResult GetTable(string searchString, int? page,int pageNumber)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
               
                var pageSize = 5;
                var cates = _categoryRepository.GetAll(session);
                var pageCount = (int)Math.Ceiling((double)cates.Count() / pageSize);
                ViewBag.ToTalPage = pageCount;
                ViewBag.CurrenPage = pageNumber = (page ?? 1);
                var pagination = _categoryRepository.GetCategories( pageNumber, pageSize);
            

                ViewData["CurrentFilter"] = searchString;
                if (!String.IsNullOrEmpty(searchString))
                {
                    var categories = _categoryRepository.SearchByName(searchString, pageNumber, pageSize);
                    return PartialView("_ResultTable", categories);
                }
                return PartialView("_ResultTable", pagination);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult Create(Category cate)
        {

            if (ModelState.IsValid)
            {
                using (var session = _dbFactory.Create<IAppSession>())
                {
                    using (var uow = session.UnitOfWork())
                    {
                        try
                        {
                            if (_categoryRepository.IsExistCateName(cate.category_name))
                            {
                                ModelState.AddModelError("", "Tên danh mục đã tồn tại !");
                                return View();
                            }
                            _categoryRepository.SaveOrUpdate(cate, uow);
                            return RedirectToAction("Index");
                        }

                        catch (Exception e)
                        {
                            ModelState.AddModelError("","Cập nhật thất bại !");
                        }
                    }
                }
            }
               
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                var category = _categoryRepository.GetKey(id, session);
                return View(category);
            }
        }

        [HttpPost]
        public ActionResult Edit(Category cate)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                using (var uow = session.UnitOfWork())
                {
                    try
                    {
                        if (ModelState.IsValid)
                        {
                            if (_categoryRepository.IsExist(cate.category_name, cate.category_id))
                            {
                                return RedirectToAction("Index");
                            }
                            if (_categoryRepository.IsExistCateName(cate.category_name))
                            {
                                ModelState.AddModelError("", "Tên danh mục đã tồn tại !");
                                return View();
                            }
                            
                        }
                        var categories = _categoryRepository.SaveOrUpdate(cate, uow);
                        return RedirectToAction("Index");

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                
            }
        }

        public ActionResult Delete(int id)
        {
            using (var session = _dbFactory.Create<IAppSession>())
            {
                try
                {
                    var category = _categoryRepository.DeleteKey(id, session);
                    return Json(new { success = true, message = "Xóa thành công !" });
                    //return PartialView("_Delete", category);
                }
                catch (Exception)
                {
                    return Json(new { success = false, message = "Xóa thât bại " });
                }


            }
        }
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteCategory(int id)
        //{
        //    using (var session = _dbFactory.Create<IAppSession>())
        //    {

        //        _categoryRepository.DeleteKey(id, session);
        //        return RedirectToAction("Index");

        //    }
        //}
    }
}