using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace IAP.NET.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PurchaseProvider
    {
        /// <summary>
        /// google play store
        /// </summary>
        [EnumMember(Value = "Google")]
        Google,
        
        /// <summary>
        /// Apple appstore.
        /// </summary>
        [EnumMember(Value = "Apple")]
        Apple,
        
        /// <summary>
        /// Steam store.
        /// </summary>
        [EnumMember(Value = "Steam")]
        Steam
    }
}