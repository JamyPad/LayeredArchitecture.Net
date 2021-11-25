using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entidades_POCO;
using Domain.Servicios;
using Aplicacion.Servicios;

namespace ATMTests
{

    [TestClass]
    public class ATMDomainTests
    {
        [TestMethod]
        public void RetiroConMontoDe6000()
        {
            var dominio = new ATMAppService();
            var cuenta = new Cuenta {  CuentaId="30001" };

            decimal valor = 6000;
            var RetiroCompletado = dominio.RealizarRetiro(cuenta,valor);
            Assert.AreEqual(true, RetiroCompletado);
        }
    } 



}


