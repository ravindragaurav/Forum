using System.Collections.Generic;
using Forum.Domain.Model;

namespace Forum.Web.Service
{
    public interface IForumService
    {
        List<Question> GetQuestions();
        Question GetQuestion(int questionId);
        void PostQuestion(string questionTitle, string questionDetails);
        void PostAnswer(int questionId, string answer);
        List<Answer> GetAnswers(int questionId);
    }
}