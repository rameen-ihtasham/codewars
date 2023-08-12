using System;
using System.Collections.Generic;

public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int totalIns = 0 ;
            int totalOuts = 0 ;
            foreach( int[]stop in peopleListInOut)
            {
               totalIns += stop[0];
               totalOuts += stop[1];
            }
            int remainingPeople = totalIns - totalOuts;
            return remainingPeople;
        }
    }