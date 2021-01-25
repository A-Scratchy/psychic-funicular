using System;

namespace RetailApp.Domain.Models
{

    public class ReceiptModel
    {

        private int _receiptNumber;

        private DateTime _dateOfPurchase;

        private int _customerNumber;

        private string _customerName;

        private AddressModel _address;

        private int _customerPhoneNumber;

        private int _itemNumber;

        private string _itemDescription;

        private decimal _unitPrice;

        private int _quantityPurchased;


        public ReceiptModel(
                    int receiptNumber,
                    DateTime dateOfPurchase,
                    int customerNumber,
                    string customerName,
                    AddressModel address,
                    int customerPhoneNumber,
                    int itemNumber,
                    string itemDescription,
                    decimal unitPrice,
                    int quantityPurchased
                )
        {
            this._quantityPurchased = quantityPurchased;
            this._dateOfPurchase = dateOfPurchase;
            this._customerNumber = customerNumber;
            this._customerName = customerName;
            this._address = address;
            this._customerPhoneNumber = customerPhoneNumber;
            this._itemNumber = itemNumber;
            this._itemDescription = itemDescription;
            this._unitPrice = unitPrice;
            this._quantityPurchased = quantityPurchased;
        }


        public int ReceiptNumber
        {
            get => _receiptNumber;
            set
            {
                if (value > 0) { _receiptNumber = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public DateTime DateOfPurchase
        {
            get => _dateOfPurchase;
            set => _dateOfPurchase = value;
        }

        public int CustomerNumber
        {
            get => _customerNumber;
            set
            {
                if (value > 0) { _customerNumber = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public string CustomerName
        {
            get => _customerName;
            set => _customerName = value;
        }

        public AddressModel Address
        {
            get => _address;
            set => _address = value;
        }

        public int CustomerPhoneNumber
        {
            get => _customerPhoneNumber;
            set => _customerPhoneNumber = value;
        }

        public int ItemNumber
        {
            get => _itemNumber;
            set
            {
                if (value > 0 && value < 9999) { _itemNumber = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public string ItemDescription
        {
            get => _itemDescription;
            set => _itemDescription = value;
        }

        public decimal UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (value > 0 && value < 9999) { _unitPrice = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public int QuantityPurchased
        {
            get => _quantityPurchased;
            set
            {
                if (value > 0) { _quantityPurchased = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }


        public decimal GetTotalCost()
        {
            return _unitPrice * _quantityPurchased;
        }

        public override string ToString()
        {
            return "Customer: " + _customerName + "\n"
                + "Phone:  " + _customerPhoneNumber + "\n"
                + "Total Purchases: " + GetTotalCost();
        }
    }
}
