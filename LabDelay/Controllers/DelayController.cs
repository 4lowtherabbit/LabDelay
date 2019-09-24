using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LabDelay.Controllers
{
    public class DelayController : Controller
    {
        // GET: Delay
        public string Index(int seconds = 60)
        {
            Thread.Sleep(seconds * 1000);
            return "OK";
        }
    }
}