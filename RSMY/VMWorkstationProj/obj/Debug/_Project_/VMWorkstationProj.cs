using VMWorkstationProj_VMWorkStation = VMWorkstationProj.VMWorkStation;

using System;

namespace VMWorkstationProj.Project
{
// Project-8D55845A359BA43
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D55845A359BA43")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class VMWorkstationProj : OpenSpan.Runtime.RuntimeProject
{
	
	public VMWorkstationProj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.VMWorkstationProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public VMWorkstationProj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.VMWorkstationProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public VMWorkstationProj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.VMWorkstationProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public VMWorkstationProj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.VMWorkstationProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private VMWorkstationProj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.VMWorkstationProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void VMWorkstationProj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D55845A359BA43");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WindowsAdapter-8D55845B3CD7624
	public VMWorkstationProj_VMWorkStation VMWorkStation
	{
		get
		{
			return ((VMWorkstationProj_VMWorkStation)(this["VMWorkStation"]));
		}
	}
}

}

