using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiPostEndpoint("/account/{account_id}/watchlist")]
    public class AddToWatchlistRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "account_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? AccountId { get; set; }

        //[ApiParameter(
        //    Name = "Content-Type",
        //    ParameterType = ParameterType.Header)]
        //[Required]
        //public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        // TODO: Add validation - only acceptable values are Movie or TV AND lower cased
        // TODO: Make nullable when "GetDescriptionAttribute" logic is fixed (currently blows up when enum value is nullable)
        [ApiParameter(
            Name = "media_type",
            ParameterType = ParameterType.JsonBody,
            Option = SerializationOption.EnumDescription)]
        [Required]
        public virtual MediaType MediaType { get; set; }

        [ApiParameter(
            Name = "media_id",
            ParameterType = ParameterType.JsonBody)]
        [Required]
        public virtual int? MediaId { get; set; }

        [ApiParameter(
            Name = "watchlist",
            ParameterType = ParameterType.JsonBody)]
        [Required]
        public virtual bool? Watchlist { get; set; }
    }
}