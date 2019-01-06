using Microsoft.AspNetCore.Mvc;

namespace Forum.Web.Controllers
{
    public class ForumController : Controller
    {
        [Route("forum/getquestions")]
        [HttpGet]
        public ActionResult GetQuestions()
        {
            var questions = "this is a thing here"; 
            return Json(questions);
        }
    }
}