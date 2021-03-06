﻿using JetBrains.ProjectModel;
using JetBrains.Util;
using System.Collections.Generic;

/*
    Paket available: dependencies.locate returns something

    Paket.Constants
        DependenciesFileName: paket.dependencies
        PackagesFolderName: packages

    FileSystemWatcher on paket.dependencies?
    Update cache with list of packages (with list of dlls)


    namespace JetBrains.ReSharper.Intentions.QuickFixes
{
  public sealed class ReferenceModuleAndTypeFixItem : BulbActionBase


*/

namespace Resharper.Paket.CSharp
{
    //[SolutionComponent]
    public class PaketApi
    {
        private bool IsPaketAvailable
        {
            get { return false; }
        }
        private bool TryGetPackageFromAssemblyLocations(IList<FileSystemPath> assemblyLocations, out FileSystemPath installedLocation)
        {
            installedLocation = null;
            return false;
        }
        public bool AreAnyAssemblyFilesPaketPackages(IList<FileSystemPath> fileLocations)
        {
            if (!IsPaketAvailable || fileLocations.Count == 0)
                return false;
            FileSystemPath installedLocation;
            var hasPackageAssembly = TryGetPackageFromAssemblyLocations(fileLocations, out installedLocation);
            if (!hasPackageAssembly)
            {}//LogNoPackageFound(fileLocations);
            return hasPackageAssembly;
        }
    }
}
