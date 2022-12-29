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
        public int num;
        public Tuple<int> ReturnMultipleValues()
        {
            Random random = new Random();
            num = random.Next(0, 100);
            var result = Tuple.Create<int>(num);
            return result;
        }
    }

}
