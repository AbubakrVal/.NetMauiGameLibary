using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMauiGameLibary.Models;


namespace NetMauiGameLibary.Services
{
    public class GameDataServices
    {
        private List<GameInformation> _gameInformation = new List<GameInformation>();


        
    public List<GameInformation> GetAllGameInformation()
    {
        return _gameInformation; 
    }

    public void CreateFakeGameInformation()
    {
        _gameInformation.Add(new GameInformation
        {
            Id = Guid.NewGuid().ToString(),
            Title = "The Legend of Zelda: Breath of the Wild",
            GameType = "Action-Adventure",
            CompanyName = "Nintendo",
            Genre = "Adventure",
            AgeRestriction = 10,
            Multiplayer = false,
            Description = "An open-world action-adventure game set in the kingdom of Hyrule.",
            Image = "zelda.jpg",
            YearPublished = new DateTime(2017, 3, 3)
        });
        _gameInformation.Add(new GameInformation
        {
            Id = Guid.NewGuid().ToString(),
            Title = "Super Mario Odyssey",
            GameType = "Platformer",
            CompanyName = "Nintendo",
            Genre = "Platformer",
            AgeRestriction = 6,
            Multiplayer = false,
            Description = "A 3D platformer where Mario travels across various kingdoms to rescue Princess Peach.",
            Image = "mario.jpg",
            YearPublished = new DateTime(2017, 10, 27)
        });
    }

        public void UpdateGameInformation(GameInformation gameInformation)
        {
           if (!string.IsNullOrEmpty(gameInformation.Id))
           {
                //update
                var uniqueGame = GetgameInformationById(gameInformation.Id);

                int postion = _gameInformation.IndexOf(uniqueGame);

                _gameInformation[postion] = gameInformation;
            }
            else
            {
                //insert
                string id = Guid.NewGuid().ToString();
                gameInformation.Id = id;
                _gameInformation.Add(gameInformation);
            }
        }

        public GameInformation GetgameInformationById(string id)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Id == id).FirstOrDefault(); 
        }
        
        public List<GameInformation> GetgameInformationByTitle(string title)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Title == title).ToList();
        }


    }
}