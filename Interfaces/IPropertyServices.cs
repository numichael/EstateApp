using System.Collections.Generic;
using System.Threading.Tasks;
using estate_app.Data.Entities;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace estate_app.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
        IEnumerable<Property> GetAllProperties();
        Task AddProperty(Models.PropertyModel model);
    }
}