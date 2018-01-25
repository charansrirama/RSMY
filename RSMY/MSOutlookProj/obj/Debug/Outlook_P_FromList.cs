using System;

namespace MSOutlookProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// Automator-8D559A6871D46FC
[OpenSpan.Design.ComponentIdentityAttribute("Automator-8D559A6871D46FC")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class Outlook_P_FromList : OpenSpan.Automation.Automator
{
	
	private OpenSpan.Automation.ConnectableEvent connectableEvent1;
	
	public Outlook_P_FromList()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(Outlook_P_FromList));
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		this.connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("Automator-8D559A6871D46FC");
		// 
		// Set component Ids
		// 
		this.SetId(this.connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D559D6C58C5034"));
		// 
		// Outlook_P_FromList
		// 
		ComponentInfo.CodeDomData = _resources_.GetString("_Outlook_P_FromList_1_");
		this.IsStartStoppable = false;
		this.LogData = true;
		this.LogEvents = true;
		this.LogFile = "";
		this.LogToFile = false;
		this.Name = "Outlook_P_FromList";
		this.ShowDesignCompNames = true;
		this.SuppressErrors = false;
		// 
		// connectableEvent1
		// 
		this.connectableEvent1.DisplayName = "null";
		this.connectableEvent1.ExceptionsHandled = false;
		this.connectableEvent1.InstanceTypeName = "OpenSpan.Office.MicrosoftOutlook";
		this.connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D559A643E79644\\MicrosoftOutlook-8D559A64DC65E61");
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "NewMail";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeAssemblyName = "OpenSpan.Office";
		memberprototype1.TypeName = "OpenSpan.Office.MicrosoftOutlookMailHandler";
		this.connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// Initialize CodeDom data
		// 
		this.CodeDomData = _resources_.GetString("_Outlook_P_FromList_2_");
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.connectableEvent1);
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
	
	internal OpenSpan.Automation.ConnectableEvent Create_connectableEvent1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Automation.ConnectableEvent connectableEvent1 = new OpenSpan.Automation.ConnectableEvent();
		this.SetId(connectableEvent1, new OpenSpan.Design.ComponentIdentity("ConnectableEvent-8D559D6C58C5034"));
		connectableEvent1.DisplayName = "null";
		connectableEvent1.ExceptionsHandled = false;
		connectableEvent1.InstanceTypeName = "OpenSpan.Office.MicrosoftOutlook";
		connectableEvent1.InstanceUniqueId = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D559A643E79644\\MicrosoftOutlook-8D559A64DC65E61");
		OpenSpan.Automation.MemberPrototype memberprototype1 = new OpenSpan.Automation.MemberPrototype();
		memberprototype1.DefaultValue = null;
		memberprototype1.MemberName = "NewMail";
		memberprototype1.MemberType = System.Reflection.MemberTypes.Event;
		memberprototype1.Signature.ReturnType = null;
		memberprototype1.TypeAssemblyName = "OpenSpan.Office";
		memberprototype1.TypeName = "OpenSpan.Office.MicrosoftOutlookMailHandler";
		connectableEvent1.MemberPrototypes.Add(memberprototype1);
		// 
		// Result
		// 
		return connectableEvent1;
	}
}

}

