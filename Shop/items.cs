namespace Shop
{
     class items
    {
        #region vars raw
        private static string[] productName;
        private static double[] price;
        private static double dTotal = 0;

        private static string strShopName;
        private static string CellNo;

        private static int counter = 0;

        private static int iSizeArray = 0;



        #endregion



        #region add to arrays
        public bool addToArray(string strProduct, double dblPrice)
        {
            if(counter<iSizeArray)
            {
                productName[counter] = strProduct;
                price[counter] = dblPrice;
                dTotal += dblPrice;
                counter++;
                return true;
            }
            else
            {
                return false;
            }
            

        }

        #endregion

        #region Get values
        public string getProduct(int x)
        {
            return productName[x];
        }
        public double getPrice(int x)
        {
            return price[x];
        }

        public int size()
        {
            return iSizeArray;
        }

        public double getTotal()
        {
            #region using loops to work out total
            /*
            Double dblTotal = 0;
            for (int i = 0; i < counterProducts; i++)
            {
                dblTotal += price[i];
            }
            // Foreach example
           
            foreach (double i in price)
            {
                dblTotal += i;
            }
            */
            #endregion

            return dTotal;
        }


        #endregion

        #region set Values 

        #region Set array size
        public void setArray(int num)
        {
            productName = new string[num];
            price = new double[num];
            iSizeArray = num;
        }
        #endregion
        public string getShopName()
        {
            return strShopName;
        }

        public void setShopName(string strName)
        {
            strShopName = strName;
        }

        public string getCellNumber()
        {
            return CellNo;
        }

        public void setCellNumber(string strCellNum)
        {
            CellNo = strCellNum;
        }



        public int getcounter()
        {
            return counter;
        }

        #endregion

    }
}