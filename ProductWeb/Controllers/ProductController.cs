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

        public ProductController(ProductService service)
        {
            this._service = service;
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
                return Ok(_service.Get(id));
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
                await _service.AddAsync(value);
                return Created(string.Empty, value);
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
    }
}
