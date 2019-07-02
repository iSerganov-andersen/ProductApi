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
    [Route("api/product")]
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
        public JsonResult Get()
        {
            try
            {
                return Json(new ReturnRes<IList<Product>>(200, _service.Get().ToList()));
            }
            catch (Exception ex)
            {
                return Json(new ReturnRes(500, ex.Message));
            }
        }

        
        [HttpGet("{id}")]
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
        public ActionResult Add([FromBody] Product value)
        {
            try
            {
                _service.Add(value);
                return Created(string.Empty, null);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Product value)
        {
            try
            {
                _service.Update(id, value);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
