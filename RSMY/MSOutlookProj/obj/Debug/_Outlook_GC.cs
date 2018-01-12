using System;

namespace MSOutlookProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D559A643E79644
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D559A643E79644")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class _Outlook_GC : OpenSpan.Automation.GlobalContainer
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D559A643E79644\\MicrosoftOutlook-8D559A64DC65E61")]
	public OpenSpan.Office.MicrosoftOutlook Outlook;
	
	[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D559A643E79644\\Script-8D559B35648E8E8")]
	public OpenSpan.Script.Custom.Script Function_Script;
	
	public _Outlook_GC()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(_Outlook_GC));
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo1 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		this.Outlook = new OpenSpan.Office.MicrosoftOutlook();
		this.Function_Script = new OpenSpan.Script.Custom.Script();
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
		this.SetId(this.Function_Script, new OpenSpan.Design.ComponentIdentity("Script-8D559B35648E8E8"));
		// 
		// _Outlook_GC
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("__Outlook_GC_1_");
		this.IsStartStoppable = false;
		this.Name = "_Outlook_GC";
		// 
		// Outlook
		// 
		this.Outlook.StartOnProjectStart = true;
		this.Outlook.SupportedVersion = "16";
		// 
		// Function_Script
		// 
		dynamicmethodinfo1.Source = "";
		dynamicmethodinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo1.CodeDomData = _resources_.GetString("__Outlook_GC_2_");
		this.Function_Script.DynamicMembers.Add(dynamicmethodinfo1);
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.Outlook);
		this.Components.Add(this.Function_Script);
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
	
	internal OpenSpan.Script.Custom.Script Create_Function_Script(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(_Outlook_GC));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Script.Custom.Script Function_Script = new OpenSpan.Script.Custom.Script();
		this.SetId(Function_Script, new OpenSpan.Design.ComponentIdentity("Script-8D559B35648E8E8"));
		OpenSpan.DynamicMembers.DynamicMethodInfo dynamicmethodinfo1 = new OpenSpan.DynamicMembers.DynamicMethodInfo();
		dynamicmethodinfo1.Source = "";
		dynamicmethodinfo1.Visibility = OpenSpan.TypeManagement.MemberVisibilityLevel.DefaultOn;
		dynamicmethodinfo1.CodeDomData = _resources_.GetString("__Outlook_GC_2_");
		Function_Script.DynamicMembers.Add(dynamicmethodinfo1);
		// 
		// Result
		// 
		return Function_Script;
	}
}

}

