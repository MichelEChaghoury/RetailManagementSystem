using Swashbuckle.Swagger;
using System.Collections.Generic;
using System.Web.Http.Description;

namespace RMSWebServices.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters is null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "Access Token",
                required = false,
                type = "string",
                @default = "Bearer "
            });
        }
    }
}