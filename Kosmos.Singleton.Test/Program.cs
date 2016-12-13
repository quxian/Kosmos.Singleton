using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kosmos.Singleton.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                SingleHttpClient.PostException(new { test = "yongsheng", date = DateTime.Now });
            }
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }
    }
}
