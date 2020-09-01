using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MattWagnerWellBeings.Models;

namespace MattWagnerWellBeings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>();
            products.Add(new Product(1, "Blueberry", "berry", "The small sweet blue-black edible berry of the blueberry plant"));
            products.Add(new Product(2, "Blackberry", "berry", "An edible soft fruit consisting of a cluster of soft purple-black drupelet"));
            products.Add(new Product(3, "Mixed Berry Serum", "serum",
                "This 95% natural serum gives skin a healthy glow through a potent combination of berries selected for their proven antioxidant power in nature"));
            products.Add(new Product(4, "Strawberry", "berry", "A sweet soft red fruit with a seed-studded surface."));
            products.Add(new Product(5, "Strawberry Serum", "serum", "A brightening serum powered by strawberry-derived vitamin C for noticeable radiance, hydration, and even-toned skin"));
            products.Add(new Product(6, "Raspberry", "berry", "An edible soft fruit related to the blackberry, consisting of a cluster of reddish-pink drupelets"));

            return products.AsEnumerable();
        }
    }
}
