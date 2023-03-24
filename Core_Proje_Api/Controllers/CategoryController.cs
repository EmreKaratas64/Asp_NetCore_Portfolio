using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var c = new Context();
            var value = c.Categories.Find(id);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            var c = new Context();
            var value = c.Find<Category>(p.CategoryID);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                value.Name = p.Name;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
           
        }
    }
}
