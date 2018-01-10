using RSMY_StartApps = RSMY.StartApps;

using RSMY__RSMY_GC = RSMY._RSMY_GC;

using System;

namespace RSMY.Project
{
// Project-8D5583FDD604184
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D5583FDD604184")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
public sealed class RSMY : OpenSpan.Runtime.RuntimeProject
{
	
	public RSMY() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.RSMY_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public RSMY(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.RSMY_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public RSMY(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.RSMY_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public RSMY(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.RSMY_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private RSMY(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.RSMY_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void RSMY_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D5583FDD604184");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// Automator-8D5584A43CFC4BA
	public RSMY_StartApps StartApps
	{
		get
		{
			return ((RSMY_StartApps)(this["StartApps"]));
		}
	}
	
	// GlobalContainer-8D5584A5CBDA1D6
	public RSMY__RSMY_GC _RSMY_GC
	{
		get
		{
			return ((RSMY__RSMY_GC)(this["_RSMY_GC"]));
		}
	}
}

}

