using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchService.Domain.Interface.RepositoryInterface;
using SearchService.Services.Interface;

namespace SearchService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchServiceController : ControllerBase
    {
        private readonly ISearchPersonService _searchService;
        private ILoggerManager _loggerManager;

        public SearchServiceController(ISearchPersonService searchService, ILoggerManager loggerManager)
        {
            _searchService = searchService;
            _loggerManager = loggerManager;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpGet]
        [Route("SearchPerson")]

        public async Task<IActionResult> searchPerson(string name)
        {
            try
            {
                _loggerManager.LogInformation("SearchServiceController -  Details fetcheing");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid payload");

                var result = await _searchService.SearchPersonAsync(name);

                if (result == null)
                {
                    _loggerManager.LogInformation("SearchServiceController - User validation Failed");

                    return Ok("Search term cannot be empty");
                    //return Ok(result);

                }
                _loggerManager.LogInformation("SearchServiceController -  Details has been fetched successfully");

                return Ok(result);
            }

            catch (Exception ex)
            {
                _loggerManager.LogError(ex, ex.Message);

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
