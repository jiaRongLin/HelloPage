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
    /*public class LabChange
    {
        Guess g = new Guess();
        Guess_Random r = new Guess_Random();
        public int min;
        public int max;
        public int guess;
        public int num;
        public Tuple<int,int,int,int> ReturnGuess()
        {
            if (min < guess & guess < max)
            {
                if (num == guess)
                {
                    MessageBox.Show("Bingo!!!");
                }
                else if (num > guess)
                {
                    min = guess;
                    g.lab_guess.Text = "Too Small!!!";

                }
                else if (num < guess)
                {
                    max = guess;
                    g.lab_guess.Text = "Too Big!!!";
                }
                g.lab_num.Text = "Between " + min + " to" + max;
            }
            else
            {
                MessageBox.Show("請輸入 " + min + " ~ " + max + " 的數字");
            }
            var result = Tuple.Create<int,int,int,int>(min,max,num,guess);
            return result;
        }
    }*/

}
