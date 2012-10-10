using System;
using System.Web.Mvc;
using PersonalFinance.Service.Interfaces;

namespace PersonalFinance.WebUI.Controllers
{
    public abstract class BaseController<S, T> : Controller, IDisposable
        where T : class
        where S : IBaseService<T>, new()
    {
        private S service;

        public S Service
        {
            get { return service; }
            set { service = value; }
        }

        public BaseController()
        {
            this.service = new S();
        }

        public virtual ActionResult Index()
        {
            var entities = service.ListAll();
            return View(entities);
        }

        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(T entity)
        {
            if (service.IsValid(entity))
                if (service.Add(entity))
                    return RedirectToAction("Index");


            return View(entity);
        }

        [HttpPost]
        public virtual ActionResult Edit(T entity)
        {
            if (service.IsValid(entity))
                if (service.Edit(entity))
                    return RedirectToAction("Index");

            return View(entity);
        }

        [HttpPost]
        [ActionName("Delete")]
        public virtual ActionResult DeleteConfirmed(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        public abstract ActionResult Edit(int id = 0);
        public abstract ActionResult Details(int id = 0);
        public abstract ActionResult Delete(int id = 0);

        protected override void Dispose(bool disposing)
        {
            service.Dispose();
            base.Dispose(disposing);
        }
    }
}
