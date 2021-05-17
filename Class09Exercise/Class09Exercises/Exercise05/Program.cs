using Exercise05.Entities;
using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ne raboti, neznam zosto
            Trainer trainer = new Trainer();
            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();

            trainer.Events += sub1.Sms;
            trainer.Events += sub2.Email;
            trainer.Events += sub3.Fb;

            trainer.ComposeMessage("Kiki", 4, "Ruzno ko zmaj :)");
            Console.ReadLine();
        }
    }
}
