using GraphQL.Types;
using JohanBos.Models;

namespace JohanBos.Api.Types
{
    public class AchievementType : ObjectGraphType<Achievement>
    {
        public AchievementType()
        {
            Name = nameof(Achievement);
            Field(h => h.Title);
            Field(h => h.Motivator);
            Field(h => h.Completed, nullable: true);
            Field(h => h.Reference, nullable: true);
            //Field(h => h.AchievementType);
        }
    }
}