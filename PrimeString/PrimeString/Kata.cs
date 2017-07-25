using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeString
{
    public class Kata
    {
        public bool PrimeString(string source)
        {
            //如果是單數，就是prime string (X)
            //如果只有一個字，就是prime string
            if (source.Length == 1)
            {
                return true;
            }

            //把整體切一半，如果有重覆就不是prime string (X)
            //每次把整體切一半，然後把重覆的取代掉 (X)
            //先取第一個字，然後取到重覆第一個字的位置並取代掉 (X)
            //整體切一半，然後組出一個重覆的pattern，並取代掉原本的source
            for (int i = 0; i < source.Length/2; i++)
            {
                var pattern = source.Substring(0, i + 1);
                if (source.Replace(pattern, "") == "")
                {
                    return false;
                }
            }

            return true;
        }
    }
}