using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreLibrary.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Name { get; set; }
        [DisplayName("Plataforma")]

        public string Platform { get; set; }
        [DisplayName("Valor")]

        public decimal Price { get; set; }
    }
}
