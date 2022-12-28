using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPage
{
    internal class loan_cal
    {
    }
    public class Cal
    {
        public int totalmoney; //房屋總金額
        public int money;      //頭期款
        public int loan;       //貸款金額
        public int rate;       //房貸利率
        public int time;       //貸款期限(年)
        public int time_month; //貸款期限(月)
        public double rate_cal; //月利率
        public double rate_double;//(1+月利率)^月數
        public double rate_per; //本息平均攤還率
        public double per_month;//每月平均償還金額
        public double sum;      //總繳款金額
        public Tuple<int, int, double, double, double, double, double> ReturnMultipleValues()
        {
            loan = totalmoney - money;
            time_month = time * 12;
            rate_cal = rate * 0.01 / 12;
            rate_double = Math.Pow(1 + rate_cal, time_month);
            rate_per = (rate_double * rate_cal) / (rate_double - 1);
            per_month = loan * rate_per;
            sum = per_month * time_month;
            var result = Tuple.Create<int, int, double, double, double, double, double>
                (loan, time_month, rate_cal, rate_double, rate_per, per_month, sum);
            return result;
        }
    }
}
