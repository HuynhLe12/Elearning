using Ardalis.ApiEndpoints;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Roles
{
    public class Create : BaseAsyncEndpoint
    {

        private readonly IRoleService _RoleService;
        public readonly RoleManager<Role> _roleManager;

        public Create(IRoleService RoleService, RoleManager<Role> roleManager)
        {
            _RoleService = RoleService;
            _roleManager = roleManager;
        }

        [HttpPost("/Role/Post")]
        [SwaggerOperation(
            Summary = "Creates a new Role",
            Description = "Creates a new Role",
            OperationId = "Role.Create",
            Tags = new[] { "RoleEndpoints" })
        ]
        public async Task<ActionResult<RoleResponse>> RoleHandleAsync(RoleRequest request, CancellationToken cancellationToken)
        {
            Role role = new Role();
            role.Name = request.Name;
            try
            {
                var userAdd = await _roleManager.CreateAsync(role);
            }
            catch (Exception e)
            {
                throw (e);
            }

            var createRole = new RoleResponse
            {
                Name = request.Name
            };
            return Ok(createRole);
        }
    }
}
