using Domain.Common;

namespace Domain.Entities.Battle
{
    public class KoffieBattle : TimePersonEntity
    {
        public int Id { get; set; }
        public int GroteKoffie { get; set; }
        public int MediumKoffie { get; set; }
    }
}
