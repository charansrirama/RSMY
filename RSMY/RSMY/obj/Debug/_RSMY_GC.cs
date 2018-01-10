using System;

namespace RSMY
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D5584A5CBDA1D6
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D5584A5CBDA1D6")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class _RSMY_GC : OpenSpan.Automation.GlobalContainer
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D5584A5CBDA1D6\\StartMyDayController-8D5584A62C29E68")]
	public OpenSpan.ApplicationFramework.StartMyDay.StartMyDayController startMyDayController1;
	
	public _RSMY_GC()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(_RSMY_GC));
		this.startMyDayController1 = new OpenSpan.ApplicationFramework.StartMyDay.StartMyDayController();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D5584A5CBDA1D6");
		// 
		// Set component Ids
		// 
		this.SetId(this.startMyDayController1, new OpenSpan.Design.ComponentIdentity("StartMyDayController-8D5584A62C29E68"));
		// 
		// _RSMY_GC
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("__RSMY_GC_1_");
		this.IsStartStoppable = false;
		this.Name = "_RSMY_GC";
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.startMyDayController1);
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
	
	internal OpenSpan.ApplicationFramework.StartMyDay.StartMyDayController Create_startMyDayController1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.ApplicationFramework.StartMyDay.StartMyDayController startMyDayController1 = new OpenSpan.ApplicationFramework.StartMyDay.StartMyDayController();
		this.SetId(startMyDayController1, new OpenSpan.Design.ComponentIdentity("StartMyDayController-8D5584A62C29E68"));
		// 
		// Result
		// 
		return startMyDayController1;
	}
}

}

