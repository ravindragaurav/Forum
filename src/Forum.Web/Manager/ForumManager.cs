using System.Collections.Generic;
using Forum.Web.Service;
using Forum.Domain.Model;

namespace Forum.Web.Manager
{
    public class ForumManager : IForumManager
    {
        private readonly IForumService _forumService;

        public ForumManager(IForumService forumService)
        {
            _forumService = forumService;
        }


        public List<Question> GetQuestions()
        {
            return _forumService.GetQuestions();
        }

        public Question GetQuestion(int questionId)
        {
            return _forumService.GetQuestion(questionId);
        }

        public void PostQuestion(string questionTitle, string questionDetails)
        {
            _forumService.PostQuestion(questionTitle, questionDetails);
        }

        public void PostAnswer(int questionId, string answer)
        {
            _forumService.PostAnswer(questionId, answer);
        }

        public List<Answer> GetAnswers(int questionId)
        {
           return _forumService.GetAnswers(questionId);
        }
    }
}
