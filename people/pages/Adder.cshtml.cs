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
        public void OnPost(int num1, int num2, string operators)
        {
            double result = 0;

            if (operators == "addition")
            {
                result = num1 + num2;
            }
            else if (operators == "multiplication")
            {
                result = num1 * num2;
            }
            else if (operators == "division")
            {
                result = (double)num1 / num2;
            }
            else if (operators == "subtraction")
            {
                result = num1 - num2;
            }
            else
            {
                result = 0;
            }

            ResultMassage = "Result is :" + result;
  
        }
    }
}