using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoConsole
{
    abstract class Utility
    {
        public static byte[] ByteArrayFromHexString(String source)
        {
            if (source.Length % 2 == 1)
            {
                source = "0" + source;
            }

            byte[] targetArray = new byte[source.Length / 2];

            for (var i = 0; i < targetArray.Length; i++)
            {
                targetArray[i] = Convert.ToByte(source.Substring(2 * i, 2), 16);
            }

            return targetArray;
        }

        public static String HexStringFromBinaryArray(byte[] source)
        {
            var output = new StringBuilder();
            foreach (var b in source)
            {
                output.Append(b.ToString("x"));
            }
            return output.ToString();
        }

        public static String ConvertBinaryArrayToBase64(byte[] source)
        {
            return Convert.ToBase64String(source);
        }
    }
}
