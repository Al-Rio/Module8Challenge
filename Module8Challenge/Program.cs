namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* list of 6 Video Games*/
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5});
            games.Add(new VideoGame { Name = "Call of Duty", Genre = "First-Person Shooter", Rating = 4.3 });
            games.Add(new VideoGame { Name = "eFootball", Genre = "Sports Simulation", Rating = 3.5 });
            games.Add(new VideoGame { Name = "Viewfinder", Genre = "Puzzle", Rating = 3.2 });
            games.Add(new VideoGame { Name = "Hitman: World of Assassination", Genre = "Stealth Action", Rating = 4.8 });
            games.Add(new VideoGame { Name = "Monument Valley", Genre = "Puzzle", Rating = 4.9 });
            ;

            /* List top rated games with a rating of 4 or higher */
            var topRatedGames = (from game in games where game.Rating >= 4 select game).ToList();

            /*Sort the Top Rated Games list by name.*/
            var sortedGames = (from game in topRatedGames orderby game.Name select game).ToList();
            
            /*Display the games in the sortedGames list*/
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}
