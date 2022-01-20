using Microsoft.AspNetCore.Mvc;
using PersonApi.Interface;
using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Controllers
{
    public class PersonController : Controller
    {
        private IPeopleService _service;

        public PersonController(IPeopleService context)
        {
            _service = context;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_service.GetAll().FirstOrDefault(x => x.id == id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            //if (!_service.GetAll().Select(x => x.id).Contains((int)person.StoreId))
            //    return NotFound("Store id doesn't exist");
            _service.Add(person);
            return RedirectToAction("GetById", person);
        }

        public IActionResult Edit(int id)
        {
            return View(_service.GetAll().First(x => x.id == id));
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {

            _service.Update(person);
            return RedirectToAction("GetById", person);
        }
    }
}
