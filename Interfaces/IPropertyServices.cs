using System.Collections.Generic;
using System.Threading.Tasks;
using EstateApp.Data.Entities;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace EstateApp.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
        IEnumerable<Property> GetAllProperties();
        Task AddProperty(Models.PropertyModel model);
    }
}