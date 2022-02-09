using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using HashPass.Data;
using HashPass.Dto;
using HashPass.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HashPass.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HashPassController : ControllerBase
    {
        private readonly IHashPassRepo _repository;
        private readonly IMapper _mapper;

        public HashPassController(IHashPassRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/HashPass
        [HttpGet]
        public ActionResult GetAllHashPass()
        {
            var hashPassItems = _repository.GetAllHashPass();
            return Ok(_mapper.Map<IEnumerable<HashPassReadDto>>(hashPassItems));
        }

        //GET api/HashPass/{id}
        [HttpGet("{id}", Name = "GetHashPassById")]
        public ActionResult<IEnumerable> GetHashPassById(int id)
        {
            var hashPassItem = _repository.GetHashPassById(id);

            if (hashPassItem != null)
            {
                return Ok(_mapper.Map<HashPassReadDto>(hashPassItem));
            }

            return NotFound();
        }

        //POST api/HashPass
        [HttpPost]
        public ActionResult<HashPassReadDto> PostCreateHashPass(HashPassCreateDto createHashPassDto)
        {
            var hashPassModel = _mapper.Map<HashPassModel>(createHashPassDto);
            _repository.CreateHashPass(hashPassModel);
            _repository.SaveChanges();

            var hashPassReadDto = _mapper.Map<HashPassReadDto>(hashPassModel);

            //Colocando a rota que pode ser encontrado o item que acabou de ser criado
            return CreatedAtRoute(nameof(GetHashPassById), new { Id = hashPassModel.Id }, hashPassModel);
        }

        //PUT api/HashPass/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateHashPass(int id, HashPassUpdateDto updateHashPassDto)
        {
            var hashPassModelFromRepo = _repository.GetHashPassById(id);

            if (hashPassModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(updateHashPassDto, hashPassModelFromRepo);

            _repository.UpdateHashPass(hashPassModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/HashPass/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialUpdateHashPass(int id, JsonPatchDocument<HashPassUpdateDto> updateHasPassDto)
        {
            var hashPassModelFromRepo = _repository.GetHashPassById(id);

            if (hashPassModelFromRepo == null)
            {
                return NotFound();
            }

            var hashPassToPatch = _mapper.Map<HashPassUpdateDto>(hashPassModelFromRepo);
            updateHasPassDto.ApplyTo(hashPassToPatch, ModelState);

            if (!TryValidateModel(hashPassToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(hashPassToPatch, hashPassModelFromRepo);

            _repository.UpdateHashPass(hashPassModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/HashPass/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteHashPass(int id)
        {
            var hashPassModelFromRepo = _repository.GetHashPassById(id);

            if (hashPassModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteHashPass(hashPassModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}