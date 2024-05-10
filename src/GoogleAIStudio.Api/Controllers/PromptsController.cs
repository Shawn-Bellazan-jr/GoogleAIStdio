using AutoMapper;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure;
using GoogleAIStudio.Infrastructure.DTOs.PromptDtos;
using GoogleAIStudio.Infrastructure.DTOs.PromptDTOs;
using Microsoft.AspNetCore.Mvc;

namespace GoogleAIStudio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PromptsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ReadPromptDto>> Get()
        {
            var response = await _unitOfWork.Prompts.GetAsync();
            var toDto = _mapper.Map<IEnumerable<ReadPromptDto>>(response);
            return toDto;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<Prompt?> Post([FromBody] PromptDto value)
        {
            var prompt = _mapper.Map<Prompt>(value);
            var response = await _unitOfWork.Prompts.AddAsync(prompt);
            await _unitOfWork.Save();
            if (response == null) NotFound();
            var exist = await _unitOfWork.Prompts.ExistAsync(prompt);
            if (!exist) NotFound(prompt);
            return response;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
