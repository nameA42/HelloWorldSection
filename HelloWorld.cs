using System;
using System.Collections.Generic;

namespace HelloWorldSection2
{
    public class HelloWorld
    {
        private int a = 0;

        public HelloWorld()
            {
            a = 1;
            }
        public static string helloWorlder(int numWorlds)
        {
            if (numWorlds <= 0)
            {
                throw new ArgumentOutOfRangeException("Hey Buddy, make it bigger than 0 ): You did this IDIOT" + numWorlds, "numWorlds");
            }
            string worldMsg = string.Empty;
            for (int i = 0; i < numWorlds; i++)
            {
                worldMsg += "World! ";
            }
            return worldMsg;
        }

    }
}
