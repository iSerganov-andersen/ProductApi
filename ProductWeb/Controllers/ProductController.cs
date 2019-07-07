using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductCore.Entities;
using ProductServices.BusinessServices;
using ProductWeb.Models;

namespace ProductWeb.Controllers
{
    [Route("product")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        private readonly CategoryService _categoryService;

        public ProductController(ProductService service, CategoryService catService)
        {
            this._service = service;
            this._categoryService = catService;
        }
        
        [HttpGet]
        [Route("Get")]
        public ActionResult<IList<Product>> Get()
        {
            try
            {
                var results = _service.Get(p => p.Category).ToList();
                return Json(results);
            }
            catch (Exception ex)
            {
                return Json(new ReturnRes(500, ex.Message));
            }
        }

        
        [HttpGet("Get/{id}")]
        public ActionResult<Product> Get(Guid id)
        {
            try
            {
                return Ok(_service.Get(p => p.Id == id, p => p.Category));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Product>> Add([FromBody] Product value)
        {
            try
            {
                var product = new Product(value.Name, value.Category, value.Price);
                if (!value.IsActive)
                    product.Activate();
                await _service.AddAsync(product);
                return Created(string.Empty, product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPut("Put/{id}")]
        public async Task<ActionResult<Product>> Put(Guid id, [FromBody] Product value)
        {
            try
            {
                if (value.IsActive)
                    value.DeActivate();
                else
                    value.Activate();
                await _service.UpdateAsync(id, value);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok($"Product with'{id}' successfully deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("available-categories")]
        public ActionResult<IList<Category>> GetAllAvailableCategories()
        {
            try
            {
                var results = _categoryService.Get().ToList();
                return Json(results);
            }
            catch (Exception ex)
            {
                return Json(new ReturnRes(500, ex.Message));
            }
        }
    }
}
