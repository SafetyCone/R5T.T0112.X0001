using System;

using R5T.T0112;

using Instances = R5T.T0112.X0001.Instances;


namespace System
{
    public static class ISolutionNameOperatorExtensions
    {
        /// <summary>
        /// Just returns the solution name stem (assumes the solution name is the same as the solution name stem).
        /// </summary>
        public static string GetServiceSolutionName(this ISolutionNameOperator _,
            string solutionNameStem)
        {
            // The name of the service solution is just the solution name stem.
            var output = solutionNameStem;
            return output;
        }

        /// <summary>
        /// Appends the construction solution name token to the solution name stem.
        /// </summary>
        public static string GetConstructionSolutionName(this ISolutionNameOperator _,
            string solutionNameStem)
        {
            var output = _.AppendToken(
                solutionNameStem,
                Instances.ProjectNameAffix.Construction());

            return output;
        }

        /// <summary>
        /// Assumes that the experiment solution name is the same as the solution name stem.
        /// This should be the adjusted (possible "-Private") name.
        /// </summary>
        public static string GetExperimentSolutionName(this ISolutionNameOperator _,
            string solutionNameStem)
        {
            // Just assume the solution name stem is the experiment solution name.
            var output = solutionNameStem;
            return output;
        }
    }
}
