using System;

namespace StringLib
{
    public class StringClass
    {
        public string GetWelcomeString(string name)
        {
            return $"{DateTime.Now} Hello, {name}";
        }
    }
}
