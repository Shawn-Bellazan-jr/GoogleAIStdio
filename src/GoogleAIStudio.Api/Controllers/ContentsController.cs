using GoogleAIStudio.Infrastructure;
using GoogleAIStudio.Infrastructure.Dtos.ContentDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoogleAIStudio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<ContentsController>
        [HttpGet]
        public async Task<string> Get()
        {
            ICollection<PartDto> parts = new List<PartDto>()
            {
                new("Hello")
            };
            ICollection<ContentDto> contents = new List<ContentDto>()
            {
                new("user", parts)
            };
            PromptDto prompt = new(contents);
            var request = await _unitOfWork.FreeformPrompts.SendPrompt(prompt);
            return request;
        }

        // GET api/<ContentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
