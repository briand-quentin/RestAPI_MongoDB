using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Catalog.Controllers
{
    //GET /items
    [ApiController]
    [Route("[controller]")]
    //[Route("routetodefine")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return repository.GetItems();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var test = repository.GetItem(id);
            if (test is null)
            {
                return NotFound();
            }

            return test;
        }
    }
}