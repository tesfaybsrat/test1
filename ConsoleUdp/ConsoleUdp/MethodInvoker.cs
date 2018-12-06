using System;

namespace ConsoleUdp
{
    internal class MethodInvoker
    {
        private Action displayReceivedMessage;

        public MethodInvoker(Action displayReceivedMessage)
        {
            this.displayReceivedMessage = displayReceivedMessage;
        }
    }
}