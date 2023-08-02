using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroTouchUnraveled
{
    /// <summary>
    ///The overall wrapping class. This is public to expose the methods below as nodes
    ///In Revit terms this would be the main object type you are messing with. Eg. Walls
    /// </summary>
    public class MyFirstClass
    {
        //we make this private, otherwise we get a blank node in Dynamo called `MyFirstClass`
        private MyFirstClass(){}

        /// <summary>
        /// This is your first node. It outputs a hello message
        /// </summary>
        /// <param name="username">The username to say hi to.</param>
        /// <returns name="helloMessage">Our constructed hello message.</returns>
        public static string MyFirstNode(string username)
        {
            string userMessage = $"Hello {username}, welcome to Dynamo.";

            return userMessage;
        }
    }
}
