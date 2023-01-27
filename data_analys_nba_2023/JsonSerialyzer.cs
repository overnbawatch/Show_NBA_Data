using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace data_analys_nba_2023
{
    public class Api_Seasons
    {
        public int status { get; set; }
        public string message { get; set; }
        public int results { get; set; }
        public List<object> filters { get; set; }
        public List<string> seasons { get; set; }
    }

    public class Root_Seasons
    {
        public Api_Seasons api { get; set; }
    }
    public class Api_Leagues
    {
        public int status { get; set; }
        public string message { get; set; }
        public int results { get; set; }
        public List<object> filters { get; set; }
        public List<string> leagues { get; set; }
    }

    public class Root_Leagues
    {
        public Api_Leagues api { get; set; }
    }

    public class Score
    {
        public string points { get; set; }

    }
    public class Team
    {
        public string teamId { get; set; }
        public string shortName { get; set; }
        public string fullName { get; set; }
        public string nickName { get; set; }
        public string logo { get; set; }
        public Score score { get; set; }

    }
    public class Games
    {
        public string seasonYear { get; set; }
        public string league { get; set; }
        public string gameId { get; set; }
        public string startTimeUTC { get; set; }
        public string endTimeUTC { get; set; }
        public string arena { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string clock { get; set; }
        public string gameDuration { get; set; }
        public string currentPeriod { get; set; }
        public string halftime { get; set; }
        public string EndOfPeriod { get; set; }
        public string seasonStage { get; set; }
        public string statusShortGame { get; set; }
        public string statusGame { get; set; }
        public Team vTeam { get; set; }
        public Team hTeam { get; set; }

    }
    public class Api_Game
    {
        public int status { get; set; }
        public string message { get; set; }
        public int results { get; set; }
        public IList<string> filters { get; set; }
        public IList<Games> games { get; set; }

    }
    public class Root_Gama
    {
        public Api_Game api { get; set; }

    }
}
