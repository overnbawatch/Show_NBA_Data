using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_analys_nba_2023
{
    public class GlobalValariables
    {
        public static string json_body { get; set; }

        public static string dir_json = "../../json_data/{0}.json";

        public class ApiType
        {

            public static string seasons = "seasons/";

            public static string league = "leagues/";

            public static string teams = "teams/";

            public static string players = "players/";

            public static string games = "games/";

            public static string gamedetails = "gamedetails/";

            public static string standings = "standings/";

            public static string statistics = "statistics/";
        }

        

    }
}
