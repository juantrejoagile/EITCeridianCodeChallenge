using EITCeridianCodeChallengeJMTE;

namespace EITCeridianCodeChallengeTestProject
{

    public class Tests
    {
        private string _names;
        private string _order;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWrongNames()
        {
            _names = "Sonia Wood Dempster,Laruen Ana Eagles,Juan Manuel Trejo Espinoza";
            _order = "2,4,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Contains("Uncompleted words for this name."), true);
        }

        [Test]
        public void TestWrongOrder()
        {
            _names = "Sonia Maria Wood Dempster,Laruen Ana Eagles Beneke,Juan Manuel Trejo Espinoza";
            _order = "5,2,4,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Contains("The number of order values is not valid."), true);
        }

        [Test]
        public void TestWrongOrderValue()
        {
            _names = "Sonia Maria Wood Dempster,Laruen Ana Eagles Beneke,Juan Manuel Trejo Espinoza";
            _order = "5,4,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Contains("A order value is not valid."), true);
        }

        [Test]
        public void TestReorderNames()
        {
            _names = "Sonia Maria Wood Dempster,Laruen Ana Eagles Beneke,Juan Manuel Trejo Espinoza";
            _order = "2,4,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreNotEqual(result.Contains("Uncompleted words for this name."), true);
            Assert.AreNotEqual(result.Contains("The number of order values is not valid."), true);
            Assert.AreNotEqual(result.Contains("A order value is not valid."), true);
            Assert.AreEqual(names.Length, result.Length);
        }

    }
}
