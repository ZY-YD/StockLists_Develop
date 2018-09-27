using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;
            StockNode current = this.head;
            while (current != null)
            {
                decimal currentHoldings = current.StockHolding.Holdings;
                decimal currentPrices = current.StockHolding.CurrentPrice;
                value += currentHoldings * currentPrices;
                current = current.Next;
            }
            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode currentOne = this.head;
            StockNode currentTwo = listToCompare.head;
            while (currentOne != null)
            {
                while (currentTwo != null)
                {
                    string currentName = currentOne.StockHolding.Name;
                    string compareName = currentTwo.StockHolding.Name;
                    if (currentName.CompareTo(compareName) == 0)
                        similarityIndex++;
                    currentTwo = currentTwo.Next;
                }
                currentTwo = listToCompare.head;
                currentOne = currentOne.Next;
            }
            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.StockHolding.ToString());
                current = current.Next;
            }
        }
    }
}