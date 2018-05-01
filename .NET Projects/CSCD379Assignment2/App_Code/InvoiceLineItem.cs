using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InvoiceLineItem
/// </summary>
/// 

namespace InvoiceLineItem.App_Code
{
    [Serializable]
    public class invoiceLineItem
    {

        private double ShippingRate = 5.55;
        private int CustomerNumber;

        private String Name;

        private String Street;
        private String City;
        private String State;

        private String ZIP;

        private String OrderNumber;
        private String InvoiceSequenceNumber;

        private String ItemSKU;

        private String ItemDescription;

        private int QuantityOrdered;

        private double UnitPrice;

        private double UnitWeight;

        private double ShippingCost;

        public invoiceLineItem(int cN, String n, String sT, String cT, String sTA, String zIP, String oN, String iSN, String iSKU, String iD, int qO, double uP, double uW)
        {
            CustomerNumber = cN;
            Name = n;
            Street = sT;
            City = cT;
            State = sTA;
            ZIP = zIP;
            OrderNumber = oN;
            InvoiceSequenceNumber = iSN;
            ItemSKU = iSKU;
            ItemDescription = iD;
            QuantityOrdered = qO;
            UnitPrice = uP;
            UnitWeight = uW;
            ShippingCost = setShippingCost();

        }
        private double setShippingCost()
        {
            double sC = this.QuantityOrdered * this.UnitWeight * ShippingRate;
            sC = Math.Round(sC, 2);
            return sC;

        }
        public int getCustomerNumber()
        {
            return CustomerNumber;
        }

        public String getName()
        {
            return Name;
        }
        public String getStreet()
        {
            return Street;
        }
        public String getCity()
        {
            return City;
        }
        public String getState()
        {
            return State;
        }
        public String getZIP()
        {
            return ZIP;
        }
        public String getInvoiceSequenceNumber()
        {
            return InvoiceSequenceNumber;
        }
        public String getItemSKU()
        {
            return ItemSKU;
        }
        public String getItemDescription()
        {
            return ItemDescription;
        }
        public int getQuantityOrdered()
        {
            return QuantityOrdered;
        }
        public double getUnitPrice()
        {
            return UnitPrice;
        }
        public double getUnitWeight()
        {
            return UnitWeight;
        }
        public double getShippingCost()
        {
            return ShippingCost;
        }
    }
}