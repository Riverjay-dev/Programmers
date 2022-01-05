using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public partial class Program
    {

        public void solution_12917()
        {
            List<string> lstSample = new List<string>();
            lstSample.Add(solution("abdZxAgEz"));
            foreach(string strSample in lstSample)
            {
                Console.WriteLine(strSample);
            }
            
        }

        private string solution(string s)
        {
            List<char> lstString = s.ToList<char>();
            lstString.Sort();
            lstString.Reverse();
            string answer = string.Join("" , lstString.ToArray());
            return answer;
        }

        //https://programmers.co.kr/learn/courses/30/lessons/12917
    }
}
