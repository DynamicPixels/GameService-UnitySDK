using System;
using Newtonsoft.Json;

namespace DynamicPixels.GameService.Services.Authentication.Models
{
    [Serializable]
    public class LoginWithSteamParams
    {
        [JsonProperty("steam_id")]
        public string SteamId { get; set; }
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        [JsonProperty("name")]
        public string Name{ get; set; }
        [JsonProperty("device_info")]
        public readonly User.Models.Device DeviceInfo = new User.Models.Device(ServiceHub.SystemInfo);

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}