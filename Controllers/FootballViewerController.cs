using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GitHub;
using GitHub.Repository;

namespace footaball.Controllers
{
    [ApiController]
    [Route("/viewer")]
    public class ViewerController : ControllerBase
    {
        [HttpPut]
        public Viewer Create(Viewer viewer)
        {
            Storage.ViewerStorage.Create(viewer);
            return viewer;
        }

        [HttpGet]
        public Viewer Read(int viewerID)
        {
            return Storage.ViewerStorage.Read(viewerID);
        }

        [HttpPatch]
        public Viewer Update(int viewerID, Viewer newViewer)
        {
            return Storage.ViewerStorage.Update(viewerID, newViewer);
        }

        [HttpDelete]
        public bool Delete(int viewerID)
        {
            return Storage.ViewerStorage.Delete(viewerID);
        }

        [HttpGet("WatchingTheMach")]
        public string WatchingTheMach(string str)
        {
            return str; // Метод просмотра матча
        }
        [HttpGet("ChoosingTheWorstAndTheBestPlayer")]
        public string ChoosingTheWorstAndTheBestPlayer(string str)
        {
            return str; // Метод выбора худшего и лучшего игрока
        }
        [HttpGet("PayTheTicket")]
        public string PayTheTicket(string str)
        {
            return str; // Метод покупки билета
        }
    }
}
