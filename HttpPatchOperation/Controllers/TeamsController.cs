using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HttpPatchOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        ITeamService _teamSerive;
        public TeamsController(ITeamService teamService)
        {
            _teamSerive = teamService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var teams = _teamSerive.GetTeams();
            return Ok(teams);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Team team)
        {
            if (_teamSerive.GetTeam(id) == null)
            {
                return BadRequest();
            }
            Team updatedTeam = _teamSerive.Edit(team);
            return Ok(updatedTeam);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, JsonPatchDocument<Team> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest(ModelState);
            }

            var team = _teamSerive.GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            patchDocument.ApplyTo(team, ModelState);

            if (ModelState.IsValid)
            {
                return Ok(team);
            }

            return BadRequest(ModelState);
        }
    }
}
