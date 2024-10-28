using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Services;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IUserRepository userRepo, IMapper mapper)
        {
            _authService = authService;
            _userRepo = userRepo;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserForLoginDto loginDto)
        {
            if (loginDto == null)
                return BadRequest("User data is null");

            if (!await _authService.CheckIcNumberExistAsync(loginDto.IcNumber))
                return BadRequest("IC Number not found or not registered");

            return Ok("Login successful");
        }


        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            if (userDto == null)
                return BadRequest("User data is null");

            if (await _authService.CheckEmailExistAsync(userDto.Email))
                return BadRequest("Email already registered");

            if (await _authService.CheckIcNumberExistAsync(userDto.IcNumber))
                return BadRequest("IC Number already registered");

            if (await _authService.CheckPhoneNumberExistAsync(userDto.PhoneNumber))
                return BadRequest("Phone number already registered");


            var user = _mapper.Map<User>(userDto);
            await _userRepo.AddAsync(user);

            return Ok("User registered successfully.");
        }
    }
}
