using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWork_MVCDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork_MVCDemo.Controllers
{
    public class BatchController : Controller
    {
        private readonly BatchDbContext db;

        
        public BatchController(BatchDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<Batch> list = new List<Batch>();
            list = db.Batches.ToList();
            //return View(db.Batches.ToList());
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Batch batch)
        {
            db.Batches.Add(batch);
            db.SaveChanges();
            return View();
        }

        public ActionResult Update(int id)
        {
            Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
            if (batch != null)
                return View(batch);
            else
            {
                ViewBag.msg = "Such Batch do not exist";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Update(int id, Batch batch)
        {
            Batch temp = db.Batches.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                foreach(Batch tem in db.Batches)
                {
                    if(tem.Id== temp.Id)
                    {
                        tem.BatchCode = batch.BatchCode;
                        tem.Course = batch.Course;
                    }
                    
                }
                db.SaveChanges();
            }
                return View();
            
        }

        public ActionResult Search(int id)
        {
            Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
            if (batch != null)
                return View(batch);
            else
            {
                ViewBag.msg = "Such Batch do not exist";
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            Batch batch = db.Batches.FirstOrDefault(x => x.Id == id);
            if (batch != null)
                return View(batch);
            else
            {
                ViewBag.msg = "Such Batch do not exist";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, Batch batch)
        {
            Batch temp = db.Batches.FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                db.Batches.Remove(temp);
                   
            }
            db.SaveChanges();
            return View();

        }


    }
}
