using System;
using System.Collections.Generic;
using System.Text;

namespace RandomItemsGenerator
{
    public static class RandomTestletItemsComponent
    {
        static List<string> pretestResults = new List<string>();
        static List<string> pretesAndOperationalResults = new List<string>();
        static List<string> remainingPretest = new List<string>();


        public static List<string> SelectTwoRandomPretestItems(List<string> myPretest)
        {
            Random myRandomPretestItems = new Random();
            for(int i = 0; i < 2; i ++)
            {
                int index = myRandomPretestItems.Next(myPretest.Count);
                pretestResults.Add(myPretest[index].ToString());
                myPretest.RemoveAt(index);
            }
            remainingPretest = myPretest;
            return pretestResults;
        }

        public static List<string> SelectRandomEightItems(List<string> myPretestandoperational)
        {
            Random myRandomPretestandOperationalItems = new Random();
            foreach(string remain in remainingPretest)
            {
                //Add the remaining 2 pretest to 6 operational to make 8 total items
                myPretestandoperational.Add(remain);
            }
            for (int i = 0; i < 8; i++)
            {
                int index = myRandomPretestandOperationalItems.Next(myPretestandoperational.Count);
                pretesAndOperationalResults.Add(myPretestandoperational[index].ToString());
                //remove strings already added
                myPretestandoperational.RemoveAt(index); 
            }
            return pretesAndOperationalResults;
        }
    }
}
