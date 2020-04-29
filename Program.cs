using NullObject.Entities;
using NullObject.Services;
using NullObject.View;

namespace NullObject
{
    /// <summary>
    /// Main Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main static method
        /// </summary>
        /// <param name="args">arguments list</param>
        static void Main(string[] args)
        {
            LearnerService learnerService = new LearnerService();
            ILearner learner = learnerService.GetCurrentLearner();
            
            LearnerView learnerView = new LearnerView(learner);
            learnerView.RenderView();
        }
    }
}
