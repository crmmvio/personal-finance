using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalFinance.Service;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.WebUI.Controllers
{
    public class BankController : BaseController<BankService, Bank>
    {
        public override ActionResult Edit(int id = 0)
        {
            var bank = Service.Find(id);

            if (bank == null)
                return HttpNotFound();

            return View(bank);
        }

        public override ActionResult Delete(int id = 0)
        {
            var bank = Service.Find(id);

            if (bank == null)
                return HttpNotFound();

            return View(bank);
        }

        public override ActionResult Details(int id = 0)
        {
            var bank = Service.Find(id);

            if (bank == null)
                return HttpNotFound();

            return View(bank);
        }
    }
}
