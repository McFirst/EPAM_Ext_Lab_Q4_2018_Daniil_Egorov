﻿namespace Task_4.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task_4.Materials;

    public interface IMaterialService : IBaseRepository<Material>
    {
        bool LoadMaterials();
    }
}
