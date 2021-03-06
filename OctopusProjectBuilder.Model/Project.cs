using System;
using System.Collections.Generic;
using System.Linq;

namespace OctopusProjectBuilder.Model
{
    public class Project : IVariableSet
    {
        public Project(ElementIdentifier identifier, string description, bool isDisabled, bool autoCreateRelease, bool defaultToSkipIfAlreadyInstalled, DeploymentProcess deploymentProcess, IEnumerable<Variable> variables, IEnumerable<ElementReference> libraryVariableSetRefs, ElementReference lifecycleRef, ElementReference projectGroupRef, VersioningStrategy versioningStrategy, IEnumerable<ProjectTrigger> triggers)
        {
            if (identifier == null)
                throw new ArgumentNullException(nameof(identifier));
            if (deploymentProcess == null)
                throw new ArgumentNullException(nameof(deploymentProcess));
            if (libraryVariableSetRefs == null)
                throw new ArgumentNullException(nameof(libraryVariableSetRefs));
            if (triggers == null)
                throw new ArgumentNullException(nameof(triggers));
            Identifier = identifier;
            Description = description;
            IsDisabled = isDisabled;
            AutoCreateRelease = autoCreateRelease;
            DefaultToSkipIfAlreadyInstalled = defaultToSkipIfAlreadyInstalled;
            DeploymentProcess = deploymentProcess;
            IncludedLibraryVariableSetRefs = libraryVariableSetRefs.ToArray();
            Variables = variables.ToArray();
            LifecycleRef = lifecycleRef;
            ProjectGroupRef = projectGroupRef;
            VersioningStrategy = versioningStrategy;
            Triggers = triggers.ToArray();
        }

        public ElementIdentifier Identifier { get; }
        public string Description { get; }
        public bool IsDisabled { get; }
        public bool AutoCreateRelease { get; }
        public bool DefaultToSkipIfAlreadyInstalled { get; }
        public DeploymentProcess DeploymentProcess { get; }
        public IEnumerable<ElementReference> IncludedLibraryVariableSetRefs { get; }
        public ElementReference LifecycleRef { get; }
        public ElementReference ProjectGroupRef { get; }
        public IEnumerable<Variable> Variables { get; }
        public VersioningStrategy VersioningStrategy { get; }
        public IEnumerable<ProjectTrigger> Triggers { get; }

        public override string ToString()
        {
            return Identifier.ToString();
        }
    }
}