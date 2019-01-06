using System;

namespace Forum.Domain.Model
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerPosted { get; set; }
        public DateTime DatePosted { get; set; }
        public int QuestionId { get; set; }
    }
}
