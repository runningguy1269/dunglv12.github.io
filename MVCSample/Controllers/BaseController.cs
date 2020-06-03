using Microsoft.AspNetCore.Mvc;
using Smooth.IoC.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSample.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IDbFactory _dbFactory;

        public BaseController(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }
    }
}
