using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ree = new System.Media.SoundPlayer();
            ree.Stream = CSharp2.Properties.Resources.REE;
            var win = new System.Media.SoundPlayer();
            win.Stream = CSharp2.Properties.Resources.win;
            var oof = new SoundPlayer();
            oof.Stream = Properties.Resources.hot;
            var meow = new SoundPlayer();
            meow.Stream = CSharp2.Properties.Resources.meow;
            var sad = new System.Media.SoundPlayer();
            sad.Stream = Properties.Resources.sad;







            Console.WriteLine("Answer Correctly, Is Taxation theft?: ");
            Console.Write("Yes or No?: ");
            string Answer = Console.ReadLine();

            string message = "";

            if (string.Equals(Answer, "Yes", StringComparison.CurrentCultureIgnoreCase))
            {
                message = "Congratulations, " + System.Environment.MachineName + ", You will not be murdered in your sleep tonight! ";
                Console.Write(message);
                win.Play();
            }
            else if (string.Equals(Answer, "No", StringComparison.CurrentCultureIgnoreCase))
            {
                message = "I'm sorry, " + System.Environment.MachineName + ", You have answered incorrectly, and are no longer worthy of living. Prepare for your punishment. ";
                Console.Write(message);
                oof.PlaySync();
            }
            else if (string.Equals(Answer, "Meow", StringComparison.CurrentCultureIgnoreCase))
            {
                message = "Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow Meow ";
                Console.Write(message);
                meow.Play();
            }
            else if (string.Equals(Answer, "Sad", StringComparison.CurrentCultureIgnoreCase))
            {
                message = "\"It do be like that, especially when I do it like bees\" - Macaroni Boy from the internet. ";
                Console.Write(message);
                sad.PlaySync();
            }
            else
            {
                message = "I said to answer correctly!";
                Console.WriteLine(message);
                ree.PlayLooping();
            }











            Console.ReadLine();
        }
    }
}
