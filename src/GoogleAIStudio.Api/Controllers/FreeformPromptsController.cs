using AutoMapper;
using Azure;
using GoogleAIStudio.Core;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure;
using GoogleAIStudio.Infrastructure.Dtos.FreeformPromptDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoogleAIStudio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreeformPromptsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FreeformPromptsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/<PromptsController>
        [HttpGet]
        public async Task<IEnumerable<FreeformPromptDto>> Get()
        {
            var response = await _unitOfWork.FreeformPrompts.GetAllPrompts();
            var dtos = _mapper.Map<IEnumerable<FreeformPromptDto>>(response);
            return dtos;
        }

        // GET api/<PromptsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PromptsController>
        [HttpPost]
        public async Task<FreeformPromptDto?> Post([FromBody] AddFreeformPromptDto prompt)
        {
            var toFreeformPrompt = _mapper.Map<FreeformPrompt>(prompt);
            var response = await _unitOfWork.FreeformPrompts.CreatePrompt(toFreeformPrompt);
            if(response == null) return null;
            await _unitOfWork.Save();
            var toFreeformPromptDto = _mapper.Map<FreeformPromptDto>(response);
            return toFreeformPromptDto;
        }

        // PUT api/<PromptsController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PromptsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
