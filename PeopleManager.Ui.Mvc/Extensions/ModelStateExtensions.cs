using Microsoft.AspNetCore.Mvc.ModelBinding;
using Vives.Services.Model;

namespace PeopleManager.Ui.Mvc.Extensions
{
    public static class ModelStateExtensions
    {
        public static void AddServiceErrors(this ModelStateDictionary modelState, ServiceResult serviceResult)
        {
            var errors = serviceResult
                .Messages
                .Where(m => m.Type == ServiceMessageType.Error)
                .ToList();
            foreach (var error in errors)
            {
                modelState.AddModelError("", error.Message);
            }
        }
    }
}
