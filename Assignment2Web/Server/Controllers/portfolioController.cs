using Assignment2Web.Server.DataContext;
using Assignment2Web.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment2Web.Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PortfolioDetailsController : ControllerBase
    {


        // GET api/<PortfolioDetailsController>/5
        [HttpGet("/Portfolio")]
        public IActionResult Get()
        {
            var options = new DbContextOptionsBuilder<PortfolioContext>().UseSqlServer("Data Source=DESKTOP-I71V0MD;Initial Catalog=PortfolioDetails;integrated security=true;TrustServerCertificate=True").Options;
            var PortfolioDB = new PortfolioContext(options);
            var get_records = PortfolioDB.portfolioDetails.ToList();
            return Ok(get_records);
        }



        // PUT api/<PortfolioDetailsController>/5
        [HttpPut("/{name}/{description}/{url}")]
        public IActionResult Put(string name, string description, string url)
        {
            var options = new DbContextOptionsBuilder<PortfolioContext>().UseSqlServer("Data Source=DESKTOP-I71V0MD;Initial Catalog=PortfolioDetails;integrated security=true;TrustServerCertificate=True").Options;
            var PortfolioDB = new PortfolioContext(options);
            var insert = new portfolioDetails
            {
                Name = name,
                Description = description,
                ImageUrl = url
            };
            PortfolioDB.portfolioDetails.Add(insert);
            PortfolioDB.SaveChanges();
            return Ok(insert);
        }
    }
}
