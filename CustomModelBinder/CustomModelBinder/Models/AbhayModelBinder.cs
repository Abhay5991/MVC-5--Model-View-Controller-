using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinder.Models
{
    public class AbhayModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var values = request.Headers.GetValues("AkaTech");

            return JsonConvert.DeserializeObject<Employee>(values.First());
            throw new NotImplementedException();
        }
    }
}