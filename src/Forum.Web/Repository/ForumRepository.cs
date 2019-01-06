using System;
using System.Collections.Generic;
using System.Linq;
using Forum.Domain.Model;
using Forum.Domain.Wrapper.Dapper;

namespace Forum.Web.Repository
{
    public class ForumRepository : IForumRepository
    {
        private readonly IDapperWrapper _dapperWrapper;

        public ForumRepository(IDapperWrapper dapperWrapper)
        {
            _dapperWrapper = dapperWrapper;
        }

        public List<Question> GetQuestions()
        {
            var questions = _dapperWrapper.Query<Question>("SELECT * FROM Question ORDER BY DatePosted DESC", null);
            return questions.ToList();
        }

        public Question GetQuestion(int questionId)
        {
            var param = new { QuestionId = questionId };
            var question = _dapperWrapper.Query<Question>("SELECT * FROM Question WHERE QuestionId = @QuestionId", param);
            return question.ElementAt(0);
        }

        public void PostQuestion(string questionTitle, string questionDetails)
        {
            var questionToPost = new
            {
                QuestionTitle = questionTitle,
                QuestionDetails = questionDetails,
                DatePosted = DateTime.Now
            };
            try
            {
                _dapperWrapper.Execute("INSERT INTO [Question] VALUES (@QuestionTitle, @QuestionDetails, @DatePosted)", questionToPost);
            }
            catch (Exception e)
            {

            }

        }

        public void PostAnswer(int questionId, string answer)
        {
            var answerToPost = new
            {
                AnswerPosted = answer,
                DatePosted = DateTime.Now,
                QuestionId = questionId
            };

            try
            {
                _dapperWrapper.Execute("INSERT INTO [Answer] VALUES (@AnswerPosted, @DatePosted,@QuestionId)", answerToPost);
            }
            catch (Exception e)
            {

            }
        }

        public List<Answer> GetAnswers(int questionId)
        {
            var param = new { QuestionId = questionId };
            var answers = _dapperWrapper.Query<Answer>("SELECT * FROM Answer WHERE QuestionId = @QuestionId", param);
            return answers.ToList();
        }
    }
}
