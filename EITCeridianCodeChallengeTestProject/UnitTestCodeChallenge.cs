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

        #region 5 Items

        [Test]
        public void TestWrongNames5()
        {
            _names = "Sonia Maria Wood Dempster abc,Laruen Ana Eagles Beneke def,Juan Manuel Trejo Espinoza,Carlos Alberto Enriquez Perez jkl,Jorge Luis Zambrano Manriquez mno";
            _order = "2,4,1,5,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestWrongOrderValue5()
        {
            _names = "Sonia Maria Wood Dempster abc,Laruen Ana Eagles Beneke def,Juan Manuel Trejo Espinoza ghi,Carlos Alberto Enriquez Perez jkl,Jorge Luis Zambrano Manriquez mno";
            _order = "2,A,1,5,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestMinorOrderValue5()
        {
            _names = "Sonia Maria Wood Dempster abc,Laruen Ana Eagles Beneke def,Juan Manuel Trejo Espinoza ghi,Carlos Alberto Enriquez Perez jkl,Jorge Luis Zambrano Manriquez mno";
            _order = "2,0,1,5,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestMajorOrderValue5()
        {
            _names = "Sonia Maria Wood Dempster abc,Laruen Ana Eagles Beneke def,Juan Manuel Trejo Espinoza ghi,Carlos Alberto Enriquez Perez jkl,Jorge Luis Zambrano Manriquez mno";
            _order = "2,6,1,5,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestReorderNames5()
        {
            _names = "Sonia Maria Wood Dempster abc,Laruen Ana Eagles Beneke def,Juan Manuel Trejo Espinoza ghi,Carlos Alberto Enriquez Perez jkl,Jorge Luis Zambrano Manriquez mno";
            _order = "2,4,1,5,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreNotEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        #endregion

        #region 3 Items

        [Test]
        public void TestWrongNames3()
        {
            _names = "Sonia Maria Wood,Laruen Ana Eagles,Juan Manuel Trejo,Carlos Enriquez,Jorge Luis Zambrano";
            _order = "2,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestWrongOrderValue3()
        {
            _names = "Sonia Maria Wood,Laruen Ana Eagles,Juan Manuel Trejo,Carlos Alberto Enriquez,Jorge Luis Zambrano";
            _order = "2,1,A";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestMinorOrderValue3()
        {
            _names = "Sonia Maria Wood,Laruen Ana Eagles,Juan Manuel Trejo,Carlos Alberto Enriquez,Jorge Luis Zambrano";
            _order = "2,1,0";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestMajorOrderValue3()
        {
            _names = "Sonia Maria Wood,Laruen Ana Eagles,Juan Manuel Trejo,Carlos Alberto Enriquez,Jorge Luis Zambrano";
            _order = "2,4,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        [Test]
        public void TestReorderNames3()
        {
            _names = "Sonia Maria Wood,Laruen Ana Eagles,Juan Manuel Trejo,Carlos Alberto Enriquez,Jorge Luis Zambrano";
            _order = "2,1,3";

            // Names parameter
            string[] names = _names.Split(',');

            // Order parameters
            string[] order = _order.Split(',');

            // Calling method ready for production
            Reorder reorder = new Reorder();
            string[] result = reorder.ReorderNames(names, order);

            Assert.AreNotEqual(result.Any(r => r.Contains("ERROR:")), true);
        }

        #endregion

    }
}
