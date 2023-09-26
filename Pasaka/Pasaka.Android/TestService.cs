using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pasaka.Droid
{
    public class TestService : ITestService
    {
        public void TestMethod()
        {
            
        }
    }
    public interface ITestService
    {
        void TestMethod();
    }
}