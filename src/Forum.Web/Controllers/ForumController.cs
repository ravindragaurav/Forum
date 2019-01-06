using Microsoft.AspNetCore.Mvc;
using Forum.Web.Manager;
using System;

namespace Forum.Web.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumManager _forumManager;

        public ForumController(IForumManager forumManager)
        {
            _forumManager = forumManager;
        }

        [Route("forum/getquestions")]
        [HttpGet]
        public ActionResult GetQuestions()
        {
            var questions = _forumManager.GetQuestions();
            return Json(questions);
        }
        [Route("forum/getquestion")]
        [HttpGet]
        public ActionResult GetQuestion([FromQuery] int questionId)
        {
            var question = _forumManager.GetQuestion(questionId);
            return Json(question);
        }

        [Route("forum/postquestion")]
        [HttpGet]
        public void PostQuestion([FromQuery] string questionTitle, [FromQuery] string questionDetails)
        {
            try

            {
                _forumManager.PostQuestion(questionTitle, questionDetails);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [Route("forum/postanswer")]
        [HttpGet]
        public void PostAnswer([FromQuery] int questionId, [FromQuery] string answer)
        {
            _forumManager.PostAnswer(questionId, answer);
        }

        [Route("forum/getanswers")]
        [HttpGet]
        public ActionResult GetAnswers([FromQuery] int questionId)
        {
            var answers = _forumManager.GetAnswers(questionId);
            return Json(answers);
        }

    }
}