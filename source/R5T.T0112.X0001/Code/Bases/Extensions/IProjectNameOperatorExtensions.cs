using System;

using R5T.T0112;

using Instances = R5T.T0112.X0001.Instances;


namespace System
{
    public static class IProjectNameOperatorExtensions
    {
        public static string GetBaseProjectName(this IProjectNameOperator _,
            string projectNameStem)
        {
            var output = _.GetProjectName(projectNameStem, Instances.ProjectNameAffix.Base());
            return output;
        }

        public static string GetConstructionProjectName(this IProjectNameOperator _,
            string projectNameStem)
        {
            var output = _.GetProjectName(projectNameStem, Instances.ProjectNameAffix.Construction());
            return output;
        }

        public static string GetDefaultProjectNamespaceName(this IProjectNameOperator _,
            string projectName)
        {
            // The default project namespace name is just the project name.
            var output = projectName;
            return output;
        }
    }
}
