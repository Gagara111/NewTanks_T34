using Microsoft.AspNetCore.Mvc;
using NewTanks.Game.Interfaces;

namespace NewTanks.Controllers
{

    [ApiController]

    public class ApiGameController : ControllerBase

    {

        [HttpPost]
        [Route("move")]
        public void Move()

        {


        }

        [HttpPost]
        [Route("Atak")]
        public void Atak()
        {


        }

        [HttpPost]
        [Route("Die")]
        public void Die()
        {


        }

        [HttpPost]
        [Route("Restoere")]
        public void Restore()
        {


        }

        [HttpPost]
        [Route("Pay")]
        public void Pay()
        {


        }

        [HttpGet]
        [Route("GetCurrentPosition")]
        public String GetCurrentPosition()
        {
            return String.Empty;

        }
    }
}

