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

        private static int counterProducts = 0;
        private static int counterPrice = 0;

        private static int iSizeArray = 0;



        #endregion



        #region add to arrays
        public void setProduct(string strProduct)
        {
            productName[counterProducts] = strProduct;
            counterProducts++;
        }
        public void setPrice(double dblPrice)
        {
            price[counterPrice] = dblPrice;
            dTotal += dblPrice;
            counterPrice++;
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

        #endregion

    }
}