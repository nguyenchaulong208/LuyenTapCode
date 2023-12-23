using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs_Example_1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*
         Trong ví dụ trên, UsersController có các phương thức tương ứng với các yêu cầu HTTP:

        GET /api/users trả về danh sách người dùng.
        GET /api/users/{id} trả về người dùng cụ thể theo ID.
        POST /api/users tạo một người dùng mới.
         */
        private static List<string> users = new List<string>
    {
        "User1",
        "User2",
        "User3"
    };

        // GET: api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return users;
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id >= 0 && id < users.Count)
            {
                return users[id];
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/users
        [HttpPost]
        public IActionResult Post([FromBody] string user)
        {
            users.Add(user);
            return CreatedAtAction(nameof(Get), new { id = users.Count - 1 }, user);
        }
    }
}
