using Microsoft.AspNetCore.Mvc;
using session1.Models;
namespace session1.Controllers
{
    public class MoviesController : Controller
    {
        // [NonAction]
        public string Index()
        {
            return "Hello from Movies Controller";
        }
        //  [HttpGet]
        //  public ContentResult GetMovie(int? id)
        //  {
        //return $"Movie ID: {id}";
        // ContentResult result = new ContentResult();
        // result.Content = $"Movie ID: {id}";
        // result.ContentType = "text/html";
        //result.StatusCode = 200;
        //    return Content($"Movie ID: {id}");
        // }
        //public void GetMovie(int? id)
        //{

        //}
        //--------------------------
        [HttpGet]
        public IActionResult GetMovie(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id < 10)
            {
                return NotFound();
            }
            else
            {
                // return Ok($"Movie ID: {id}");
                return Content($"Movie ID: {id}");
                // return Json(new { MovieID = id });
                // return new ObjectResult(new { MovieID = id }) { StatusCode = 200 };

            }
        }
        //---------------
        [HttpGet]
        public IActionResult TestRedirectAction()
        {
            return RedirectToAction("GetMovie","Movies", new { id = 10 });
            // return Redirect("https://localhost:44354/Movies/GetMovie/10");
        }
    
    [HttpPost]
    public IActionResult TestModelBinding([FromBody]Movie movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            return Content($"Movie ID: {movie.Id} - Movie Title: {movie.Title}");
        }

    }
}
