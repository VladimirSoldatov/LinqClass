using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poem = { "All the world’s a stage,\r\n" +
                    "And all the men and women merely players;\r\n" +
                    "They have their exits and their entrances;\r\n" +
                    "And one man in his time plays many parts,\r\n" +
                    "His acts being seven ages. At first the infant,\r\n" +
                    "Mewling and puking in the nurse’s arms;\r\n" +
                    "And then the whining school-boy, with his satchel\r\n" +
                    "And shining morning face, creeping like snail\r\n" +
                    "Unwillingly to school. And then the lover,\r\n" +
                    "Sighing like furnace, with a woeful ballad\r\n" +
                    "Made to his mistress’ eyebrow. Then a soldier,\r\n" +
                    "Full of strange oaths, and bearded like the pard,\r\n" +
                    "Jealous in honour, sudden and quick in quarrel,\r\n" +
                    "Seeking the bubble reputation\r\n" +
                    "Even in the cannon’s mouth. And then the justice,\r\n" +
                    "In fair round belly with good capon lin’d,\r\n" +
                    "With eyes severe and beard of formal cut,\r\n" +
                    "Full of wise saws and modern instances;\r\n" +
                    "And so he plays his part. The sixth age shifts\r\n" +
                    "Into the lean and slipper’d pantaloon,\r\n" +
                    "With spectacles on nose and pouch on side;\r\n" +
                    "His youthful hose, well sav’d, a world too wide\r\n" +
                    "For his shrunk shank; and his big manly voice,\r\n" +
                    "Turning again toward childish treble, pipes\r\n" +
                    "And whistles in his sound. Last scene of all,\r\n" +
                    "That ends this strange eventful history,\r\n" +
                    "Is second childishness and mere oblivion;\r\n" +
                    "Sans teeth, sans eyes, sans taste, sans everything."};
            IEnumerable<string> query = from p in poem
                                        let words = p.Split(new string[] { " ", ";", ",", "\r\n", "." }, StringSplitOptions.RemoveEmptyEntries)
                                        from w in words
                                        where w.Count() > 5
                                        select w;

            Console.WriteLine("Word, in which more the 5 characters: ");
            foreach (string item in query)
            {

                Console.WriteLine($"{item}");
            }

        }
    }
}
