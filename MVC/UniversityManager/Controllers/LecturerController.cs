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
    public class LecturerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        LecturerService LecSer = new LecturerService();
        DepartmentService DeSer = new DepartmentService();
        //Lấy dữ liệu hiện lên datatable
        public JsonResult GetDataTable(JQueryDataTableParamModel param)
        {
            //Ở đây dùng IConvertible để trả dữ liệu về View dưới dạng Json
            //thay vì trả 1 list các Lecturer (không thể trả thẳng instance của
            //bảng Lecturer vì nó sẽ bị self-recursion).
            var data = LecSer.getAll().Select(a => new IConvertible[] {
                                           a.ID,
                                           a.LecCode,
                                           a.LecName,
                                           a.Email,
                                           DeSer.FindByID(a.DepartmentID).DepName
                                        });

            //Trả Json đúng theo format của datatable, các params nên đọc để hiểu rõ hơn
            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = data.Count(),
                iTotalDisplayRecords = data.Count(),
                aaData = data
            }, JsonRequestBehavior.AllowGet);

        }
        
        //Chỉ cần làm chức năng tạo mới thôi, update, delete không làm cũng dc
        //Nó dùng Bind để binding cái data bên view lúc nãy thành Lecturer luôn
        // Chơi kiểu này khó quá với lại phải validation kỹ bên kia nữa
        // tốt nhất dùng view model, vào đây mình ToEntity() là được
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Lecturer lec)
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


        public ActionResult GetDepartment()
        {
            var list = DeSer.getAll();

            return Json(list, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Update(Lecturer lec)
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

            //  Lecturer item = new Lecturer();
            var item = LecSer.FindByID(ID);


            return Json(item = new Lecturer
            {
                ID = item.ID,
                LecCode = item.LecCode,
                LecName = item.LecName,
                Email = item.Email,
                Phone = item.Phone,
                DepartmentID = item.DepartmentID

            }, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public JsonResult CheckExsist(string code)
        //{

        //    var item = LecSer.getAll();
        //    var checkE = true;
        //    foreach (var p in item)
        //    {
        //        if ((p.LecCode).Equals(code, StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            checkE = false;
        //        }
        //    }

        //    return Json(new { success = checkE }, JsonRequestBehavior.AllowGet);
        //}
        [HttpGet]
        public JsonResult CheckExsist(string code, string email, string phone)
        {

            var item = LecSer.getAll();
            var checkC = true;
            var checkE = true;
            var checkP = true;
            foreach (var p in item)
            {
                if ((p.LecCode).Equals(code, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkC = false;
                }
                if ((p.Email).Equals(email, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkE = false;
                }
                if ((p.Phone).Equals(phone, StringComparison.InvariantCultureIgnoreCase))
                {
                    checkP = false;
                }
            }

            return Json(new
            {
                checkC = checkC,
                checkE = checkE,
                checkP = checkP

            }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult CheckExsistEmail(string mail)
        {

            var item = LecSer.getAll();
            var checkE = true;
            foreach (var p in item)
            {
                if ((p.Email).Equals(mail))
                {
                    checkE = false;
                }
            }

            return Json(new { success = checkE }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            //Lecturer item = new Lecturer();
            //item = LecSer.FindByID(ID);
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