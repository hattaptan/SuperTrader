using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTrader.Business.Services;
using SuperTrader.Entity.Model;

namespace SuperTrader.API.Controller
{
     
    [ApiController]
    public class SellController : ControllerBase
    {
        private IShareService _shareService;
        private ITradersService _traderService;
        private ISellService _sellService;

        public SellController(IShareService shareService, ITradersService traderService, ISellService sellService)
        {
            _shareService = shareService;
            _traderService = traderService;
            _sellService = sellService;
        }

        /// <summary>
        /// Add Sell
        /// </summary>
        /// <param name="sell"></param>
        /// <returns></returns>
        [HttpGet("api/sell/add")]
        public IActionResult Add()
        {
            var trader = _traderService.GetById(2);
            var share = _shareService.GetById(1);
            _sellService.Add(new Sell
            {
                share=share,
                traderId = trader.id,
                

            });
            return Ok("Sell Added Successfully");

        }



        /// <summary>
        /// Get Sell By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/sell/Get/{id}")]
        public Sell Get(int id)
        {
            return _sellService.GetById(id);
        }

        /// <summary>
        /// Get All Sell
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/sell/GetAll")]
        public IActionResult GetAll()
        {
            var allSell = _sellService.GetAll();

            return Ok(allSell);
        }



        /// <summary>
        /// Update Sell
        /// </summary>
        /// <param name="sell"></param>
        /// <returns></returns>
        [HttpPut("api/sell/Update")]
        public IActionResult Update([FromBody] Sell sell)
        {
            _sellService.Update(sell);

            return Ok("Sell Updated");
        }
        /// <summary>
        /// Delete Sell
        /// </summary>
        /// <param name="sell"></param>
        /// <returns></returns>
        [HttpDelete("api/sell/Delete")]
        public IActionResult Delete([FromBody] Sell sell)
        {
            _sellService.Delete(sell);

            return Ok("Sell Deleted");
        }






    }
}
