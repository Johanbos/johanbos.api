using System;
using GraphQL.Types;
using JohanBos.Services;
using System.Collections.Generic;
using JohanBos.Api.Types;

namespace JohanBos.Api
{
    public class JohanBosQuery : ObjectGraphType<object>
    {
        public JohanBosQuery(IProfileService profileService)
        {
            Name = "Query";
            Field<ProfileType>("Profile", resolve: context => profileService.GetProfile());
        }
    }
}