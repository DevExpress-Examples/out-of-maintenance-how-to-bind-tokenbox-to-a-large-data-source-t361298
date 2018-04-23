using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DXWebApplication1.Models;
using System.Web.Services;
using System.Threading;

namespace DXWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<Product> _Products;
        public IEnumerable<Product> Products
        {
            get
            {
                if (_Products == null)
                    _Products = GetData();
                return _Products;
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetFilteredData(string str, string seltokens)
        {

            List<int> selectedTokens = new List<int>();
            int dummyInt;
            if(!String.IsNullOrEmpty(seltokens))
                selectedTokens = seltokens.Split(',').Where(ff => Int32.TryParse(ff, out dummyInt)).Select(ff => Int32.Parse(ff)).ToList();
            if (!string.IsNullOrEmpty(str))
                return Json(Products.Where(p => !selectedTokens.Contains(p.ProductID) && p.ProductName.ToLower().Contains(str.ToLower())).Take(10).ToArray(), JsonRequestBehavior.AllowGet);
            else
                return null;
        }

        private IEnumerable<Product> GetData()
        {
            var returnList = new List<Product>
            {
                new Product(10010, "Toys"),
                new Product(10020, "Books"),
                new Product(10030, "Cars"),
                new Product(10040, "Cars2"),
                new Product(10050, "Cars3"),
                new Product(10060, "Trucks"),
                new Product(10070, "Bikes"),
                new Product(20000, "Pets"),
                new Product(20002, "Dogs"),
                new Product(20004, "Cats"),
                new Product(20006, "Fish")
            };
            for (int i = 0; i < 10000; i++)
            {
                returnList.Add(new Product(i, "John Doe" + i++));
                returnList.Add(new Product(i, "Jane Doe" + i++));
                returnList.Add(new Product(i, "Michael Doe" + i++));
                returnList.Add(new Product(i, "Lana Doe" + i));
            }
            return returnList;
        }
    }
}