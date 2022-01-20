using System.Collections;
using AutoMapper;
using HashPass.Data;
using Microsoft.AspNetCore.Mvc;

namespace HashPass.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HashPassController : ControllerBase
    {
        private readonly IHashPassRepo _repository;
        //private readonly IMapper _mapper;

        public HashPassController(IHashPassRepo repository)
        {
            _repository = repository;
            //_mapper = mapper;
        }

        //GET api/HashPass
        [HttpGet]
        public ActionResult GetAllHashPass()
        {
            return Ok(_repository.GetAllHashPass());
            //var hashPassItems = _repository.GetAllHashPass();
            //return Ok(_mapper.Map<>);
        }

        //GET api/HashPass/{id}
        [HttpGet("{id}")]
        public ActionResult<IEnumerable> GetHashPassById(int id)
        {
            return Ok(_repository.GetHashPassById(id));
        }
    }
}