============================
        Product
----------------------------
 - string _name
 - string _productID
 - float _price
 - int _quantity
----------------------------
 + ComputePrice()
============================
============================
        Customer
----------------------------
 - string _name
 - Class _address
----------------------------
 + InUSA()
 + GetAddress()
============================
============================
        Address
----------------------------
 - string _street
 - string _city
 - string _state
 - string _country
----------------------------
 + InUSA()
 + CreateShippingString()
 + GetAddress()
============================
============================
	   Order
----------------------------
 - string _customer
 - List<Poducts> _products
 - float _totalPrice
 - float _subTotal
 - float _shippingFee

----------------------------
 + DisplayPackingLable
 + DisplayShippingLable
============================
