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
        public async Task<IList<WellnessMultipleChoiceQuestionsAndAnswers>> GetMultipleChoiceQuestionsAndAnswers()
        {
            var allMultipleChoiceQuestionsAndAnswers = new List<WellnessMultipleChoiceQuestionsAndAnswers>();

            var getAllMultipleChoiceQuestions = await _Play360Context.WellnessMultipleChoiceQuestion.ToListAsync();
            var getAllMultipleChoiceAnswers =  await _Play360Context.WellnessMultipleChoiceAnswer.ToListAsync();

            foreach (var question in getAllMultipleChoiceQuestions)
            {
                var questionId = question.Id;
                var wellnessMultipleChoiceQuestionAndAnswers = new WellnessMultipleChoiceQuestionsAndAnswers();
                wellnessMultipleChoiceQuestionAndAnswers.MultipleChoiceQuestion = question;

                foreach (var answer in getAllMultipleChoiceAnswers)
                {
                    var wellnessMultipleChoiceQuestionId = answer.WellnessMultipleChoiceQuestionId;

                    if (questionId == wellnessMultipleChoiceQuestionId)
                    {
                        wellnessMultipleChoiceQuestionAndAnswers.WellnessMultipleChoiceAnswers.Add(answer);
                    }
                }
            }

            return allMultipleChoiceQuestionsAndAnswers;
        }

        public async Task<IList<WellnessScaleQuestionsAndAnswers>> GetScaleQuestionsAndAnswers()
        {
            var allScaleQuestionsAndAnswers = new List<WellnessScaleQuestionsAndAnswers>();

            var getScaleQuestions = await _Play360Context.WellnessScaleQuestion.ToListAsync();
            var getScaleQuestionAnswers = await _Play360Context.WellnessScaleQuestionAnswer.ToListAsync();

            foreach (var question in getScaleQuestions)
            {
                var questionId = question.Id;
                var wellnessMultipleChoiceQuestionAndAnswers = new WellnessScaleQuestionsAndAnswers();
                wellnessMultipleChoiceQuestionAndAnswers.WellnessScaleQuestion = question;

                foreach (var answer in getScaleQuestionAnswers)
                {
                    var wellnessMultipleChoiceQuestionId = answer.WellnessScaleQuestionId;

                    if (questionId == wellnessMultipleChoiceQuestionId)
                    {
                        wellnessMultipleChoiceQuestionAndAnswers.WellnessScaleQuestionAnswers.Add(answer);
                    }
                }
            }

            return allScaleQuestionsAndAnswers;
        }

        public async Task<IList<WellnessBooleanQuestionsAndAnswers>> GetBooleanQuestionsAndAnswers()
        {
            var allBooleanQuestionsAndAnswers = new List<WellnessBooleanQuestionsAndAnswers>();

            var getBooleanQuestions = await _Play360Context.WellnessBooleanQuestion.ToListAsync();
            var getBooleanQuestionAnswers = await _Play360Context.WellnessBooleanQuestionAnswer.ToListAsync();

            foreach (var question in getBooleanQuestions)
            {
                var questionId = question.Id;
                var wellnessBooleanQuestionAndAnswers = new WellnessBooleanQuestionsAndAnswers();
                wellnessBooleanQuestionAndAnswers.WellnessBooleanQuestion = question;

                foreach (var answer in getBooleanQuestionAnswers)
                {
                    var wellnessBooleanQuestionId = answer.WellnessBooleanQuestionId;

                    if (questionId == wellnessBooleanQuestionId)
                    {
                        wellnessBooleanQuestionAndAnswers.WellnessBooleanQuestionAnswers.Add(answer);
                    }
                }
            }

            return allBooleanQuestionsAndAnswers;
        }

        public async Task<int> AddWellnessCheckin(WellnessCheckin wellnessCheckin)
        {
            await _Play360Context.WellnessCheckin.AddAsync(wellnessCheckin);
            await _Play360Context.SaveChangesAsync();
            int insertedUserId = wellnessCheckin.Id;
            return insertedUserId;
        }

        public async Task AddMultipleChoiceCheckinResponses(IList<WellnessMultipleChoiceCheckinResponse> wellnessMultipleChoiceCheckinResponses)
        {
            await _Play360Context.WellnessMultipleChoiceCheckinResponse.AddRangeAsync(wellnessMultipleChoiceCheckinResponses);
        }
    }
}
