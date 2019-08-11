using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnipperFireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnipperFireGame.Tests
{
    [TestClass()]
    public class SpotTests
    {
        [TestMethod()]
        public void ButtonFire_ClickTest()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void LoadTest()
        {
            try {
                Spot obj = new Spot();
                obj.loadBullet();
                Assert.Fail();
            }
            catch (Exception ex) {
                    
            }
            
        }





    }
}