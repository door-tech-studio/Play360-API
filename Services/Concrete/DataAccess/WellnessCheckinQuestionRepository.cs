using Microsoft.EntityFrameworkCore;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.ProjectModels;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.DataAccess
{
    public class WellnessCheckinQuestionRepository : IWellnessCheckinQuestionRepository
    {
        private readonly Play360Context _Play360Context;

        public WellnessCheckinQuestionRepository(Play360Context Play360Context)
        {
            _Play360Context = Play360Context;
        }
        public async Task<IList<WellnessMultipleChoiceQuestion>> GetMultipleChoiceQuestionsAndAnswers()
        {
            var getAllMultipleChoiceQuestions = await _Play360Context.WellnessMultipleChoiceQuestion
                .Include(question => question.WellnessMultipleChoiceAnswers)
                .ToListAsync();

            return getAllMultipleChoiceQuestions;
        }

        public async Task<IList<WellnessScaleQuestion>> GetScaleQuestionsAndAnswers()
        {
            var getScaleQuestions = await _Play360Context.WellnessScaleQuestion
                .Include(question => question.WellnessScaleQuestionAnswers)
                .ToListAsync();

            return getScaleQuestions;
        }

        public async Task<IList<WellnessBooleanQuestion>> GetBooleanQuestionsAndAnswers()
        {
            var getBooleanQuestions = await _Play360Context.WellnessBooleanQuestion
                .Include(question => question.WellnessBooleanQuestionAnswers)
                .ToListAsync();

            return getBooleanQuestions;
        }

        public async Task<int> AddWellnessCheckin(WellnessCheckin wellnessCheckin)
        {
            await _Play360Context.WellnessCheckin.AddAsync(wellnessCheckin);
            await _Play360Context.SaveChangesAsync();
            int insertedWellnessCheckinId = wellnessCheckin.Id;
            return insertedWellnessCheckinId;
        }

        public async Task AddMultipleChoiceCheckinResponses(IList<WellnessMultipleChoiceCheckinResponse> wellnessMultipleChoiceCheckinResponses)
        {
            await _Play360Context.WellnessMultipleChoiceCheckinResponse.AddRangeAsync(wellnessMultipleChoiceCheckinResponses);
        }

        public async Task AddScaleCheckinResponses(IList<WellnessScaleQuestionCheckinResponse> wellnessScaleCheckinResponses)
        {
            await _Play360Context.WellnessScaleQuestionCheckinResponse.AddRangeAsync(wellnessScaleCheckinResponses);
        }

        public async Task AddBooleanCheckinResponses(IList<WellnessBooleanQuestionCheckinResponse> wellnessBooleanCheckinResponses)
        {
            await _Play360Context.WellnessBooleanQuestionCheckinResponse.AddRangeAsync(wellnessBooleanCheckinResponses);
        }
    }
}
