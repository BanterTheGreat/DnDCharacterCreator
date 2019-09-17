using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Data;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreator.Controllers
{
    [Route("api/[controller]")]

    public class EntityController : Controller
    {

        private readonly ICreatorRepository _repository;

        public EntityController(ICreatorRepository repository)
        {
            _repository = repository;
        }


        [HttpGet("GetAllLanguages")]
        public IActionResult GetAllLanguages()
        {
            try
            {
                return Ok(_repository.GetAllLanguages());
            }
            catch (Exception ex)
            {

                return BadRequest("Failed to get languages: " + ex);
            }


        }
        [HttpGet("GetAllBackgrounds")]
        public IActionResult GetAllBackgrounds()
        {
            try
            {
                return Ok(_repository.GetAllBackgrounds());
            }
            catch (Exception ex)
            {

                return BadRequest("Failed to get backgrounds: " + ex);
            }


        }

        [HttpGet("GetAllProficiencies")]
        public IActionResult GetAllProficiencies()
        {
            try
            {
                return Ok(_repository.GetAllProficiencies());
            }
            catch (Exception ex)
            {

                return BadRequest("Failed to get proficiencies: " + ex);
            }


        }

        [HttpGet("GetAllRaces")]
        public IActionResult GetAllRaces()
        {
            try
            {
                return Ok(_repository.GetAllRaces());
            }
            catch (Exception ex)
            {

                return BadRequest("Failed to get races: " + ex);
            }


        }

        [HttpGet("GetRaceTraits/{race}")]
        public IActionResult GetRaceTraits(string race)
        {
            try
            {
                return Ok(_repository.GetRaceTraits(race));
            }
            catch (Exception ex)
            {

                return BadRequest("Failed to get traits: " + ex);
            }


        }

        [HttpGet("GetAllClasses")]
        public IActionResult GetAllClasses()
        {
            try
            {
                return Ok(_repository.GetAllClasses());
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to get classes: " + ex);
            }
        }

        [HttpGet("GetAbilities/{input}")]
        public IActionResult GetAbilities(string input)
        {
            try
            {
                return Ok(_repository.GetAbilities(input));
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to get abilities: " + ex);
            }
        }

    }
}