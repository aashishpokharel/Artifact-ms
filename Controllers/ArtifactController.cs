using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace artifact_ms.Controllers
{
    public class ArtifactController : Controller
    {
        public ViewResult add()
        {
            return View();
        }

         public ViewResult update()
         {
             return View();
         }

        // public ViewResult Dashboard()
        // {
        //     return View();
        // }

        // public ViewResult AddVehicle()
        // {
        //     return View();
        // }

        // public ViewResult AddService()
        // {
        //     return View();
        // }
    }
}
