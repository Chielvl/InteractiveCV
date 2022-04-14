using InteractiveCVLibrary;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InteractiveCV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        PlayerHand playerHand = new PlayerHand();   

        // GET api/<ValuesController>/5
        [HttpGet("GetCard/{name}")]
        public List<IExample> Get(string name)
        {
            ICard card = playerHand.GetCard(name);
            ICounterCard counterCard = card.Play();
            List<IExample> examples = counterCard.Counter();
            playerHand.RefillHand();
            Debug.WriteLine(examples);
            return examples;
            
        }

        // POST api/<ValuesController>
        [HttpPost()]
        public void PostCard([FromBody] string value)
        {

        }
    }
}
