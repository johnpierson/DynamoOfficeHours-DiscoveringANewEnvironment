using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewNodes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class MyStringClass
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        private MyStringClass() { }
        /// <summary>
        /// This is my first node
        /// </summary>
        /// <param name="userName">Input your username</param>
        /// <returns name="userMessage">My cool new message</returns>
        public static string MyFirstNode(string userName)
        {
            var userDomain = Environment.UserDomainName;
            string userMessage = $"Hello, how are you doing today {userName}, {userDomain}? {DateTime.Today}";

            return userMessage.ToLower();
        }
    }
}
