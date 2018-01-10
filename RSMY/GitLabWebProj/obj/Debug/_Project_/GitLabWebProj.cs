using GitLabWebProj_GitLab = GitLabWebProj.GitLab;

using System;

namespace GitLabWebProj.Project
{
// Project-8D558457B93A723
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D558457B93A723")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class GitLabWebProj : OpenSpan.Runtime.RuntimeProject
{
	
	public GitLabWebProj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.GitLabWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public GitLabWebProj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.GitLabWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public GitLabWebProj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.GitLabWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public GitLabWebProj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.GitLabWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private GitLabWebProj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.GitLabWebProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void GitLabWebProj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D558457B93A723");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WebAdapter-8D55848EDC39C90
	public GitLabWebProj_GitLab GitLab
	{
		get
		{
			return ((GitLabWebProj_GitLab)(this["GitLab"]));
		}
	}
}

}

