using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvhaBulbs
{
    public class MessageRelay
    {
        public delegate void RelayHandler(MessageModel message);
        public event RelayHandler RelayIncoming;

        private static MessageRelay _instance;

        private MessageRelay() { }

        public static MessageRelay GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MessageRelay();
            }
            return _instance;
        }

        public void RelayMessage(MessageModel message)
        {
            if (RelayIncoming != null)
            {
                RelayIncoming(message);
            }
        }
    }
}
