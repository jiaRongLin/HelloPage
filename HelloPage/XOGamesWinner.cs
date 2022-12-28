using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPage
{
    internal class XOGamesWinner
    {
        public bool win;

        public bool Winner(string btn1, string btn2, string btn3,
                           string btn4, string btn5, string btn6,
                           string btn7, string btn8, string btn9)
        {
            string X = "X";
            string O = "O";
            bool win1 = btn1 == btn2 && btn2 == btn3 && (btn3 == X || btn3 == O);
            bool win2 = btn4 == btn5 && btn5 == btn6 && (btn6 == X || btn6 == O);
            bool win3 = btn7 == btn8 && btn8 == btn9 && (btn9 == X || btn9 == O);
            bool win4 = btn1 == btn4 && btn4 == btn7 && (btn7 == X || btn7 == O);
            bool win5 = btn2 == btn5 && btn5 == btn8 && (btn8 == X || btn8 == O);
            bool win6 = btn3 == btn6 && btn6 == btn9 && (btn9 == X || btn9 == O);
            bool win7 = btn1 == btn5 && btn5 == btn9 && (btn9 == X || btn9 == O);
            bool win8 = btn3 == btn5 && btn5 == btn7 && (btn7 == X || btn7 == O);
            if (win1 || win2 || win3 || win4 || win5 || win6 || win7 || win8)
            {
                win = true;
            }
            return win;
        }
    }
}
