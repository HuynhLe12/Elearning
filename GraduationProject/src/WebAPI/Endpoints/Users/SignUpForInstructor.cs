using Ardalis.ApiEndpoints;
using Ardalis.Result;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.ApiModels;

namespace WebAPI.Endpoints.Users
{
    public class SignUpForInstructor : BaseAsyncEndpoint<SignUpForInstructorRequest, UserResponse>
    {
        public readonly IUserServices _userServices;
        private readonly UserManager<User> _userManager;
        public SignUpForInstructor(IUserServices userServices, UserManager<User> userManager)
        {
            this._userServices = userServices;
            this._userManager = userManager;
        }
        [HttpPost("/Users/SignUpForInstructor")]
        [SwaggerOperation(
            Summary = "Sign Up Your New Account",
            Description = "Sign Up A New User",
            OperationId = "User.SignUpForInstructor",
            Tags = new[] { "UserEndpoints" })
         ]
        public override async Task<ActionResult<UserResponse>> HandleAsync([FromBody] SignUpForInstructorRequest request, CancellationToken cancellationToken = default)
        {
            if (_userServices.IsUserNameExisted(request.UserName) == true)
            {
                HttpContext.Response.StatusCode = 302;
                return Ok("UserName is Already existed");
            }

            if (_userServices.IsEmailExisted(request.Email) == true)
            {
                HttpContext.Response.StatusCode = 302;
                return Ok("Email is Already existed");
            }

            var user = new User
            {
                UserName = request.UserName,
                RoleId = _userServices.GetRoleIdByRoleName("string"),
                Email = request.Email,
                NormalizedUserName = request.UserName,
                SecurityStamp = "string",
                NormalizedEmail = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PasswordHash = request.Password,
                CreateAt = DateTime.Now,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                Status = false,
                IsDeleted = false,
                IsStatus = true,

            };



            PasswordHasher<User> passHasher = new PasswordHasher<User>();
            user.PasswordHash = passHasher.HashPassword(user, user.PasswordHash);

            try
            {
                var userAdd = await _userServices.AddUser(user);
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
                FirstName = request.FirstName,
                LastName = request.LastName,

            };
            return Ok(createUser);
        }
    }
}
