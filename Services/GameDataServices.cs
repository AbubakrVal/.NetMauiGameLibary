using System;
using System.Collections.Generic;
using System.linq;
using System.text;
using System.Threading.Tasks;


namespace .NetMauiGameLibary.Services
{
    public class GameDataServices
    {
        private List<GameInformation> _gameInformation = new list<GameInformation>();


        
        public List<GameInformation> GetAllGameInformation()
        {
            return _gameInformation; 
        }

        public void UpdateGameInformation(GameInformation gameInformation)
        {
           if (!string.iNullorEmpty(gameInformation.Id))
           {
                //update
                var uniqueGame = GetgameInformationById(gameInformation.Id);

                int postion = _gameInformation.IndexOf(uniqueGame);

                _gameInformation[postion] = gameInformation;
            }
            else
            {
                //insert
                _gameInformation.Add(gameInformation)
            }
        }

        public GameInformation GetgameInformationById(string id)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Id == id).FirstOrDefault(); 
        }
        public List<GameInformation> GetgameInformationByTitle(string title)
        {
            return _gameInformation.Where(gameInfo => gameInfo.Title == title).FirstOrDefault(); 
        }
    }
}