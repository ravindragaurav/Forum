using System;

namespace Forum.Domain.Model
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDetails { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
