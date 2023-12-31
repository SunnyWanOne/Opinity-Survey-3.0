using System.Collections.Generic;
using System.Threading.Tasks;
using Opinity.Survey.Models;

namespace Opinity.Survey.Services
{
    public interface ISurveyService
    {
        Task<List<Models.Survey>> GetSurveysAsync(int ModuleId);

        Task<Models.Survey> GetSurveyAsync(int ModuleId);

        Task<Models.Survey> AddSurveyAsync(Models.Survey Survey);

        Task<Models.Survey> UpdateSurveyAsync(Models.Survey Survey);

        Task DeleteSurveyAsync(int ModuleId);
    }
}
