﻿using Radzen;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Opinity.Survey.Services
{
    public interface ISurveyAnswersService
    {
        Task<List<Models.SurveyItem>> SurveyResultsDataAsync(int ModuleId, int SelectedSurveyId, LoadDataArgs args);
        Task CreateSurveyAnswersAsync(Models.Survey Survey);
    }
}