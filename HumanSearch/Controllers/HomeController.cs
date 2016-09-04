using HumanSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumanSearch.Controllers
{
    public class HomeController : Controller
    {

        // GET: Human
        public ActionResult Index()
        {
            return View();
        }

        // GET: All humans
        public JsonResult GetAllHumans()
        {
            using (HumanDBContext contextObj = new HumanDBContext())
            {
                var bookList = contextObj.human.ToList();
                return Json(bookList, JsonRequestBehavior.AllowGet);
            }
        }
        //GET: Human by Id
        public JsonResult GetHumanById(string id)
        {
            using (HumanDBContext contextObj = new HumanDBContext())
            {
                var humanId = Convert.ToInt32(id);
                var getHumanById = contextObj.human.Find(humanId);
                return Json(getHumanById, JsonRequestBehavior.AllowGet);
            }
        }
        //Update Human
        public string UpdateHuman(Human human)
        {
            if (human != null)
            {
                using (HumanDBContext contextObj = new HumanDBContext())
                {
                    int humanId = Convert.ToInt32(human.Id);
                    Human _human = contextObj.human.Where(b => b.Id == humanId).FirstOrDefault();
                    _human.Name = human.Name;
                    _human.Address = human.Address;
                    _human.Age = human.Age;
                    _human.Hair = human.Hair;
                    _human.FileName = human.FileName;
                    _human.Interests = human.Interests;
                    

                    contextObj.SaveChanges();
                    return "Human record updated successfully";
                }
            }
            else
            {
                return "Invalid human record";
            }
        }
        // Add book
        public string AddHuman(Human human)
        {
            if (human != null)
            {
                using (HumanDBContext contextObj = new HumanDBContext())
                {
                    contextObj.human.Add(human);
                    contextObj.SaveChanges();
                    return "Human record added successfully";
                }
            }
            else
            {
                return "Invalid Human record";
            }
        }
        // Delete book
        public string DeleteHuman(string humanId)
        {

            if (!String.IsNullOrEmpty(humanId))
            {
                try
                {
                    int _humanId = Int32.Parse(humanId);
                    using (HumanDBContext contextObj = new HumanDBContext())
                    {
                        var _human = contextObj.human.Find(_humanId);
                        contextObj.human.Remove(_human);
                        contextObj.SaveChanges();
                        return "Selected human record deleted sucessfully";
                    }
                }
                catch (Exception)
                {
                    return "Human details not found";
                }
            }
            else
            {
                return "Invalid operation";
            }
        }
    }
}