using System;
using System.Collections.Generic;
using System.Text;

namespace TestChildren.Domain.Interfaces
{
    public interface IRecipeRepository
    {
        List<Model.Recipe> GetAll();
    }
}
