# RestfulAPI used to calculate reward point for each invoices for each customer monthly and total based on purchases. This is Web API having one web action method to be invoke.
To test API kindly follow below mentioned instruction.

1. Download project zip file.
2. Open in VS 2019 or above.
3. Web API build on Dot Net Core 3.1 version.
4. Build Web API and Run.
5. Web API will redirect to Swagger UI and list down all Controller (In this only one Home Controller) with Action Method.

        [HttpPost]
        [Route("GetCustomerRewardPoints")]
        public IActionResult GetCustomerRewardPoints([FromBody] CustomerPurchaseList customerPurchaseList)
        
6. Use below mentioned schema for request body

{
  "customerPurchases": [
    {
      "customerCode": "string",
      "customerDesc": "string",
      "invoiceDate": "2022-07-10T15:22:38.547Z",
      "invoiceNo": "string",
      "productName": "string",
      "productQty": 0,
      "productSalePrice": 0,
      "productSaleDiscount": 0,
      "productTotalAmount": 0,
      "invoiceTotal": 0
    }
  ]
}


7. Once Execute response will be return in below format.

[
  {
    "customerCode": "string",
    "customerDesc": "",
    "invoiceMonth": 0,
    "invoiceYear": 0,
    "rewardPointTotal": 0,
    "rewardPointMonthlyTotal": [
      {
        "invoiceMonth": 7,
        "totalRewardPoints": 0
      }
    ],
    "invoiceList": [
      {
        "invoiceDate": "2022-07-10T15:24:46.629Z",
        "invoiceNo": "",
        "invoiceTotal": 0,
        "invoiceRewardTotal": 0,
        "invoiceMonth": 7
      }
    ]
  }
]

Thank you

For reference Demo JsonData.json file attached with Project and can be used to test.

Happy Coding.


