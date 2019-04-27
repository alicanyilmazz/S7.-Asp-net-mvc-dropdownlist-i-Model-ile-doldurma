using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_using.ViewModels
{
    public class homepageViewModel
    {
        public int hpVM_Selected_City_Id { get; set; }
        public int hpVM_Selected_Country_Id { get; set; }
        public SelectList hpVM_CitiesData { get; set; }
        public SelectList hpVm_CountriesData  { get; set; }
    }
}