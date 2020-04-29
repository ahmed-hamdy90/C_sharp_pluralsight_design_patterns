using System;
using System.Collections.Generic;
using System.Linq;
using NullObject.Entities;

namespace NullObject.Services
{
    /// <summary>
    /// LearnerService class which responsible for retrieve learners details 
    /// </summary>
    public class LearnerService
    {
        private LearnerRepo _repo;

        /// <summary>
        /// LearnerService constructor
        /// </summary>
        public LearnerService()
        {
            _repo = new LearnerRepo();
        }

        /// <summary>
        /// Getting the current learner full details instance 
        /// </summary>
        /// <returns>learner details instance</returns>
        /// <exception cref="NullReferenceException">throw if learner was not exists</exception>
        public ILearner GetCurrentLearner()
        {
            // go get the learner's id from a JWT token cookie
            // or by some other appropriate means

            int learnerId = 5;

            var learner = _repo.GetLearner(learnerId);

            if (learner == null)
            {
                throw new NullReferenceException();
            }
                
            return learner;
        }

        /// <summary>
        /// Internal subclass represent as Learner Repository
        /// </summary>
        class LearnerRepo
        {
            private readonly IList<Learner> _learners = new List<Learner>();

            /// <summary>
            /// LearnerRepo constructor
            /// </summary>
            internal LearnerRepo()
            {
                _learners.Add(new Learner(1, "David", 83));
                _learners.Add(new Learner(2, "Julia", 72));
                _learners.Add(new Learner(3, "Scott", 92));
            }

            /// <summary>
            /// Getting learner full details instance for given learner's id
            /// </summary>
            /// <param name="id">learner's id value wanted to get</param>
            /// <returns>learner instance, null if not exists</returns>
            internal ILearner GetLearner(int id)
            {
                bool learnerExists = _learners.Any(l => l.Id == id);

                if (learnerExists)
                {
                    return _learners.FirstOrDefault(l => l.Id == id);
                }

                return null;
            }
        } 
    }
}