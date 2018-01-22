    using System;
    using System.Collections.Generic;
    namespace SpecialBinaryString
    {


       
        public class Solution
        {



      
            public string MakeLargestSpecial(string S)
            {

             List<int[]> found = new List<int[]>();

                CheckIfIsSpecial(S, 0, S.Length, found);

            foreach(var f in found)
            {
                Console.WriteLine(String.Format("{0}{1}", f[0]),f[1]);
                
            }

            return "";
            }




            public void CheckIfIsSpecial(string s, int from, int to, List<int[]> found)
            {
            if (to == from)
                return;
          
            int index = from;
            int ones = 0;
            int zeroes = 0;
          
         

            while( index < to)
            {
                if (s[index] == '1')
                {
                    ones++;
                
                }
                if (s[index] == '0')
                {
                    zeroes++;
                }
                index++;
                if( index == to || (s[index -1] == '0' && s[index]=='1')|| (zeroes == ones))
                {

                    if (zeroes == ones && zeroes >=1)
                        found.Add(new int[] { from, index-1 });
                    else
                        CheckIfIsSpecial(s, from + 1, index, found);
                    zeroes = ones = 0;
                }
            }

            return;

            }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
            Solution sl = new Solution();
            string s =sl.MakeLargestSpecial("11011000");
            }
        }
    }
