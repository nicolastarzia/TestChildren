using System;
using System.Collections.Generic;
using System.Text;

namespace TestChildren.Domain.Interfaces
{
    public interface IRecipeService
    {
        List<Model.Recipe> GetAll(); 
    }
}
