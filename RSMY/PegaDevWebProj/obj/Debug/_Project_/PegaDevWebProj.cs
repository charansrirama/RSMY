using PegaDevWebProj_PegaDevLab5127 = PegaDevWebProj.PegaDevLab5127;

using System;

namespace PegaDevWebProj.Project
{
// Project-8D55845889C0B3D
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D55845889C0B3D")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class PegaDevWebProj : OpenSpan.Runtime.RuntimeProject
{
	
	public PegaDevWebProj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PegaDevWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PegaDevWebProj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PegaDevWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PegaDevWebProj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PegaDevWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public PegaDevWebProj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PegaDevWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private PegaDevWebProj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.PegaDevWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void PegaDevWebProj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D55845889C0B3D");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WebAdapter-8D558467FE3C125
	public PegaDevWebProj_PegaDevLab5127 PegaDevLab5127
	{
		get
		{
			return ((PegaDevWebProj_PegaDevLab5127)(this["PegaDevLab5127"]));
		}
	}
}

}

