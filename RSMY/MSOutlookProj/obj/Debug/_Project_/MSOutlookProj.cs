using MSOutlookProj_Outlook_P_ToList = MSOutlookProj.Outlook_P_ToList;

using MSOutlookProj_Outlook_P_FromList = MSOutlookProj.Outlook_P_FromList;

using MSOutlookProj__Outlook_GC = MSOutlookProj._Outlook_GC;

using MSOutlookProj_Outlook_P_PegaNotification = MSOutlookProj.Outlook_P_PegaNotification;

using System;

namespace MSOutlookProj.Project
{
// Project-8D558455A35D45A
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D558455A35D45A")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
public sealed class MSOutlookProj : OpenSpan.Runtime.RuntimeProject
{
	
	public MSOutlookProj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MSOutlookProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MSOutlookProj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MSOutlookProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MSOutlookProj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MSOutlookProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public MSOutlookProj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MSOutlookProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private MSOutlookProj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.MSOutlookProj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void MSOutlookProj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D558455A35D45A");
		this.mVersion = new System.Version("8.0.1072.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// Automator-8D559A6335FB08C
	public MSOutlookProj_Outlook_P_ToList Outlook_P_ToList
	{
		get
		{
			return ((MSOutlookProj_Outlook_P_ToList)(this["Outlook_P_ToList"]));
		}
	}
	
	// Automator-8D559A6871D46FC
	public MSOutlookProj_Outlook_P_FromList Outlook_P_FromList
	{
		get
		{
			return ((MSOutlookProj_Outlook_P_FromList)(this["Outlook_P_FromList"]));
		}
	}
	
	// GlobalContainer-8D559A643E79644
	public MSOutlookProj__Outlook_GC _Outlook_GC
	{
		get
		{
			return ((MSOutlookProj__Outlook_GC)(this["_Outlook_GC"]));
		}
	}
	
	// Automator-8D559A4BCEAFB41
	public MSOutlookProj_Outlook_P_PegaNotification Outlook_P_PegaNotification
	{
		get
		{
			return ((MSOutlookProj_Outlook_P_PegaNotification)(this["Outlook_P_PegaNotification"]));
		}
	}
}

}

