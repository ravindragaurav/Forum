using System.Collections.Generic;
using Forum.Web.Repository;
using Forum.Domain.Model;

namespace Forum.Web.Service
{
    public class ForumService : IForumService
    {
        private readonly IForumRepository _forumRepository;

        public ForumService(IForumRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public List<Question> GetQuestions()
        {
            return _forumRepository.GetQuestions();
        }

        public Question GetQuestion(int questionId)
        {
            return _forumRepository.GetQuestion(questionId);
        }

        public void PostQuestion(string questionTitle, string questionDetails)
        {
            _forumRepository.PostQuestion(questionTitle,questionDetails);
        }

        public void PostAnswer(int questionId, string answer)
        {
            _forumRepository.PostAnswer(questionId, answer);
        }

        public List<Answer> GetAnswers(int questionId)
        {
            return _forumRepository.GetAnswers(questionId);
        }
    }
}
