﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAspNetMVC.Controllers
{
    public class DocumentoController : Controller
    {
        // GET: Documento
        public ActionResult Index()
        {
            return View();
        }
    }
}