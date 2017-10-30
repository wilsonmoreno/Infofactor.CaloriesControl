using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.UnitofWork;
using System.Web.Mvc;

namespace Infofactor.CaloriesControl.Controllers
{
    public class CaloriesLogController : Controller
    {
        private IUnitOfWork unitOfWork;
        public CaloriesLogController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: CaloriesLog
        public ActionResult Index()
        {
            var calRepository = this.unitOfWork.CaloriesRepository;
            return View(calRepository.GetAll());
        }

        // GET: CaloriesLog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CaloriesLog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaloriesLog/Create
        [HttpPost]
        public ActionResult Create(CaloriesLog newRow)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    this.unitOfWork.CaloriesRepository.Insert(newRow);
                    this.unitOfWork.SaveChanges();
                    //return RedirectToAction("Index");
                }
            }
            catch
            {
                // Log here
                return View();
            }

            return View(newRow);
        }

        // GET: CaloriesLog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CaloriesLog/Edit/5
        [HttpPost]
        public ActionResult Edit(CaloriesLog editRow)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var toEdit = this.unitOfWork.CaloriesRepository.GetById(editRow.Id);
                    if (toEdit != null)
                    {
                        toEdit.Date = editRow.Date;
                        toEdit.MealId = editRow.MealId;
                        toEdit.NoPortion = editRow.NoPortion;
                        toEdit.UserId = editRow.UserId;
                        this.unitOfWork.CaloriesRepository.Update(toEdit);
                    }
                        
                    this.unitOfWork.SaveChanges();
                    //return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }

            return View(editRow);
        }

        // GET: CaloriesLog/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var todelete = this.unitOfWork.CaloriesRepository.GetById(id);
                    if (todelete != null)
                    {
                        this.unitOfWork.CaloriesRepository.Delete(id);
                    }
                    this.unitOfWork.SaveChanges();
                }
            }
            catch
            {
                return View();
            }

            return View(id);
        }

        // POST: CaloriesLog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
