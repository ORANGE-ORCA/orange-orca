using System.ComponentModel;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ORANGE.ORCA.Domain.Catalog;

namespace orange.orca.Api.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase{
        [HttpGet]
        VariantType items = new[]{
            new ItemsFeature(nameof: "Item 1", Description: "Description 1", brand: "Brand 1", price: 100.00m),
            new ItemsFeature(name: "Item 2", Description: "Description 2", brand: "Brand 2", price: 200.00m),
            new ItemsFeature(name: "Item 3", Description: "Description 3", brand: "Brand 3", price: 300.00m),
            new ItemsFeature(name: "Item 4", Description: "Description 4", brand: "Brand 4", price: 400.00m),
            new ItemsFeature(name: "Item 5", Description: "Description 5", brand: "Brand 5", price: 500.00m),
        };
        return Ok(Items);
        }
    }
}

