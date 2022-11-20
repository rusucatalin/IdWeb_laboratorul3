using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WorldVision.BussinesLogic.LoginBL;
using WorldVision.Domain.Entities.User;
using System.Runtime.ExceptionServices;
using System.Reflection;

namespace WorldVision.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase] //verify if data was exyraget from DB
        public void Test1()
        {
            GalerieBL galerieBl = new GalerieBL();
            var result = galerieBl.GetGalerieData().FirstOrDefault();
            Assert.NotNull(result);
        }

        [TestCase]   //register
        public async Task Test2()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            URegisterData data = new URegisterData
            {
                Email = "Unaalta@getnada.com",
                Credential = "Administrator",
                Password = "qwerty1234",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserRegister(data);
            Assert.True(userLogin.Status);
        }

        [TestCase]   //login
        public void Test3()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            ULoginData data = new ULoginData
            {
                Credetial = "Administrator",
                Password = "qwerty1234",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserLogin(data);
            Assert.True(userLogin.Status);
        }
    }
}