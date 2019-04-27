using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_using.Models;
using ViewBag_using.ViewModels;

namespace ViewBag_using.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult homepage()
        {

            homepageViewModel hmpg = new homepageViewModel()
            {
                hpVM_CitiesData = new SelectList(City.GetFakeCities(), "City_Id", "City_name"), // tabi tek tek de yapabilirdin hmpg. diyerek dikkat!!Daha kolay oldugundan böyle yaptık.
                hpVm_CountriesData = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name"),
                hpVM_Selected_City_Id=-1,
                hpVM_Selected_Country_Id=-1,


            };
            

            return View(hmpg);
        }

        [HttpPost]
        public ActionResult homepage(homepageViewModel hmpg_model)
        {

            string a1, a2;
            
            hmpg_model.hpVM_CitiesData= new SelectList(City.GetFakeCities(), "City_Id", "City_name"); //burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
            hmpg_model.hpVm_CountriesData = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name");//burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
            //var list_1 = City.GetFakeCities();
            //var list_2 = Country.GetFakeCountries();
            //foreach (var item in list_1)
            //{
            //    if(item.City_Id==hmpg_model.hpVM_Selected_City_Id)
            //    {
            //        a1 = item.City_name;
            //    }
               
            //}
            //foreach (var item in list_2)
            //{
            //    if (item.Country_Id == hmpg_model.hpVM_Selected_Country_Id)
            //    {
            //        a2 = item.Country_name;
            //    }

            //}
            
            return View(hmpg_model);
        }

    }
}

/*
 dropdown da veriyi 2 farklı yolla gönderebilirsin,
 
    1. SelectList  şeklinde yada,
    2.  List<SelectListItem>  şeklinde.
  
    SelectList aslında veriyi tutan bir class ve dd bu veriyi 
    SelectList içerisinden alabilicek yapıya sahip.
*/

/*

NOTE: Diger kullanim yöntemi ise dogrudan atama yapmak istemiyorsak ViewBag 'e 


    SelectList SelectList_City = new SelectList(City.GetFakeCities(), "City_Id", "City_name"); //burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.
           SelectList SelectList_Country = new SelectList(Country.GetFakeCountries(), "Country_Id", "Country_name");//burdaki isimler sınıftaki property isimleri ile aynı olmalıdır.

           ViewBag.CitiesData = SelectList_City;
           ViewBag.CountriesData = SelectList_Country;



    şeklinde olacaktır.
*/
