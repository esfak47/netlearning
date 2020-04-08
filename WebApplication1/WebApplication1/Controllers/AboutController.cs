using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController 
    {

        public String Me()
        {
            return "me";
        }

        public String Company()
        {
            return "Company";
        }
    }
}