using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PetTest;

[TestClass]
public class TestPetProxy
{
    [TestMethod]
    public void TestGetPet()
    {
        var json = PetProxy.GetPet(1).Result;

        // Extract the id from the JSON string
        string petId = json.Substring(json.IndexOf("id") + 4, 1);
        Assert.AreEqual("1", petId);
    }
}
