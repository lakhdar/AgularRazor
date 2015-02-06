using Newtonsoft.Json;
using razorAngular.DummyDataModel;
using razorAngular.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace razorAngular.Controllers
{
    public class EmployeeController : Controller
    {
        DummyRepo _dataSource;

        public EmployeeController()
        {
            _dataSource = new DummyRepo();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var dataModel = _dataSource.GetAll();
            var viewModel = dataModel.ToViewModel();

            return View(viewModel);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var dataModel = _dataSource.GetElementById(id);
            var viewModel = dataModel.ToViewModel();

            return View(viewModel);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
