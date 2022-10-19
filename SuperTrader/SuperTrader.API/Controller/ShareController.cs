using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperTrader.Business.Services;
using SuperTrader.Entity.Model;

namespace SuperTrader.API.Controller
{
    
    [ApiController]
    public class ShareController : ControllerBase
    {
        private IShareService _shareService;

        public ShareController(IShareService shareService)
        {
            _shareService = shareService;
        }
        /// <summary>
        /// Add Share
        /// </summary>
        /// <param name="share"></param>
        /// <returns></returns>
        [HttpPost("api/share/add")]
        public IActionResult Add([FromBody] Share share)
        {

            _shareService.Add(share);
            return Ok("Share Added Successfully");

        }
        /// <summary>
        /// Get Share By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("api/share/Get/{id}")]
        public Share Get(int id)
        {
            return _shareService.GetById(id);
        }

 
        /// <summary>
        /// Get All Share
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/share/GetAll")]
        public IActionResult GetAll()
        {
            var allShare = _shareService.GetAll();

            return Ok(allShare);
        }


        /// <summary>
        /// Update Share
        /// </summary>
        /// <param name="share"></param>
        /// <returns></returns>
        [HttpPut("api/share/Update")]
        public IActionResult Update([FromBody] Share share)
        {
            var updatedDate = _shareService.GetAll().Where(x => x.updatedDate >= DateTime.Now.AddHours(1)).FirstOrDefault();
            if(updatedDate != null)
            {
                _shareService.Update(share);
                return Ok("Share Updated");
            }
            else
            {
                return BadRequest("it has not been one hour since the updated time");
            }
                

           
        }
        /// <summary>
        /// Delete Share
        /// </summary>
        /// <param name="share"></param>
        /// <returns></returns>
        [HttpDelete("api/share/Delete")]
        public IActionResult Delete([FromBody] Share share)
        {
            _shareService.Delete(share);

            return Ok("Share Deleted");
        }

    }
}
