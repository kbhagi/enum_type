using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_type
{
    class Program
    {
        private static FileShare fileShare;

        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            DayOfWeek dayOfWeek = time.DayOfWeek;
            DayOfWeek tomorrow = dayOfWeek + 1;

            DayOfWeek sunday = DayOfWeek.Saturday + 1;

            dayOfWeek = DayOfWeek.Thursday;
            string sentences = "Sentence fragment. And another. ";
            string[] words = sentences.Split(new[] { ' ', '.' },
                StringSplitOptions.RemoveEmptyEntries);
            Console.Write(words);
            FileMode fileMode = FileMode.Truncate;
            //  FileShare fileShare = FileShare.Read+FileShare.Delete;
            bool hasRead = fileShare == FileShare.Read; 
            hasRead = fileShare.HasFlag(FileShare.Read);
        }
    }
}
