using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Account
{
    public abstract class AccountListBaseRequest : TMDbRequest
    {
        public AccountListBaseRequest()
        {
            Page = 1;
        }

        [ApiParameter(
            Name = "account_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? AccountId { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "sort_by",
            ParameterType = ParameterType.Query)]
        public virtual AccountListSortBy? SortBy { get; set; }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }
    }
}