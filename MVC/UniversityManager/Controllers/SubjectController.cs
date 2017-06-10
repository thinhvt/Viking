using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagement;
using UniversityManagement.Service;
using UniversityManager.Models;

namespace UniversityManager.Controllers
{
    public class SubjectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        SubjectsService LecSer = new SubjectsService();
        DepartmentService DeSer = new DepartmentService();

        
        public JsonResult GetDataTable(JQueryDataTableParamModel param)
        {
            
            var data = LecSer.getAll().Select(a => new IConvertible[] {
                a.ID,
               a.SubCode,
                a.SubName,
               a.Credit,
               a.TotalSlots,
               DeSer.FindByID(a.DepartmentID).DepName,
               });

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = data.Count(),
                iTotalDisplayRecords = data.Count(),
                aaData = data
            }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetDepartment()
        {
            var list = DeSer.getAll();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ID")] Subject lec)
        {
            try
            {
                LecSer.add(lec);
            }
            catch (Exception e)
            {
            }

            return Json(lec, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Update(Subject lec)
        {
            if (ModelState.IsValid)
            {
                LecSer.update(lec);

            }
            return Json(lec, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetLecturerByID(int ID)
        {


            var item = LecSer.FindByID(ID);


            return Json(item = new Subject
            {

                ID = item.ID,
                SubCode = item.SubCode,
                SubName = item.SubName,
                Credit = item.Credit,
                TotalSlots = item.TotalSlots,
                DepartmentID = item.DepartmentID

            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult CheckExsist(string code)
        {

            var item = LecSer.getAll();
            var checkE = true;
            foreach (var p in item)
            {
                if ((p.SubCode).Equals(code))
                {
                    checkE = false;
                }
            }

            return Json(new { success = checkE }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            try
            {
                LecSer.delete(ID);

            }
            catch (Exception)
            {

            }
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}