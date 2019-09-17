using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreator.Controllers
{
    [Route("api/[controller]")]
    public class AppController : Controller
    {

        private readonly ICreatorRepository _repository;

        public AppController(ICreatorRepository repository)
        {
            _repository = repository;
        }






    }
}
