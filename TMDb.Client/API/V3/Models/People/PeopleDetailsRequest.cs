﻿using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}")]
    public class PeopleDetailsRequest : PeopleRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "append_to_response",
            ParameterType = ParameterType.Query)]
        public virtual string AppendToResponse { get; set; }
    }
}