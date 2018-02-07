﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _21Education.COMMON;
using _21Education.DATA;
using _21Education.WebSite.ViewModels;
using _21Education.MODEL;


namespace _21Education.WebSite.Areas.Admin.Controllers
{
    public class Areas_ContactController : Controller
    {
        //
        // GET: /Admin/Areas_Contact/

        public ActionResult Index()
        {
            return View();
        }

        #region 公司基本信息

        public ActionResult ContactCompanyinfo()
        {
            return View();
        }

      
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="pager"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetList(GridPager pager)
        {
            var list = new List<MODEL.ContactCompanyinfo>(1);
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 1,
                Address = "beijing",
                Email = "@.email",
                Phone = "979899",
                Transmission = "12345",
                Website = "www"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 2,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });

            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 3,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 4,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 5,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 6,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 7,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 8,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 9,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });
            list.Add(new MODEL.ContactCompanyinfo
            {
                ContactCompanyinfoId = 10,
                Address = "222",
                Email = "@.2222",
                Phone = "22222",
                Transmission = "2222",
                Website = "222222"
            });

            var json = new
            {
                //total = list.Count,
                total = pager.totalRows,
                rows = (from r in list
                        select new MODEL.ContactCompanyinfo()
                        {
                            ContactCompanyinfoId = r.ContactCompanyinfoId,
                            Address = r.Address,
                            Email = r.Email,
                            Phone=r.Phone,
                            Transmission = r.Transmission,
                            Website = r.Website
                        }).ToArray()
            };
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        //#region 创建
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public JsonResult Create(MODEL.ContactCompanyinfo model)
        //{


        //    if (m_BLL.Create(model))
        //    {
        //        return Json(1, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(0, JsonRequestBehavior.AllowGet);
        //    }

        //}
        //#endregion

        //#region 修改

        //public ActionResult Edit(string id)
        //{

        //    MODEL.ContactCompanyinfo entity = m_BLL.GetById(id);
        //    return View(entity);
        //}

        //[HttpPost]

        //public JsonResult Edit(MODEL.ContactCompanyinfo model)
        //{


        //    if (m_BLL.Edit(model))
        //    {
        //        return Json(1, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(0, JsonRequestBehavior.AllowGet);
        //    }

        //}
        //#endregion

        //#region 详细
        //public ActionResult Details(string id)
        //{
        //    MODEL.ContactCompanyinfo entity = m_BLL.GetById(id);
        //    return View(entity);
        //}

        //#endregion

        //#region 删除
        //[HttpPost]
        //public JsonResult Delete(string id)
        //{
        //    if (!string.IsNullOrWhiteSpace(id))
        //    {
        //        if (m_BLL.Delete(id))
        //        {
        //            return Json(1, JsonRequestBehavior.AllowGet);
        //        }
        //        else
        //        {

        //            return Json(0, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    else
        //    {
        //        return Json(0, JsonRequestBehavior.AllowGet);
        //    }


        //}
        //#endregion



        #endregion

    }
}