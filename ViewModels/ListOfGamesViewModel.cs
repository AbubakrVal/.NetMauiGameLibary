using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMauiGameLibary.Services;
using NetMauiGameLibary.Models;


namespace NetMauiGameLibary.ViewModels
{
    public class ListOfGamesViewModel
    {
        private GameDataServices _gameDataServices;

        private List<GameInformation> _games;

        public List<GameInformation> Games
        {
            get { return _games; }
            set { _games = value; }
        }
        

        public ListOfGamesViewModel(GameDataServices services)
        {
            _gameDataServices = services;
        }

    }
}