using System;

namespace JohanBos.Models
{
    public class Achievement
    {
        public string Title { get; set; }
        public string Motivator { get; set; }
        public AchievementType AchievementType { get; set; }
        public DateTime? Completed { get; set; }
        public string Reference { get; set; }
    }
}
