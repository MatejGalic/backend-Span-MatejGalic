using AutoMapper;
using backend_Span_MatejGalic.DTOs;
using backend_Span_MatejGalic.Models;
using backend_Span_MatejGalic.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_Span_MatejGalic.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IDatabaseRepo _repository;
        private readonly IMapper _mapper;

        public PersonController(IDatabaseRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ActionResult<IEnumerable<Person>> GetAllPeople()
        {
            var personItems = _repository.GetAllPeople();
            
            return Ok(_mapper.Map<IEnumerable<PersonReadDTO>>(personItems));
        }
    }
}
