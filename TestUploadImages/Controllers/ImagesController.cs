using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUploadImages.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string description, string image)
        {
            string fileNameWitPath = Path.GetTempFileName();
            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(image.Replace("data:image/jpeg;base64,", ""));
                    bw.Write(data);
                    bw.Close();
                }
            }

            return Content("OK");
        }
    }
}