using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Products pObj = new Products(); //this is a bad code, we should use Dependency Injection instead,
                                        //which we will learn soon


        [HttpGet]
        [Route("/products/list")]
        public IActionResult GetAllProducts()
        {
            var allproducts = pObj.AllProducts();
            return Ok(allproducts);
        }
        [HttpGet]
        [Route("/products/id/{id}")]
        public IActionResult GetProduct(int id) 
        {
            try
            {
                var p = pObj.ProductById(id);
                return Ok(p);
            }
            catch (Exception ex) 
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet]
        [Route("/products/category/{category}")]
        public IActionResult GetProductByCategory(string  category) 
        {
            try
            {
                var p = pObj.ProductByCategory(category);
                return Ok(p);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("/products/instock/{yesNo}")]
        public IActionResult GetProductInStock(bool yesNo)
        {
            try
            {
                var p = pObj.ProductsInStock(yesNo);
                return Ok(p);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }
        [HttpGet]
        [Route("/products/total")]
        public IActionResult GetTotalProducts()
        {
            return Ok(pObj.TotalProducts());
        }

        [HttpPost]
        [Route("/products/add")]
        public IActionResult PostProduct([FromBody]Products newP)
        {
            var add = pObj.AddNewProduct(newP);
            return Ok(add);
        }
        [HttpDelete]
        [Route("/products/delete/{id}")]
        public IActionResult DeleteProduct(int id) 
        {
            try
            {
                var delte = pObj.RemoveProduct(id);
                return Accepted(delte);
            }
            catch (Exception ex) 
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        [Route("/products/edit")]
        public IActionResult EditProduct([FromBody]Products updates)
        {
            try
            {
                var edit = pObj.EditProduct(updates);
                return Accepted(edit);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }



    }
}
