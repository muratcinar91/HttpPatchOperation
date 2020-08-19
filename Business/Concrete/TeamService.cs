using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TeamService : ITeamService
    {
        IInMemoryTeamsAndPlayers inMemoryTeamsAndPlayers;
        public TeamService(IInMemoryTeamsAndPlayers inMemoryTeamsAndPlayers)
        {
            this.inMemoryTeamsAndPlayers = inMemoryTeamsAndPlayers;
        }

        public Team Edit(Team team)
        {
            var existingTeam = GetTeam(team.Id);

            if (existingTeam != null)
            {
                existingTeam.LogoUrl = team.LogoUrl;
                existingTeam.Name = team.Name;
                existingTeam.Players = team.Players;
            }
            return existingTeam;
        }

        public Team GetTeam(int id)
        {
            return inMemoryTeamsAndPlayers.GetTeamsInMemory().FirstOrDefault(x => x.Id == id);
        }

        public List<Team> GetTeams()
        {
            return inMemoryTeamsAndPlayers.GetTeamsInMemory();
        }
    }
}
