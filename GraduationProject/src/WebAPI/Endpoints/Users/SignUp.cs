using Ardalis.ApiEndpoints;
using Ardalis.Result;
using Core.Entities;
using Core.Interfaces;
using Web.Endpoints.ToDoItems;
using WebAPI.ApiModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Users
{
    public class SignUp : BaseAsyncEndpoint<SignUpRequest, UserResponse>
    {
        public readonly IUserServices _userServices;
        public readonly UserManager<User> _userManager;
        public readonly RoleManager<Role> _roleManager;
        public SignUp(IUserServices userServices, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            this._userServices = userServices;
            this._userManager = userManager;
            this._roleManager = roleManager;
        }
        [HttpPost("/Users/SignUp")]
        [SwaggerOperation(
            Summary = "Sign Up Your New Account",
            Description = "Sign Up A New User",
            OperationId = "User.SignUp",
            Tags = new[] { "UserEndpoints" })
         ]
        public override async Task<ActionResult<UserResponse>> HandleAsync([FromBody] SignUpRequest request, CancellationToken cancellationToken = default)
        {
            //if (_userServices.IsUserNameExisted(request.UserName) == true)
            //{
            //    return BadRequest("UserName is Already existed");
            //}

            //if (_userServices.IsEmailExisted(request.Email) == true)
            //{
            //    return BadRequest("Email is Already existed");
            //}
            var role = _roleManager.FindByIdAsync("50559e17-8dcd-4848-79aa-08da9e12f4f5").Result;
            var user = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Status = false,
                IsDeleted = false,
                IsStatus = true,
                RoleId = role.Id,
            };

            try
            {
                var userAdd = await _userManager.CreateAsync(user, request.Password);
                if (userAdd.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role.Name);
                }
            }
            catch (Exception e)
            {
                return Result<ActionResult<UserResponse>>.Error(new[] { e.Message });

            }

            var createUser = new UserResponse
            {
                Id = _userServices.GetUserIdJustAdded(request.UserName),
                UserName = request.UserName,
                Email = request.Email,
                FirstName = request.UserName,
                LastName = request.LastName,

            };
            return Ok(createUser);
        }
    }
}
