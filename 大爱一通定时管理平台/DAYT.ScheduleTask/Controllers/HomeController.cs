using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAYT.ScheduleTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController()
        {
            _repository = new Repository();
        }
        // GET: Home
        public ActionResult Index()
        {
            var model= _repository.GetAll<SYS_ScheduleTask>().ToList();
            return View(model);
        }
        public JsonResult Stop(string name)
        {
            try
            {
                TaskManager.Instance.Stop(name);
                var model = _repository.GetFristDefault<SYS_ScheduleTask>(x => x.Name == name);
                model.Switch = false;
                _repository.Update(model);
                return Json("成功", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
                throw;
            }
        }
        public JsonResult Start(string name)
        {
            try
            {
                TaskManager.Instance.Start(name);
                var model = _repository.GetFristDefault<SYS_ScheduleTask>(x => x.Name == name);
                model.Switch = true;
                _repository.Update(model);
                return Json("成功", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(e.ToString(), JsonRequestBehavior.AllowGet);
                throw;
            }           
        }

        public ActionResult Heartbeat()
        {
            return Content("ok");
        }


    }
}