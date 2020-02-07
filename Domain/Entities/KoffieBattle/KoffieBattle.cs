using Domain.Common;
using Domain.Enum;

namespace Domain.Entities
{
    public class KoffieBattle : TimePersonEntity
    {
        public int Id { get; set; }
        public int GroteKoffie { get; set; }
        public int MediumKoffie { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}