using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.ui.Data;
using shopapp.ui.Model;
using shopapp.ui.ViewsModel;

namespace shopapp.ui.Controllers
{
    public class ProductController:Controller
    {

        private IProductService iProductService;

        public ProductController(IProductService _iProductService)
        {
            this.iProductService=_iProductService;
        }
        public IActionResult list(int? id){

            var products=iProductService.GetAll();
            if(id!=null){
                products=products.Where(i=>i.id==id).ToList();
            }

           return View(products);
            
        }

        public IActionResult details(int id){

            var product=iProductService.GetById(id);
            return View(product);

        }
    }
}