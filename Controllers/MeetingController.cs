using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{
    
    public class MeetingController : Controller
    {
        //Toplantıya başvuru formu
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if(ModelState.IsValid){

                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();
                return View("Thanks", model);
            }else{
                return View(model);
            }
            
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        // meeting/details/id
        public IActionResult Details (int id)
        {
            return View(Repository.GetById(id));
        }

    }
}

/*integrity="sha512-t4GWSVZO1eC8BM339Xd7Uphw5s17a86tIZIj8qRxhnKub6WoyhnrxeCIMeAqBPgdZGlCcG2PrZjMc+Wr78+5Xg==" crossorigin="anonymous" referrerpolicy="no-referrer"*/