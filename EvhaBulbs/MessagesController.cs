using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EvhaBulbs
{
    [RoutePrefix("api/messages")]
    public class MessagesController: ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> PostMessage(MessageModel model)
        {
            if (model != null)
            {
                MessageRelay.GetInstance().RelayMessage(model);
                return Ok();
            }
            return InternalServerError();
        }
    }
}
