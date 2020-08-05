using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAspNetMVC.Controllers
{
    public class VendedorController : Controller
    {
        // GET: Vendedor
        [Route("api/Vendedor")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetVD()
        {
            _context.TipoVendedor.ToList();
            var listVD = _context.Vendedor.ToList().Select(x => new
            {
                VendedorId = x.VendedorId,
                Nombre = x.Nombre,
                TipoVendedorId = x.TipoVendedorId,
                TipoVendedor = x.TipoVendedor.Nombre,
                Direccion = x.Direccion,
                Ciudad = x.Ciudad,
                Provincia = x.Provincia,
                Telefono = x.Telefono,
                Email = x.Email,
                Estado = x.Estado
            });
            return Json(new { data = listVD });
        }
    }
}