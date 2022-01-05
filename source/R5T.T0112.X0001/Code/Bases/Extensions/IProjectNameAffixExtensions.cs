using System;

using R5T.T0112;
using R5T.T0112.X0001;


namespace System
{
    public static class IProjectNameAffixExtensions
    {
        public static string Base(this IProjectNameAffix _)
        {
            return ProjectNameAffixes.Base;
        }

        public static string Construction(this IProjectNameAffix _)
        {
            return ProjectNameAffixes.Construction;
        }
    }
}
