using CMS.API.Core;
using DataServices.IRepository;
using DataServices.Repository;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Data;//yai us class ka reference bna dia jis ki wajha sai hmai object nhi bnana nhi pra
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [ApiController]//yai btadia k api k controller hai
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        StudentCore studentCore;
        ApiResponse apiResponse = new ApiResponse();
        public StudentController(IStudentRepo iStudentRepo)
        {//jb hmara proj run hota hai to repostry ka chalna hona chahiyai wrna null show hojae gi 
            studentCore = new StudentCore(iStudentRepo);
        }
        public IActionResult Index()
        {
            return View();
        }

        //studdent controller sai core and core sai repository
        [HttpPost]//yai value post krnai k lie hota hai
        [Route("Create")]// hmai yai btana hota hai k kaha jana hai URL sai
        public IActionResult Create(Student model)
        {
            apiResponse = studentCore.Create(model);
            return Ok(apiResponse);
        }

        [HttpPost]//yai value post krnai k lie hota hai
        [Route("Update")]// hmai yai btana hota hai k kaha jana hai URL sai
        public IActionResult Update(Student model)
        {
            apiResponse = studentCore.Update(model);
            return Ok(apiResponse);
        }

        [HttpPost]//yai value post krnai k lie hota hai
        [Route("Search")]// hmai yai btana hota hai k kaha jana hai URL sai
        public IActionResult Search(int ID)
        {
            return View();
        }

    }
}
