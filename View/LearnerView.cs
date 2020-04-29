using System;
using NullObject.Entities;

namespace NullObject.View
{
    /// <summary>
    /// Learner view class implementation which responsible for render learner view 
    /// </summary>
    public class LearnerView
    {
        private readonly ILearner _learner;

        /// <summary>
        /// LearnerView constructor
        /// </summary>
        /// <param name="learner">learner details instance who will be view</param>
        public LearnerView(ILearner learner)
        {
            if (learner == null) throw new ArgumentNullException();
            if (learner.UserName == null) throw new ArgumentNullException();

            _learner = learner;
        }

        /// <summary>
        /// Render learner view method
        /// </summary>
        public void RenderView()
        {
            Console.WriteLine("User Name: " + _learner.UserName);
            Console.WriteLine("Courses Completed: " + _learner.CoursesCompleted);
        }
    }
}