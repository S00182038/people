using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.pages
{
  
    public class namegreetingModel : PageModel
    {
        public string Message { get; set; } = "";

        //public string firstName { get; set; } = "";
        //public string firstName = Convert.ToString(HttpContext.Request.Form["text1"]);

        public void OnGet()
        {

        }
        public void OnPost(string firstName)
        {
            Message = "Hello " + firstName;
   
        }
    }
}