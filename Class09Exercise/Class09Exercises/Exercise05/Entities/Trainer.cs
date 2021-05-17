using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercise05.Entities
{
    public class Trainer
    {
        public delegate void Say(string str);
        public event Say Events;

        protected void SendMessage(string str)
        {
            if(Events != null)
            {
                Events(str);
            }
        }

        public void ComposeMessage(string trainerName, int groupNumber, string message)
        {
            Console.WriteLine("Proccessing data...");
            Thread.Sleep(3000);
            SendMessage($"{trainerName} informs G{groupNumber}: {message}");
        }
    }
}
