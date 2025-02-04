using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDBManager.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string StudioDeveloper { get; set; } = default!;
        public string Style { get; set; } = default!;
        public DateTime ReleaseDate { get; set; }
        public bool HasMultiplayer { get; set; }
        public int SoldUnits { get; set; }
    }
}
