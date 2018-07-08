using Entities;
using PetManiaServices.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetManiaWeb.Controllers
{
    public class AdminController : Controller
    {
        ClienteBusiness clienteBusiness = new ClienteBusiness();

        //VIEW INDEX
        public ActionResult Index()
        {
            return View();
        }

        //VIEW EDIT
        public ActionResult Edit(long id)
        {
            try
            {
                return View(clienteBusiness.GetCliente(id));
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(500, ex.Message);
            }
        }

        //SAVE
        public ActionResult Save(ClienteEntity c)
        {
            try
            {
                if (c.IdCliente == 0) //CREATE
                {
                    return Json(clienteBusiness.Create(c), JsonRequestBehavior.AllowGet);
                }
                else //UPDATE
                {
                    clienteBusiness.Update(c);
                    return Json(JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.TrySkipIisCustomErrors = true;
                return Json(ex.Message);
            }
        }

        //DELETE
        public ActionResult Delete(long id)
        {
            try
            {
                clienteBusiness.Delete(id);
                return Json(JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.TrySkipIisCustomErrors = true;
                return Json(ex.Message);
            }
        }

        //DATATABLES
        #region
        //GET
        public ActionResult GetCliente()
        {
            var request = HttpContext.Request.Params;
            var draw = Convert.ToInt32(request["draw"]);
            var start = Convert.ToInt32(request["start"]);
            var search = request.Get("search[value]");
            var count = clienteBusiness.GetCount();
            var length = Convert.ToInt32(request["length"]);
            var data = clienteBusiness.GetAllCliente(start, length, search);
            if (search != "")
            {
                count = data.Count;
            }
            return Json(new
            {
                data = data,
                draw = draw,
                iTotalDisplayRecords = count,
                iTotalRecords = length,
            }, JsonRequestBehavior.AllowGet);

        }

        //GETTYPEAHEAD
        public ActionResult GetTypeAhead(string busca)
        {
            return Json(clienteBusiness.GetTypeAhead(busca), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}