using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeamService
    {
        List<Team> GetTeams();
        Team GetTeam(int id);
        Team Edit(Team team);
    }
}
