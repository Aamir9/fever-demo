using fever.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fever.Controllers
{
    public class Doctor : Controller
    {


        [Route("FeverCheck")]
        [HttpGet]
        public ActionResult FeverChecker()
        {
            ViewData["Fever"] = "";
            ViewData["shypothermia"] = "";
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("FeverCheck")]
        public ActionResult FeverChecker(Fever model)
        {
            if (model.Unit == "Fahrenheit")
            {
                if (model.CheckFever >= 97)
                {
                    ViewData["Message"] = "You have fever ";
                    if (model.Ishypothermia)
                    {
                        ViewData["shypothermia"] = "and also low shypothermia";
                    }
                    else
                    {
                        ViewData["shypothermia"] = "";

                    }

                }
                else
                {
                    ViewData["Message"] = "You have not  fever ";

                }
            }
            else
            {
                if (model.CheckFever >= 37)
                {
                    ViewData["Message"] = "You have fever ";
                    if (model.Ishypothermia)
                    {
                        ViewData["shypothermia"] = "and also low shypothermia";
                    }
                    else
                    {
                        ViewData["shypothermia"] = "";
                    }
                }
                else
                {
                    ViewData["Message"] = "You have not  fever ";

                }

            }
            return View();

        }

       
    }
}
