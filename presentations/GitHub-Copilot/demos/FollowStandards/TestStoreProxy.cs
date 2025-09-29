using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserTest;

[TestClass]
public class TestStoreProxy
{
    [TestMethod]
    public void TestGetOrder()
    {
        var json = StoreProxy.GetOrder(2).Result;

        // Extract the id from the JSON string
        string orderId = json.Substring(json.IndexOf("id") + 4, 1);
        Assert.AreEqual("2", orderId);
    }

    [TestMethod]
    public void TestGetOrderNegativeId()
    {
        string expectedErrorMessage = "Negative values are not allowed";
        Assert.ThrowsExceptionAsync<ArgumentException>(async () => await StoreProxy.GetOrder(-1), expectedErrorMessage);
    }
}