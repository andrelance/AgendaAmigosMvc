using System;
using System.Collections.Generic;
using WebApplication.Models;
using WebApplication.Resources;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace WebApplication.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index(string nome)
        { 
            List<Pessoa> lista = new RegraNegocio().Aniversariantes("");
            
            return View(lista);
        }

        // GET: BirthDay
        public ActionResult BirthDay()
        {
            List<Pessoa> lista = new RegraNegocio().BirthDay("");
            return View(lista);
        }

        // GET: Amigos
        [HttpGet]
        public ActionResult Amigos(string nome)
        {
            List<Pessoa> lista = new RegraNegocio().Amigos("");
            return View(lista);
        }

        // GET: Pessoa/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(new RegraNegocio().Get_Pessoa(id));
        }
         
        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(Pessoa collection)
        {
            try
            {
                if(new RegraNegocio().Insert_Pessoa(collection))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(collection);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
              return View(new RegraNegocio().Get_Pessoa(id));
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pessoa collection)
        {
            try
            {
                if (new RegraNegocio().UPDATE_Pessoa(collection))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(collection);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View(new RegraNegocio().Get_Pessoa(id));
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Pessoa collection)
        {
            try
            {
                if (new RegraNegocio().delete_Pessoa(id))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(collection);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
