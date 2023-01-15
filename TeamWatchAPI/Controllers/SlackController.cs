using Microsoft.AspNetCore.Mvc;
using TeamWatchAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamWatchAPI.Controllers
{
    [Route("api/slack")]
    [ApiController]
    public class SlackController : ControllerBase
    {
        // GET: api/<SlackController>
        [
            HttpPost,
            Consumes("application/x-www-form-urlencoded"),
            Produces("application/json")
        ]
        [Route("command")]

        public SlackResponseDTO CommandWebhook([FromForm] SlackCommandDTO commandDto)
        {
            var response = new SlackResponseDTO();

            response.Blocks = new List<Block>();
            response.Blocks.Add(new Block()
            {
                Type = "section",
                Text = new Text() { Type = "mrkdwn", TextStr = $"Channel is {commandDto.ChannelName} :tada:" }
            });

            return response;
        }


    }
}
