using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace people.pages
{
    public class handlerDemoModel : PageModel
    {
        public string Message { get; set; } = "";
        public void OnGet()
        {
            Message = "HTTP Request was a GET";
        }

        public void OnPost()
        {
            Message = "HTTP Request was a POST";
        }
    }
}