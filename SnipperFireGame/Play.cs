using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipperFireGame
{
    public class Play
    {
        Random random_Object = new Random();
        // this method is used to generate a random no that is used to find the winner or looser
        public int genNo()
        {
            Random Object = new Random();
            int uniqNo = Object.Next(1, 3);
            return uniqNo;
        }
    }
}
