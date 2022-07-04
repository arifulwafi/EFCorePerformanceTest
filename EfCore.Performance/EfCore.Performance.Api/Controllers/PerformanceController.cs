using BenchmarkDotNet.Attributes;
using EfCore.Performance.Api.Data;
using EfCore.Performance.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfCore.Performance.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerformanceController : ControllerBase
    {
        private PerformanceContext _context;
        public PerformanceController(PerformanceContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("[action]")]
        [Benchmark]
        public int WorstCount()
        {
            return _context.Products.ToList().Count;
        }

        [HttpGet]
        [Route("[action]")]
        [Benchmark]
        public int GoodCount()
        {
            return _context.Products.Count();
        }
    }
}
