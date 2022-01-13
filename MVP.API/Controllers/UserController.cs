using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVP.Core.DTOs;
using MVP.Core.Entities;
using MVP.Core.Exceptions;
using MVP.Core.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MVP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        /// <summary>
        /// User Controller
        /// </summary>
        /// <param name="userServices"></param>
        /// <param name="mapper"></param>
        public UserController(IUserServices userServices, IMapper mapper)
        {
            _userServices = userServices;
            _mapper = mapper;
        }
        /// <summary>
        /// Retrive the all active users
        /// </summary>
        /// <returns>users</returns>
        [HttpGet("GetAllActiveUsers")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<UserDto>))]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status400BadRequest)]
        [ProducesErrorResponseType(typeof(void))]
        [Produces(MediaTypeNames.Application.Json, "application/problem+json")]
        public async Task<IActionResult> GetAllActiveUsers()
        {
            var users = await _userServices.GetAllActiveUsers();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(userDto);
        }
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status400BadRequest)]
        [ProducesErrorResponseType(typeof(void))]
        [Produces(MediaTypeNames.Application.Json, "application/problem+json")]
        public async Task<IActionResult> AddUser(UserDto newUser)
        {
            var user = _mapper.Map<User>(newUser);
            var result = await _userServices.AddUser(user);
            return Ok(result);
        }

        /// <summary>
        /// Update specific user
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpPut("UpdateActiveUser")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status400BadRequest)]
        [ProducesErrorResponseType(typeof(void))]
        [Produces(MediaTypeNames.Application.Json, "application/problem+json")]
        public async Task<IActionResult> UpdateActiveUser(int idUser)
        {
            var userUpdate = await _userServices.UpdateUser(idUser);
            return Ok(userUpdate);
        }

        /// <summary>
        /// Delet specific user
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpDelete("DeleteUser")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(bool))]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ErrorDetailModel), StatusCodes.Status400BadRequest)]
        [ProducesErrorResponseType(typeof(void))]
        [Produces(MediaTypeNames.Application.Json, "application/problem+json")]
        public async Task<IActionResult> DeleteUser(int idUser)
        {
            var result = await _userServices.DeleteUser(idUser);
            return Ok(result);
        }
    }
}