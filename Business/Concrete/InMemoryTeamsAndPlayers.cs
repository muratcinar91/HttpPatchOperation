using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class InMemoryTeamsAndPlayers : IInMemoryTeamsAndPlayers
    {
        public List<Team> GetTeamsInMemory()
        {
            return new List<Team>
            {
                 new Team
                 {
                      Id =1,
                      Name = "Beşiktaş JK",
                      Players = new List<Player>
                      {
                          new Player{
                                     Name ="Utku Yuvakuran",
                                     BirthDate = new DateTime(1997,11,2),
                                     Nationality="Türkiye",
                                     Position ="Kaleci"
                                    },
                          new Player {
                                       Name="Ersin Destanoğlu",
                                       BirthDate = new DateTime(2001,1,1),
                                       Nationality ="Türkiye",
                                       Position = "Kaleci"
                                     },
                          new Player {
                                       Name="Domagoj Vida",
                                       BirthDate = new DateTime(1989,4,29),
                                       Nationality ="Türkiye",
                                       Position = "Stoper"
                                     }
                      }

                 },
                 new Team
                 {
                      Id=2,
                      Name = "Fenerbahçe SK",
                      Players = new List<Player>
                      {
                          new Player{
                                     Name ="Vedat Muriqi",
                                     BirthDate = new DateTime(1994,6,16),
                                     Nationality="Kosova",
                                     Position ="Forvet"
                                    },
                          new Player {
                                       Name="Luis Gustavo Dias",
                                       BirthDate = new DateTime(1987,7,27),
                                       Nationality ="Brazilya",
                                       Position = "Orta Saha"
                                     }
                      }

                 }
            };
        }
    }
}
