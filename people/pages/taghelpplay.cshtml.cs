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
        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
        //[BindProperty]
        //public decimal Number2 { get; set; }
        [BindProperty]
        public string[] Season { get; set; } = new string[4];


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