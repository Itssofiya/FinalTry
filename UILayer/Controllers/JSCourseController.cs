using JobSeeker.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace UILayer.Controllers
{
    public class JSCourseController : Controller
    {
        public IActionResult Index()
        {
            List<JSCourse> CourseList = new List<JSCourse>();
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44369/api/JSCourse/GettALLCourse");
                //builder.Query = "userName=" + userName + "&passWord=" + password;

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var responseTask = client.GetAsync(builder.Uri).Result;

                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    CourseList = JsonConvert.DeserializeObject<List<JSCourse>>(JsonContent);
                }
            }
            return View(CourseList);
            
        }
    }
    
}
public class JSCourseController : Controller
{
    
    public IActionResult Edit(int Id)
    {
        JSCourse Course = null;

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:44369/api/JSCourse/GettALLCourse");
            //HTTP GET
            var responseTask = client.GetAsync("Course?Id=" + Id.ToString());
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<JSCourse>();
                readTask.Wait();

                Course = readTask.Result;
            }
        }

        return View(Course);
    }
}
