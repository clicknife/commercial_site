using System.Collections.Generic;
using ClicknifeAPI.Models;
using ClicknifeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClicknifeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly PortfolioService _portfolioService;

        public PortfolioController(PortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [HttpGet]
        public ActionResult<List<Portfolio>> Get()
        {
            return _portfolioService.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetPortfolio")]
        public ActionResult<Portfolio> Get(string id)
        {
            var portfolio = _portfolioService.Get(id);

            if (portfolio == null)
            {
                return NotFound();
            }

            return portfolio;
        }

        [HttpPost]
        public ActionResult<Portfolio> Create(Portfolio portfolio)
        {
            _portfolioService.Create(portfolio);

            return CreatedAtRoute("GetPortfolio", new { id = portfolio.Id.ToString() }, portfolio);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Portfolio portIn)
        {
            var portfolio = _portfolioService.Get(id);

            if (portfolio == null)
            {
                return NotFound();
            }

            _portfolioService.Update(id, portIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var portfolio = _portfolioService.Get(id);

            if (portfolio == null)
            {
                return NotFound();
            }

            _portfolioService.Remove(portfolio.Id);

            return NoContent();
        }
    }
}

