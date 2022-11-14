using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetproject.Dtos.Character;     
using dotnetproject.Models;

namespace dotnet_project.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}