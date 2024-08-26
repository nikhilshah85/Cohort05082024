using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        static List<string> friends = new List<string>()
       {
           "Alex","Allan","Murphy","Richard","Peter","Parker","Shelby"
       };
        #region Get Methods
        [HttpGet] //HttpGet is by default, if you do not specify this line, it will still work
        [Route("/friends/list")]
        public IActionResult Allfriends()
        {
            return Ok(friends); 
        }

        [HttpGet]
        [Route("/friends/byindex/{position}")]
        public IActionResult GetFriendByPosition(int position) 
        {
            if (friends.Count > position)
            {
                return Ok(friends[position]);
            }
            return NotFound("No Friend found at " + position);
        }
        [HttpGet]
        [Route("/friends/startswith/{chars}")]
        public IActionResult GetFriendByStartName(string chars)
        {
            var data = (from a in friends
                       where a.StartsWith(chars)
                       select a).ToList();

            if(data.Count > 0) 
            {
                return Ok(data);
            }
            return NotFound("No friend Found with name starting with " + chars);
        }
        #endregion


        [HttpPost] //we use HttpPost when a new resource is created
        [Route("/friends/add/{newFriend}")]
        public IActionResult AddNewFriend(string newFriend)
        {
            friends.Add(newFriend);
            return Created("", newFriend + " is added to your friends list");
        }

        [HttpDelete]
        [Route("friends/remove/{position}")]
        public IActionResult DeleteFriend(int position)
        {
            if(friends.Count < position)
            {
                friends.RemoveAt(position);
                return Accepted("Friend Deleted successfully");
            }
            return NotFound("No Friend found at this position");
        }


        [HttpPut]
        [Route("/friends/edit/{position}/{newName}")]
        public IActionResult EditfriendName(int position, string newName)
        {
            if(friends.Count > position) 
            {
                friends[position] = newName;
                return Accepted("Friend Name edited");
            }
            return NotFound("No Friend found at this position");
        }

    }
}
