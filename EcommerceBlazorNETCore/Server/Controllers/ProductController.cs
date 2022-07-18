using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazorNETCore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
        new Product
            {
                Id = 1,
                Title = "Cloud Atlas",
                Description = "Cloud Atlas is the third novel by British author David Mitchell. Published in 2004, it won " +
                              "the British Book Awards Literary Fiction award and the Richard & Judy Book of the Year award." +
                              " It was short-listed for the Booker Prize, Nebula Award for Best Novel, and Arthur C. Clarke " +
                              "Award, among other accolades. Unusually, it received awards from both the general literary " +
                              "community and the speculative fiction community.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/38/Cloud_atlas.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Wool",
                Description = "Wool initially follows the story of Holston, the Silo's sheriff. All residents of the Silo " +
                              "have been taught that the outside world is toxic and deadly, and anyone who expresses any " +
                              "desire to go outside is sent to clean the external sensors. Those who are sent outdoors this " +
                              "way inevitably clean the sensors as instructed, but they also inevitably die a few minutes later",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1b/Hugh_C_Howey_Wool_Omnibus.jpg",
                Price = 5.99m
            },
            new Product
            {
                Id = 3,
                Title = "Foundation",
                Description = "Foundation is a science fiction novel by American writer Isaac Asimov. It is the first " +
                              "published in his Foundation Trilogy (later expanded into the Foundation series). " +
                              "Foundation is a cycle of five interrelated short stories, first published as a single book by" +
                              " Gnome Press in 1951. Collectively they tell the early story of the Foundation, an institute " +
                              "founded by psychohistorian Hari Seldon to preserve the best of galactic civilization after " +
                              "the collapse of the Galactic Empire.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Foundation_gnome.jpg",
                Price = 7.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
