using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("api/get-all-author")]
        public string GetAllAuthor()
        {
            return "Hello from get all author";
        }

        [Route("books/{id}")]
        public string GetById(int id)
        {
            return "Hello" + id;
        }

        [Route("books/{id}/author/{authorName}")]
        public string GetAuthorAddressById(int id, string authorName)
        {
            return "Hello " + id+ " "+ authorName;
        }

        [Route("search")]
        public string SearchBooks(int id, string authorName, string name, int rating, int price)
        {
            return "Hello from search";
        }


    }
}
