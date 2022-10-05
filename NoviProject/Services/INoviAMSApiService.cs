using NoviProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NoviProject.Services
{
    public interface INoviAMSApiService
    {
        Task<List<Member>> GetMembers();
        Task<SingleMember> GetSingleMember(string? id);
    }
}
