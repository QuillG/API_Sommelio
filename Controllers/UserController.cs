using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sommelio.Data;
using Sommelio.Entities;
using Sommelio.DTO;
using Sommelio.Services;
using ZXing;
using ZXing.QrCode;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Azure.Core;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Sommelio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly LoginService _loginService;

        public UserController(DataContext context, LoginService loginService)
        {
            _context = context;
            _loginService = loginService;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("login")]
        public async Task<ActionResult> LoginUser([FromBody] UserLoginDto user)
        {
            try
            {
                // Recherche de l'utilisateur dans la base de données par son email via le service de login
                var userDto = await _loginService.LoginUserAsync(user);

                if (userDto == null)
                {
                    return Unauthorized("Invalid username or password");
                }

                //var accessTokenExpiresIn = TimeSpan.FromHours(1); // Définissez la durée de validité de l'access token
                //var refreshTokenExpiresIn = TimeSpan.FromDays(30); // Définissez la durée de validité du refresh token

                //var tokenHandler = new JwtSecurityTokenHandler();
                //var key = Encoding.ASCII.GetBytes("supersecret"); // Utilisez votre clé secrète

                //var tokenDescriptor = new SecurityTokenDescriptor
                //{
                //    Subject = new ClaimsIdentity(new Claim[]
                //    {
                //new Claim(ClaimTypes.NameIdentifier, userDto.Id.ToString()),
                //new Claim(ClaimTypes.Email, userDto.Email)
                //    }),
                //    Expires = DateTime.UtcNow.Add(accessTokenExpiresIn),
                //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                //};

                //var token = tokenHandler.CreateToken(tokenDescriptor);
                //var tokenString = tokenHandler.WriteToken(token);

                //var refreshToken = new RefreshToken
                //{
                //    Token = Guid.NewGuid().ToString(),
                //    ExpiryDate = DateTime.UtcNow.Add(refreshTokenExpiresIn),
                //    UserId = userDto.Id
                //};

                //_context.refreshTokens.Add(refreshToken);
                //await _context.SaveChangesAsync();

                return Ok(new
                {
                    user = userDto,
                    //accessToken = tokenString,
                    //refreshToken = refreshToken.Token,
                    //accessTokenExpiresIn = accessTokenExpiresIn.TotalSeconds,
                    //refreshTokenExpiresIn = refreshTokenExpiresIn.TotalSeconds
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("AddParticular")]
        public async Task<ActionResult<ParticularDto>> AddUserParticular(UserRegisterDto user)
        {
            var NewUser = await _loginService.RegisterParticularAsync(user);
            if (NewUser == null)
            {
                return BadRequest("User already exists");
            }
            return Ok(NewUser);
        }

        [HttpPost("AddProfessional")]
        public async Task<ActionResult<ProfessionalDto>> AddUserProfessional(ProfessionalDto user)
        {
            var NewUser = await _loginService.RegisterProfessionalAsync(user);
            if (NewUser == null)
            {
                return BadRequest("User already exists");
            }
            return Ok(NewUser);
        }
    }
}

    
