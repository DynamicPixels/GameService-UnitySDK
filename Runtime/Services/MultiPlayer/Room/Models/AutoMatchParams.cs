using Newtonsoft.Json;

namespace DynamicPixels.GameService.Services.MultiPlayer.Room.Models
{
    public record AutoMatchParams
    {
        public int MinPlayer { get; set; } = 2;
        public int MaxPlayer { get; set; } = 2;
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}