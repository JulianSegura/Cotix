using Cotix.AppLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.Infrastructure
{
    public class Encoder: IEncode
    {
        public string HashString(string text)
        {
            byte[] textToEncodeBytes = ASCIIEncoding.ASCII.GetBytes(text);
            textToEncodeBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(textToEncodeBytes);
            string encodedPass = Encoding.ASCII.GetString(textToEncodeBytes);

            return encodedPass;
        }
    }
}
