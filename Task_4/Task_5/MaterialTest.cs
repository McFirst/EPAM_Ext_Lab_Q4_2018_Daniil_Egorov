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
            int id = 1;
            string autor = "Autor1";
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();

            // Act
            Material testuser = mservise.Get(id);

            // Assert
            string actual = testuser.Autor;
            Assert.AreEqual(autor, actual, "Invalid result");
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
        public void TestMethod_Save_Material()
        {
            // Arrange
            Material mat3 = new Material(1, "Material3", "Autor3", "Type3", "03.03.2003", 2, "Tag3", "C:\\mat3");//todo pn на всякий случай скажу: абсолютный путь - зло
            MaterialService mservise = new MaterialService();
            mservise.LoadMaterials();
            bool expect = false;

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
            int id = 2;

            // Act
            bool actual = mservise.Delete(id);

            // Assert
            Assert.AreEqual(expect, actual, "Invalid result");
        }
    }
}