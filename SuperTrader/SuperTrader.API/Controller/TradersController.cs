using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTrader.Business.Services;
using SuperTrader.Entity.Model;

namespace SuperTrader.API.Controller
{

    [ApiController]
    public class TradersController : ControllerBase
    {
        private ITradersService _tradersService;

        public TradersController(ITradersService tradersService)
        {
            _tradersService = tradersService;
        }
        /// <summary>
        /// Add Trader
        /// </summary>
        /// <param name="trader"></param>
        /// <returns></returns>
        [HttpPost("api/traders/add")]
        public IActionResult Add([FromBody] Traders trader)
        {
          
                _tradersService.Add(trader);
                 return Ok("Trader Added Successfully");
         
        }
        /// <summary>
        /// Get Trader By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/traders/Get/{id}")]
        public Traders Get(int id)
        {
 
           return _tradersService.GetById(id);
 
        }
        /// <summary>
        /// Get All Traders
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/traders/GetAll")]
        public IActionResult GetAll()
        {
            var allTraders = _tradersService.GetAll();

            return Ok(allTraders);
        }
        /// <summary>
        /// Update Trader
        /// </summary>
        /// <param name="trader"></param>
        /// <returns></returns>
        [HttpPut("api/traders/Update")]
        public IActionResult Update([FromBody] Traders trader)
        {
           _tradersService.Update(trader);

            return Ok("Trader Updated");
        }
        /// <summary>
        /// Delete Trader
        /// </summary>
        /// <param name="trader"></param>
        /// <returns></returns>
        [HttpDelete("api/traders/Delete")]
        public IActionResult Delete([FromBody] Traders trader)
        {
               _tradersService.Delete(trader);

            return Ok("Trader Deleted");
        }

    }
}
