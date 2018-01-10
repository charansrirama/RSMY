using PMFWebProj_PMF = PMFWebProj.PMF;

using System;

namespace PMFWebProj.Project
{
// Project-8D558456F2813C8
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D558456F2813C8")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class PMFWebProj : OpenSpan.Runtime.RuntimeProject
{
	
	public PMFWebProj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PMFWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PMFWebProj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PMFWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PMFWebProj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PMFWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PMFWebProj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PMFWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private PMFWebProj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PMFWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void PMFWebProj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D558456F2813C8");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WebAdapter-8D55845DBDF670E
	public PMFWebProj_PMF PMF
	{
		get
		{
			return ((PMFWebProj_PMF)(this["PMF"]));
		}
	}
}

}

