using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.pages
{
    public class AdderModel : PageModel
    {
        public string ResultMassage { get; set; }="";

        public void OnGet()
        {

        }
        public void OnPost(int num1, int num2)
        {
            //int num1 = Convert.ToInt32(HttpContext.Request.Form["text1"].ToString());
            //int num2 = Convert.ToInt32(HttpContext.Request.Form["text2"].ToString());
           
            int result = num1 + num2;

            ResultMassage = "Result is :" + result;
  
        }
    }
}