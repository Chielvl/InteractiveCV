using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InteractiveCVLibrary
{
    public static class LoadFile
    {
        static public string[] LoadNewFile(string address)
        {
            string[] lines = null;
            try
            {
                address = Path.GetFullPath("TextItems/" + address);
                lines = System.IO.File.ReadAllLines(address);
                Debug.Assert(lines != null);
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"exception {ex}");
                
            }
            return lines;
        }
    }
}
