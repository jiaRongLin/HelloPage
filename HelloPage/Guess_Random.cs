using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace HelloPage
{
    public class Guess_Random
    {
        
        public static int ReturnMultipleValues()
        {
            Random random = new Random();
            int num = random.Next(0, 100);
            return num;
        }
    }

}
