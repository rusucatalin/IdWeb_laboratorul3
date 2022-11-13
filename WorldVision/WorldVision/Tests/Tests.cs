using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldVision.BussinesLogic.LoginBL;
using WorldVision.Domain.Entities.User;

namespace WorldVision.Tests
{
    [TestFixture]
    public class Tests
    {
        GalerieBL galerieBl = new GalerieBL();

        [TestCase] //verifica daca se extrag date din baza de date
        public void Test1()
        {
            var result = galerieBl.GetGalerieData().FirstOrDefault();
            Assert.NotNull(result);
        }



        [TestCase]   //registrare
        public void Test2()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            URegisterData data = new URegisterData
            {
                Email = "email@mail.rui",
                Credential = "alahakbar",
                Password = "1234567890",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserRegister(data);
            Assert.True(userLogin.Status);
        }
        [TestCase]   //logarea
        public void Test3()
        {
            var bl = new BussinesLogic.BussinesLogic();
            var _session = bl.GetSessionBL();
            ULoginData data = new ULoginData
            {
                Credetial = "alahakbar",
                Password = "1234567890",
                LoginDataTime = DateTime.Now
            };

            var userLogin = _session.UserLogin(data);
            Assert.True(userLogin.Status);
        }
    }
}