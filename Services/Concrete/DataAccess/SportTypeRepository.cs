using Microsoft.EntityFrameworkCore;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;
using play_360.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace play_360.Services.Concrete.DataAccess
{
    public class SportTypeRepository : ISportTypeRepository
    {
        private readonly Play360Context _context;
        public SportTypeRepository(Play360Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SportTypes>> GetAllSportTypes()
        {
            var allSportTypes = await _context.SportTypes.ToListAsync();
            return allSportTypes;
        }


        public async Task<List<SportTypeProfileDTO>> AddSportTypeProfile(List<SportTypeProfileDTO> sportTypeProfile)
        {
            try
            {
                foreach (var dto in sportTypeProfile)
                {
                    var userSports = await _context.UserSports
                        .Where(us => us.UserId == dto.UserId)
                        .ToListAsync();

                    var existingUserSport = userSports
                        .FirstOrDefault(us => us.SportTypeId == dto.SportTypeId);

                    if (existingUserSport != null)
                    {
                        existingUserSport.Position = dto.Position;
                        existingUserSport.DominantSideId = GetDominantSideId(dto.DominantSide);
                        _context.UserSports.Update(existingUserSport);
                    }
                    else
                    {
                        foreach (var oldSport in userSports)
                        {
                            _context.UserSports.Remove(oldSport);
                        }
                        var userSport = new UserSport
                        {
                            UserId = dto.UserId,
                            SportTypeId = dto.SportTypeId,
                            Position = dto.Position,
                            DominantSideId = GetDominantSideId(dto.DominantSide)
                        };
                        _context.UserSports.Add(userSport);
                    }
                }

                await _context.SaveChangesAsync();
                return sportTypeProfile;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<List<UserSportResponseDTO>> GetAllUserSport(int userId)
        {
            try
            {
                return await _context.UserSports
                    .Where(us => us.UserId == userId)
                    .Include(us => us.SportType)
                    .Select(us => new UserSportResponseDTO
                    {
                        SportTypeId = us.SportTypeId,
                        Position = us.Position,
                        DominantSideId = us.DominantSideId,
                    })
                    .ToListAsync();
            }
            catch (Exception )
            {
                return null;
            }
        }

        private int GetDominantSideId(string dominantSide)
        {
            return dominantSide switch
            {
                "Right" => 1,
                "Left" => 2,
                "Ambidextrous" => 3,
                _ => 1 // default to right
            };
        }
    }
}