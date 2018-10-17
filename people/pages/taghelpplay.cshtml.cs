using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }
        public int Number1 { get; set;}
        public int Number2 { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            int answer = Number1 + Number2;
            Message = $"Result {answer}";
        }
    }
}