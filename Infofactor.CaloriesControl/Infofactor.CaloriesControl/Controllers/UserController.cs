using Infofactor.CaloriesControl.Repository.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infofactor.CaloriesControl.Controllers
{
    public class UserController : Controller
    {
        private IUnitOfWork unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: User
        public ActionResult Index()
        {
            var userRepository = this.unitOfWork.UserRepository;
            return View(userRepository.GetAll());
        }


    }
}