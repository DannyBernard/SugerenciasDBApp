using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using RegistroconAzure.Utilitarios;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Sugerencia sg = new Sugerencia();
           // sg.SugerenciaID = 1;
            sg.Descripcion = "bien";
            sg.Fecha = Utils.ToDateTime( DateTime.Now.ToString("yyyy-MM-dd"));
            RepositorioBase<Sugerencia> repositorioBase = new RepositorioBase<Sugerencia>();
            Assert.IsTrue(repositorioBase.Guardar(sg));
        }
    }
}