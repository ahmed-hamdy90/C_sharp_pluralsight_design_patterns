
namespace NullObject.Entities
{
    /// <summary>
    /// ILeaner interface represent basic shape of any Learner class
    /// </summary>
    public interface ILearner
    {
        /// <summary>
        /// Learner's id value
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Learner's username value
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// Number of courses has been complete by learner
        /// </summary>
        int CoursesCompleted { get; }
    }
}