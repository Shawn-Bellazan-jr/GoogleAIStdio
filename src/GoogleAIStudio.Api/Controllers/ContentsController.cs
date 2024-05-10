using AutoMapper;
using GoogleAIStudio.Infrastructure.DTOs.PromptDtos;
using GoogleAIStudio.Infrastructure.DTOs.PromptDTOs;
using GoogleAIStudio.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Resources.ContentResources;
using GoogleAIStudio.Infrastructure.DTOs.ContentDto;

namespace GoogleAIStudio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContentsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<ContentDto>> GetAllContent()
        {
            var response = await _unitOfWork.Contents.GetAsync();

            if (response == null) BadRequest();
            else if (response.Count() <= 0) NoContent();

            var toDto = _mapper.Map<IEnumerable<ContentDto>>(response);
            return toDto;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{resource.Id}")]
        public async Task<ContentDto?> Get(GetContentResource resource)
        {
            // 1.  map dto to dbset
            var dbSet = _mapper.Map<Content>(resource);

            // 2. get dbset from database
            var dbResponse = await _unitOfWork.Contents.GetAsync(dbSet);
            // 2.1 return not found if response is null
            if (dbResponse == null) NotFound();

            // 3. map db response to a read dto
            var responseDto = _mapper.Map<ContentDto>(dbResponse);
            // 4. return response as a dto
            return responseDto;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ContentDto> Post([FromBody] PostContentResource resource)
        {
            // 1.1 map dto to dbset
            var dbSet = _mapper.Map<Content>(resource);
            var dbResponse = await _unitOfWork.Contents.AddAsync(dbSet);
            await _unitOfWork.Save();
            if (dbResponse == null) NotFound();
            var contentDto = _mapper.Map<ContentDto>(dbResponse);
            return contentDto;
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
