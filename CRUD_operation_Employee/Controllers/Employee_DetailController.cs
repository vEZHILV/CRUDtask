using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_operation_Employee.Models;

namespace CRUD_operation_Employee.Controllers
{
    public class Employee_DetailController : Controller
    {
        private EmployeeModel db = new EmployeeModel();

        // GET: Employee_Detail
        public ActionResult Index()
        {
            return View(db.Employee_Detail.ToList());
        }

        // GET: Employee_Detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Detail employee_Detail = db.Employee_Detail.Find(id);
            if (employee_Detail == null)
            {
                return HttpNotFound();
            }
            return View(employee_Detail);
        }

        // GET: Employee_Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Employee_Name,Employee_ID,Designation,Salary")] Employee_Detail employee_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Employee_Detail.Add(employee_Detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee_Detail);
        }

        // GET: Employee_Detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Detail employee_Detail = db.Employee_Detail.Find(id);
            if (employee_Detail == null)
            {
                return HttpNotFound();
            }
            return View(employee_Detail);
        }

        // POST: Employee_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Employee_Name,Employee_ID,Designation,Salary")] Employee_Detail employee_Detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_Detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee_Detail);
        }

        // GET: Employee_Detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Detail employee_Detail = db.Employee_Detail.Find(id);
            if (employee_Detail == null)
            {
                return HttpNotFound();
            }
            return View(employee_Detail);
        }

        // POST: Employee_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_Detail employee_Detail = db.Employee_Detail.Find(id);
            db.Employee_Detail.Remove(employee_Detail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
