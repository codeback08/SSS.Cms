using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> options)
        {
            contents = options.Value;
        }
        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = new List<Content>{ contents }});
            //var contents = new List<Content>();

            //for(int i=0;i<11;i++)
            //{
            //    contents.Add(new Content { Id = i, Title = $"{i}的标题", content=$"{i}的内容", Status=1, Add_Time=DateTime.Now});
            //}
            //return View(new ContentViewModel { Contents = contents });
        }
    }
}