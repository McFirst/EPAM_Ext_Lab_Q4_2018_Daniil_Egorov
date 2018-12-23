namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task_4.Materials;

    [TestClass]
    public class MaterialTest
    {

        [TestMethod]
        public void TestMethod_Get_Material()
        {
            // Arrange
            int ID = 1;
            string Autor = "Autor1";
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();

            // Act
            Material testuser = mservise.Get(ID);

            // Assert
            string actual = testuser.Autor;
            Assert.AreEqual(Autor, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_GetAll_Material()
        {
            // Arrange
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();
            int expect = 2;

            // Act
            List<Material> testList = mservise.GetAll();

            // Assert
            int actual = testList.Count;
            Assert.AreEqual(expect, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_Save_Materiarl()
        {
            // Arrange
            Material mat3 = new Material(3, "Material3", "Autor3", "Type3", "03.03.2003", 2, "Tag3", "C:\\mat3");
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();
            bool expect = true;

            // Act
            bool actual = mservise.Save(mat3);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }

        [TestMethod]
        public void TestMethod_Delete_Material()
        {
            // Arrange
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();
            bool expect = true;
            int ID = 1;

            // Act
            bool actual = mservise.Delete(ID);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }
    }
}