using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTrader.Business.Services;
using SuperTrader.Entity.Model;

namespace SuperTrader.API.Controller
{
     
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private ITradersService _traderService;
        private ISellService _sellService;
        private IBuyService _buyService;
        private IPortfolioService _portfolioService;

        public PortfolioController(ITradersService traderService, ISellService sellService, IBuyService buyService, IPortfolioService portfolioService)
        {
            _traderService = traderService;
            _sellService = sellService;
            _buyService = buyService;
            _portfolioService = portfolioService;
        }

        /// <summary>
        /// Add Portfolio
        /// </summary>
        /// <param name="portfolio"></param>
        /// <returns></returns>
        [HttpGet("api/portfolio/add")]
        public IActionResult Add()
        {
            var trader = _traderService.GetById(2);
            var buy = _buyService.GetById(2);
            var sell = _sellService.GetById(2);
            _portfolioService.Add(new Portfolio
            {
         
                traderId = trader.id,
                buy=buy,
                sell=sell
          
            });
            return Ok("Portfolio Added Successfully");

        }

        /// <summary>
        /// Get Portfolio By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/portfolio/Get/{id}")]
        public Portfolio Get(int id)
        {
            return _portfolioService.GetById(id);
        }
         
        /// <summary>
        /// Get All Portfolio
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/portfolio/GetAll")]
        public IActionResult GetAll()
        {
            var allPotfolio = _portfolioService.GetAll();

            return Ok(allPotfolio);
        }

        /// <summary>
        /// Update Portfolio
        /// </summary>
        /// <param name="portfolio"></param>
        /// <returns></returns>
        [HttpPut("api/portfolio/Update")]
        public IActionResult Update([FromBody] Portfolio portfolio)
        {
            _portfolioService.Update(portfolio);

            return Ok("Portfolio Updated");
        }
        /// <summary>
        /// Delete Portfolio
        /// </summary>
        /// <param name="portfolio"></param>
        /// <returns></returns>
        [HttpDelete("api/portfolio/Delete")]
        public IActionResult Delete([FromBody] Portfolio portfolio)
        {
            _portfolioService.Delete(portfolio);

            return Ok("Portfolio Deleted");
        }
    }
}
