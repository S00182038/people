using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.pages
{
    public class HtmlValidationModel : PageModel
    {
        public string Massage { get; set; } = "";
       
        public void OnGet()
        {
        }

        public void OnPost(int studentNumber, int num1, int num2,int num3)
        {

            Massage = "student no  " + studentNumber + " | number  " + num1 + " | number 2  " + num2 + " | number 3  " + num3;

        }
    }
}