using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {

        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            StockList resultList = new StockList();
            StockNode currentOne = this.head;
            StockNode currentTwo = listToMerge.head;
            while (currentOne != null)
            {
                //resultList.AddStock(currentOne.StockHolding);  //A bug in mergeList()
                while (currentTwo != null)
                {
                    resultList.AddStock(currentTwo.StockHolding);
                    currentTwo = currentTwo.Next;
                }
                resultList.AddStock(currentOne.StockHolding);
                currentOne = currentOne.Next;
            }
            return resultList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = null;
            StockNode current = this.head;
            StockNode most = this.head;
            while(current != null)
            {
                decimal currentHoldings = current.StockHolding.Holdings;
                decimal mostHoldings = most.StockHolding.Holdings;
                if (currentHoldings > mostHoldings)
                    most = current;
                current = current.Next;
            }
            mostShareStock = most.StockHolding;
            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;
            StockNode current = this.head;
            while(current != null)
            {
                current = current.Next;
                length++;
            }
            return length;
        }
    }
}