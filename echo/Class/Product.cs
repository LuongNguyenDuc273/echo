using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace echo.Class
{
    public class Product
    {
        string prid, prname, prdescribe, imglocation, prtype;
        int prprice;

        public string prId
        {
            get { return prid; }
            set { prid = value; }
        }

        public string prName
        {
            get { return prname; }
            set {  prname = value; }
        }

        public int prPrice
        {
            get { return prprice; }
            set { prprice = value; }
        }

        public string prDescribe
        {
            get { return prdescribe; }
            set { prdescribe = value; }
        }

        public string imgLocation
        {
            get { return imglocation; }
            set { imglocation = value; }
        }

        public string prType
        {
            get { return prtype; }
            set { prtype = value; }
        }
    }
}