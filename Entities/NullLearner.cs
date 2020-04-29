
namespace NullObject.Entities
{
    /// <summary>
    /// NullLearner represent Null object for Learner instance, Which apply NullObject pattern.
    /// </summary>
    public class NullLearner : ILearner
    {
        /// <inheritdoc cref="ILearner.Id" />
        public int Id => -1;

        /// <inheritdoc cref="ILearner.UserName" />
        public string UserName => "Just Browsing";

        /// <inheritdoc cref="ILearner.CoursesCompleted" />
        public int CoursesCompleted => 0;
    }
}