using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new()
            {
                Id = item.Id,
                CreatedDate = item.CreatedDate,
                Name = item.Name,
                Price = item.Price
            };
        }
    }
}