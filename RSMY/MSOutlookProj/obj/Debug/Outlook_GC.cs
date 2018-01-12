using System;

namespace MSOutlookProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D559A643E79644
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D559A643E79644")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class Outlook_GC : OpenSpan.Automation.GlobalContainer
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D559A643E79644\\MicrosoftOutlook-8D559A64DC65E61")]
	public OpenSpan.Office.MicrosoftOutlook Outlook;
	
	public Outlook_GC()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Outlook_GC));
		this.Outlook = new OpenSpan.Office.MicrosoftOutlook();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D559A643E79644");
		// 
		// Set component Ids
		// 
		this.SetId(this.Outlook, new OpenSpan.Design.ComponentIdentity("MicrosoftOutlook-8D559A64DC65E61"));
		// 
		// Outlook_GC
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("_Outlook_GC_1_");
		this.IsStartStoppable = false;
		this.Name = "Outlook_GC";
		// 
		// Outlook
		// 
		this.Outlook.StartOnProjectStart = true;
		this.Outlook.SupportedVersion = "16";
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.Outlook);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Office.MicrosoftOutlook Create_Outlook(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Office.MicrosoftOutlook Outlook = new OpenSpan.Office.MicrosoftOutlook();
		this.SetId(Outlook, new OpenSpan.Design.ComponentIdentity("MicrosoftOutlook-8D559A64DC65E61"));
		Outlook.StartOnProjectStart = true;
		Outlook.SupportedVersion = "16";
		// 
		// Result
		// 
		return Outlook;
	}
}

}

