using Dapper;
using GameStoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreLibrary.Repositories
{
    public class GameRepository : Connection
    {
        public List<GameModel> GetAllGames()
        {
            List<GameModel> games = cnnDatabase.Query<GameModel>("select * from Games").ToList();

            return games;
        }

        public GameModel GetGameById(int id)
        {
            return cnnDatabase.Query<GameModel>("select * from Games where Id=@id",
                new { id }).SingleOrDefault();
        }

        public bool Create(GameModel game)
        {
            cnnDatabase.Execute("insert into Games values (@Name, @Platform, @Price)", game);

            return true;
        }

        public bool Delete(int id)
        {
            return cnnDatabase.Execute("delete from Games where id=@ID",
            new { ID = id }) == 1;
        }

        public bool Update(GameModel game)
        {
            cnnDatabase.Execute(@"update Games set Name = @Name, Platform = @Platform, Price = @Price where Id=@Id", new
            {
                id = game.Id,
                Name = game.Name,
                Platform = game.Platform,
                Price = game.Price

            });

            return true;
        }
    }
}
