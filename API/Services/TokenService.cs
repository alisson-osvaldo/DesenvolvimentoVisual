using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Models;
using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    public static class TokenService
    {
        public static string CriarToken(Usuario usuario)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(Settings.secret);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                //RefreshToken
                Expires = DateTime.UtcNow.AddHours(2), //aqui nosso tolken vai durar 2Hrs
                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(key),  //passar pelo tolken qual é nossa chave secreta
                    SecurityAlgorithms.HmacSha256Signature //qual é a forme de criptografar
                ),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email), //quem é o usuario  (atributo unico)
                    new Claim(ClaimTypes.Role, usuario.Permissao) //quem é o atributo que irá fazer o permissão
                })
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}