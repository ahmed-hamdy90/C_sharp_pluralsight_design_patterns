
namespace NullObject.Entities
{
    /// <summary>
    /// Learner class implementation
    /// </summary>
    public class Learner: ILearner
    {
        /// <summary>
        /// Learner constructor
        /// </summary>
        /// <param name="id">learner's id value</param>
        /// <param name="userName">learner's username value</param>
        /// <param name="coursesCompleted">number of courses has been complete by learner value</param>
        public Learner(int id, string userName, int coursesCompleted)
        {
            this.Id = id;
            this.UserName = userName;
            this.CoursesCompleted = coursesCompleted;
        }

        /// <inheritdoc cref="ILearner.Id" />
        public int Id { get; private set; }

        /// <inheritdoc cref="ILearner.UserName" />
        public string UserName { get; private set; }

        /// <inheritdoc cref="ILearner.CoursesCompleted" />
        public int CoursesCompleted { get; private set; }
    }
}