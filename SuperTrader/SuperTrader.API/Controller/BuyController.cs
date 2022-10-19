using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTrader.Business.Services;
using SuperTrader.Entity.Model;

namespace SuperTrader.API.Controller
{
    
    [ApiController]
    public class BuyController : ControllerBase
    {
        private IShareService _shareService;
        private ITradersService _tradersService;
        private IBuyService _buyService;

        public BuyController(IShareService shareService, ITradersService tradersService, IBuyService buyService)
        {
            _shareService = shareService;
            _tradersService = tradersService;
            _buyService = buyService;
        }

        /// <summary>
        /// Add Buy
        /// </summary>
        /// <param name="buy"></param>
        /// <returns></returns>
        [HttpPost("api/buy/add")]
        public IActionResult Add([FromBody] Buy buy)
        {

            _buyService.Add(buy);
            return Ok("Buy Added Successfully");

        }

        /// <summary>
        /// Get Buy By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/buy/Get/{id}")]
        public Buy Get(int id)
        {
            return _buyService.GetById(id);
        }
        [HttpGet("api/buy/Get/{id}")]
        
        /// <summary>
        /// Get All Buys
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/buy/GetAll")]
        public IActionResult GetAll()
        {
            var allBuy = _buyService.GetAll();

            return Ok(allBuy);
        }




        /// <summary>
        /// Update Buy
        /// </summary>
        /// <param name="buy"></param>
        /// <returns></returns>
        [HttpPut("api/buy/Update")]
        public IActionResult Update([FromBody] Buy buy)
        {
            _buyService.Update(buy);

            return Ok("Buy Updated");
        }
        /// <summary>
        /// Delete Buy
        /// </summary>
        /// <param name="buy"></param>
        /// <returns></returns>
        [HttpDelete("api/buy/Delete")]
        public IActionResult Delete([FromBody] Buy buy)
        {
            _buyService.Delete(buy);

            return Ok("Buy Deleted");
        }

    }
}
