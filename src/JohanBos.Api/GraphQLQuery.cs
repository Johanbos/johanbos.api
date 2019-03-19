using System;
using GraphQL.Types;
using JohanBos.Services;
using System.Collections.Generic;
using JohanBos.Api.Types;

namespace JohanBos.Api
{
    public class GraphQLQuery : ObjectGraphType<object>
    {
        public GraphQLQuery(IBioService bioService, IHistoryService historyService)
        {
            Name = "Query";
            FieldAsync<BioType>("Profile", resolve: async context => await bioService.GetBio());
            FieldAsync<ListGraphType<PassionAreaType>>("PassionAreas", resolve: async context => await bioService.GetAllPassionAreas());
            FieldAsync<ListGraphType<AchievementType>>("Achievements", resolve: async context => await historyService.GetAllAchievements());
            FieldAsync<ListGraphType<EmployerType>>("Employers", resolve: async context => await historyService.GetAllEmployers());
        }
    }
}