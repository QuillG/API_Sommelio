using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sommelio.Services
{
    public class LoginService
    {
        private readonly DataContext _context;

        public LoginService(DataContext context)
        {
            _context = context;
        }

        public async Task<UserDto> LoginUserAsync(UserLoginDto User)
        {
            if (User == null)
            {
                throw new ArgumentNullException(nameof(User));
            }

            // Recherche de l'utilisateur dans la base de données par son email
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == User.Email);

            if (user == null)
            {
                // L'utilisateur n'existe pas
                return null;
            }

            // Vérification du mot de passe en utilisant la fonction de hachage SHA512
            var hashedPassword = Sha512(User.Password);
            if (user.Password != hashedPassword)
            {
                // Le mot de passe est incorrect
                return null;
            }

            // L'utilisateur est authentifié, creation d'un DTO utilisateur à partir de l'entité utilisateur
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                ProfilePictureUrl = user.ProfilePictureUrl,
                FidelityPoints = user.FidelityPoints,
                inscriptionDate = user.InscriptionDate.ToString("dd/MM/yyyy"),
                FidelityGrade = _context.FidelityRanks.FirstOrDefault(f => f.Id == user.FidelityGradeId).Name,
                UserType = _context.UserTypes.FirstOrDefault(u => u.Id == user.UserTypeId).Name,
                QRCode = null,
      
            };
        }

        public async Task<UserDto> RegisterUser(UserRegisterDto User)
        {
            if (User == null)
            {
                throw new ArgumentNullException(nameof(User));
            }

            // Vérification si l'utilisateur existe déjà dans la base de données
            var userExists = await _context.Users.AnyAsync(u => u.Email == User.Email);

            if (userExists)
            {
                // L'utilisateur existe déjà
                return null;
            }

            //Verifier línjection de code
            if (User.Name.Contains("<") || User.Name.Contains(">") || User.Surname.Contains("<") || User.Surname.Contains(">") || User.Email.Contains("<") || User.Email.Contains(">") || User.Password.Contains("<") || User.Password.Contains(">"))
            {
                return null;
            }

            // vérification du mot de passe si il contient au moins 8 caractères et un chiffre et une lettre majuscule et minuscule et un caractère spécial

            if (!System.Text.RegularExpressions.Regex.IsMatch(User.Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$"))
            {
                return null;
            }

            // Création d'une nouvelle entité utilisateur à partir du DTO
            var userEntity = new User
            {
                Name = User.Name,
                Surname = User.Surname,
                Email = User.Email,
                Password = Sha512(User.Password),
                ProfilePictureUrl = null,
                UserType = _context.UserTypes.FirstOrDefault(u => u.Name == User.UserType),
                FidelityPoints = 0,
                FidelityGradeId = 1,
                QRCode = null,
                InscriptionDate = DateTime.Now
            };

            // Ajouter l'utilisateur à votre contexte de base de données
            _context.Users.Add(userEntity);

            // Enregistrer les modifications dans la base de données
            await _context.SaveChangesAsync();

            // Retourner une réponse Ok avec l'entité utilisateur ajoutée
            var user = new UserDto
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Surname = userEntity.Surname,
                Email = userEntity.Email,
                UserType = userEntity.UserType.Name,
                ProfilePictureUrl = userEntity.ProfilePictureUrl,
                FidelityPoints = userEntity.FidelityPoints,
                FidelityGrade = _context.FidelityRanks.FirstOrDefault(f => f.Id == 1).Name,
                QRCode = null
            };

            return user;
            
        }

        public string Sha512(string input)
        {
            using (SHA512 shaM = new SHA512Managed())
            {
                byte[] hashBytes = shaM.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        //Genrate token
        public string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
