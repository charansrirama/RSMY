using System;

namespace PMFWebProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WebAdapter-8D55845DBDF670E
[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class PMF : OpenSpan.Adapters.Web.WebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\ActiveXFactory-8D55846328EB70D")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\WinInetFactory-8D55846335D21A6")]
	public OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\MicrosoftHTMLFactory-8D55846338FF410")]
	public OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Form-8D5584714C2129B")]
	public OpenSpan.Adapters.Controls.Form Windows_Security;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Control-8D5584714C08BE7")]
	public OpenSpan.Adapters.Controls.Control Control1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Control-8D5584714BE2E50")]
	public OpenSpan.Adapters.Controls.Control Control;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\TextBox-8D5584714B9D4CF")]
	public OpenSpan.Adapters.Controls.TextBox txtUserName;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule3;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Control-8D55847168B2A31")]
	public OpenSpan.Adapters.Controls.Control Control2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\TextBox-8D5584716898FF4")]
	public OpenSpan.Adapters.Controls.TextBox txtPassword;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule5;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule4;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Control-8D558471845877E")]
	public OpenSpan.Adapters.Controls.Control Control3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55845DBDF670E\\Button-8D5584718417C21")]
	public OpenSpan.Adapters.Controls.Button btnOk;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule7;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule6;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule2;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule1;
	
	private OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1;
	
	private OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule1;
	
	public PMF()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(PMF));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.ApplicationFramework.AssistedSignOn.Credential credential1 = new OpenSpan.ApplicationFramework.AssistedSignOn.Credential();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.Windows_Security = new OpenSpan.Adapters.Controls.Form();
		this.Control1 = new OpenSpan.Adapters.Controls.Control();
		this.Control = new OpenSpan.Adapters.Controls.Control();
		this.txtUserName = new OpenSpan.Adapters.Controls.TextBox();
		this.classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.classNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.Control2 = new OpenSpan.Adapters.Controls.Control();
		this.txtPassword = new OpenSpan.Adapters.Controls.TextBox();
		this.classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.classNameMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.Control3 = new OpenSpan.Adapters.Controls.Control();
		this.btnOk = new OpenSpan.Adapters.Controls.Button();
		this.windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.classNameMatchRule7 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.classNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.windowTypeMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.classNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WebAdapter-8D55845DBDF670E");
		// 
		// Set component Ids
		// 
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D55846328EB70D"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55846329BB007"));
		this.SetId(this.WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D55846335D21A6"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633633C76"));
		this.SetId(this.MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D55846338FF410"));
		this.SetId(this.moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633970CD5"));
		this.SetId(this.Windows_Security, new OpenSpan.Design.ComponentIdentity("Form-8D5584714C2129B"));
		this.SetId(this.Control1, new OpenSpan.Design.ComponentIdentity("Control-8D5584714C08BE7"));
		this.SetId(this.Control, new OpenSpan.Design.ComponentIdentity("Control-8D5584714BE2E50"));
		this.SetId(this.txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584714B9D4CF"));
		this.SetId(this.classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		this.SetId(this.windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		this.SetId(this.classNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E84DB8"));
		this.SetId(this.windowTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714EA49A2"));
		this.SetId(this.Control2, new OpenSpan.Design.ComponentIdentity("Control-8D55847168B2A31"));
		this.SetId(this.txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584716898FF4"));
		this.SetId(this.classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		this.SetId(this.windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		this.SetId(this.classNameMatchRule5, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847168D39A4"));
		this.SetId(this.windowTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584716900C71"));
		this.SetId(this.Control3, new OpenSpan.Design.ComponentIdentity("Control-8D558471845877E"));
		this.SetId(this.btnOk, new OpenSpan.Design.ComponentIdentity("Button-8D5584718417C21"));
		this.SetId(this.windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		this.SetId(this.classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		this.SetId(this.windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		this.SetId(this.classNameMatchRule7, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584718485A4B"));
		this.SetId(this.windowTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D55847184A42AC"));
		this.SetId(this.classNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E3B99C"));
		this.SetId(this.windowTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714E5C90F"));
		this.SetId(this.windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D5584714C4220E"));
		this.SetId(this.classNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714D512DC"));
		// 
		// PMF
		// 
		this.AddressBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_PMF_1_");
		// 
		// ActiveXFactory
		// 
		this.ActiveXFactory.Extender = null;
		this.ActiveXFactory.FactoryName = null;
		this.ActiveXFactory.ForwardObjectExplorerEvent = true;
		this.ActiveXFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule1
		// 
		textmatchdata1.Text = "ole32.dll";
		this.moduleNameMatchRule1.Text = textmatchdata1;
		this.ActiveXFactory.MatchRules.Add(this.moduleNameMatchRule1);
		this.ActiveXFactory.Name = "ActiveXFactory";
		this.ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.ActiveXFactory.UseKeys = true;
		// 
		// WinInetFactory
		// 
		this.WinInetFactory.Extender = null;
		this.WinInetFactory.FactoryName = null;
		this.WinInetFactory.ForwardObjectExplorerEvent = true;
		this.WinInetFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule2
		// 
		textmatchdata2.Text = "wininet.dll";
		this.moduleNameMatchRule2.Text = textmatchdata2;
		this.WinInetFactory.MatchRules.Add(this.moduleNameMatchRule2);
		this.WinInetFactory.Name = "WinInetFactory";
		this.WinInetFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.WinInetFactory.UseKeys = true;
		// 
		// MicrosoftHTMLFactory
		// 
		this.MicrosoftHTMLFactory.Extender = null;
		this.MicrosoftHTMLFactory.FactoryName = null;
		this.MicrosoftHTMLFactory.ForwardObjectExplorerEvent = true;
		this.MicrosoftHTMLFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule3
		// 
		textmatchdata3.Text = "mshtml.dll";
		this.moduleNameMatchRule3.Text = textmatchdata3;
		this.MicrosoftHTMLFactory.MatchRules.Add(this.moduleNameMatchRule3);
		this.MicrosoftHTMLFactory.Name = "MicrosoftHTMLFactory";
		this.MicrosoftHTMLFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.MicrosoftHTMLFactory.UseKeys = true;
		// 
		// Windows_Security
		// 
		// 
		// Control1
		// 
		// 
		// Control
		// 
		// 
		// txtUserName
		// 
		this.txtUserName.Extender = null;
		this.txtUserName.ExtensibleTypeName = null;
		this.txtUserName.ForwardObjectExplorerEvent = true;
		this.txtUserName.MatchingIndex = 0;
		// 
		// classNameMatchRule4
		// 
		this.classNameMatchRule4.ClassName = "Edit";
		// 
		// windowTypeMatchRule3
		// 
		this.windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.txtUserName.MatchRules.Add(this.classNameMatchRule4);
		this.txtUserName.MatchRules.Add(this.windowTypeMatchRule3);
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		this.Control.Controls.Add(this.txtUserName);
		this.Control.Extender = null;
		this.Control.ExtensibleTypeName = null;
		this.Control.ForwardObjectExplorerEvent = true;
		this.Control.MatchingIndex = 6;
		// 
		// classNameMatchRule3
		// 
		this.classNameMatchRule3.ClassName = "CtrlNotifySink";
		// 
		// windowTypeMatchRule2
		// 
		this.windowTypeMatchRule2.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.Control.MatchRules.Add(this.classNameMatchRule3);
		this.Control.MatchRules.Add(this.windowTypeMatchRule2);
		this.Control.Name = "Control";
		this.Control.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Control2
		// 
		// 
		// txtPassword
		// 
		this.txtPassword.Extender = null;
		this.txtPassword.ExtensibleTypeName = null;
		this.txtPassword.ForwardObjectExplorerEvent = true;
		this.txtPassword.MatchingIndex = 0;
		// 
		// classNameMatchRule6
		// 
		this.classNameMatchRule6.ClassName = "Edit";
		// 
		// windowTypeMatchRule5
		// 
		this.windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.txtPassword.MatchRules.Add(this.classNameMatchRule6);
		this.txtPassword.MatchRules.Add(this.windowTypeMatchRule5);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		this.Control2.Controls.Add(this.txtPassword);
		this.Control2.Extender = null;
		this.Control2.ExtensibleTypeName = null;
		this.Control2.ForwardObjectExplorerEvent = true;
		this.Control2.MatchingIndex = 7;
		// 
		// classNameMatchRule5
		// 
		this.classNameMatchRule5.ClassName = "CtrlNotifySink";
		// 
		// windowTypeMatchRule4
		// 
		this.windowTypeMatchRule4.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.Control2.MatchRules.Add(this.classNameMatchRule5);
		this.Control2.MatchRules.Add(this.windowTypeMatchRule4);
		this.Control2.Name = "Control2";
		this.Control2.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Control3
		// 
		// 
		// btnOk
		// 
		this.btnOk.Extender = null;
		this.btnOk.ExtensibleTypeName = null;
		this.btnOk.ForwardObjectExplorerEvent = true;
		this.btnOk.MatchingIndex = 0;
		// 
		// windowTextMatchRule2
		// 
		textmatchdata4.Text = "OK";
		this.windowTextMatchRule2.Text = textmatchdata4;
		// 
		// classNameMatchRule8
		// 
		this.classNameMatchRule8.ClassName = "Button";
		// 
		// windowTextMatchRule3
		// 
		textmatchdata5.Text = "OK";
		this.windowTextMatchRule3.Text = textmatchdata5;
		this.btnOk.MatchRules.Add(this.windowTextMatchRule2);
		this.btnOk.MatchRules.Add(this.classNameMatchRule8);
		this.btnOk.MatchRules.Add(this.windowTextMatchRule3);
		this.btnOk.Name = "btnOk";
		this.btnOk.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows";
		this.Control3.Controls.Add(this.btnOk);
		this.Control3.Extender = null;
		this.Control3.ExtensibleTypeName = null;
		this.Control3.ForwardObjectExplorerEvent = true;
		this.Control3.MatchingIndex = 2;
		// 
		// classNameMatchRule7
		// 
		this.classNameMatchRule7.ClassName = "CtrlNotifySink";
		// 
		// windowTypeMatchRule6
		// 
		this.windowTypeMatchRule6.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.Control3.MatchRules.Add(this.classNameMatchRule7);
		this.Control3.MatchRules.Add(this.windowTypeMatchRule6);
		this.Control3.Name = "Control3";
		this.Control3.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		this.Control1.Controls.Add(this.Control);
		this.Control1.Controls.Add(this.Control2);
		this.Control1.Controls.Add(this.Control3);
		this.Control1.Extender = null;
		this.Control1.ExtensibleTypeName = null;
		this.Control1.ForwardObjectExplorerEvent = true;
		this.Control1.MatchingIndex = 0;
		// 
		// classNameMatchRule2
		// 
		this.classNameMatchRule2.ClassName = "DirectUIHWND";
		// 
		// windowTypeMatchRule1
		// 
		this.windowTypeMatchRule1.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		this.Control1.MatchRules.Add(this.classNameMatchRule2);
		this.Control1.MatchRules.Add(this.windowTypeMatchRule1);
		this.Control1.Name = "Control1";
		this.Control1.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		this.Windows_Security.Controls.Add(this.Control1);
		this.Windows_Security.Extender = null;
		this.Windows_Security.ExtensibleTypeName = null;
		this.Windows_Security.ForwardObjectExplorerEvent = true;
		this.Windows_Security.MatchingIndex = 12;
		// 
		// windowTextMatchRule1
		// 
		textmatchdata6.Text = "Windows Security";
		this.windowTextMatchRule1.Text = textmatchdata6;
		// 
		// classNameMatchRule1
		// 
		this.classNameMatchRule1.ClassName = "#32770";
		this.Windows_Security.MatchRules.Add(this.windowTextMatchRule1);
		this.Windows_Security.MatchRules.Add(this.classNameMatchRule1);
		this.Windows_Security.Name = "Windows_Security";
		this.Windows_Security.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Form, OpenSpan.Adapters.Windows";
		this.Controls.Add(this.ActiveXFactory);
		this.Controls.Add(this.WinInetFactory);
		this.Controls.Add(this.MicrosoftHTMLFactory);
		this.Controls.Add(this.Windows_Security);
		credential1.ApplicationKey = "PMF";
		credential1.Category = null;
		credential1.Group = null;
		credential1.LoginControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55845DBDF670E\\Button-8D5584718417C21");
		credential1.PasswordControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55845DBDF670E\\TextBox-8D5584716898FF4");
		credential1.UserNameControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55845DBDF670E\\TextBox-8D5584714B9D4CF");
		this.Credentials.Add(credential1);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "PMF";
		this.MenuBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.Name = "PMF";
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.Automatic;
		this.StartOnProjectStart = false;
		this.StartPage = "https://agilestudio.pega.com";
		this.ToolBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.ActiveXFactory);
		this.Components.Add(this.moduleNameMatchRule1);
		this.Components.Add(this.WinInetFactory);
		this.Components.Add(this.moduleNameMatchRule2);
		this.Components.Add(this.MicrosoftHTMLFactory);
		this.Components.Add(this.moduleNameMatchRule3);
		this.Components.Add(this.Windows_Security);
		this.Components.Add(this.Control1);
		this.Components.Add(this.Control);
		this.Components.Add(this.txtUserName);
		this.Components.Add(this.classNameMatchRule4);
		this.Components.Add(this.windowTypeMatchRule3);
		this.Components.Add(this.classNameMatchRule3);
		this.Components.Add(this.windowTypeMatchRule2);
		this.Components.Add(this.Control2);
		this.Components.Add(this.txtPassword);
		this.Components.Add(this.classNameMatchRule6);
		this.Components.Add(this.windowTypeMatchRule5);
		this.Components.Add(this.classNameMatchRule5);
		this.Components.Add(this.windowTypeMatchRule4);
		this.Components.Add(this.Control3);
		this.Components.Add(this.btnOk);
		this.Components.Add(this.windowTextMatchRule2);
		this.Components.Add(this.classNameMatchRule8);
		this.Components.Add(this.windowTextMatchRule3);
		this.Components.Add(this.classNameMatchRule7);
		this.Components.Add(this.windowTypeMatchRule6);
		this.Components.Add(this.classNameMatchRule2);
		this.Components.Add(this.windowTypeMatchRule1);
		this.Components.Add(this.windowTextMatchRule1);
		this.Components.Add(this.classNameMatchRule1);
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
	
	internal OpenSpan.Adapters.ActiveX.ActiveXFactory Create_ActiveXFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D55846328EB70D"));
		ActiveXFactory.Extender = null;
		ActiveXFactory.FactoryName = null;
		ActiveXFactory.ForwardObjectExplorerEvent = true;
		ActiveXFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
		moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		ActiveXFactory.MatchRules.Add(moduleNameMatchRule1);
		ActiveXFactory.Name = "ActiveXFactory";
		ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		ActiveXFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55846329BB007"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule1);
		// 
		// Result
		// 
		return ActiveXFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55846329BB007"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.WinInet.WinInetFactory Create_WinInetFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.SetId(WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D55846335D21A6"));
		WinInetFactory.Extender = null;
		WinInetFactory.FactoryName = null;
		WinInetFactory.ForwardObjectExplorerEvent = true;
		WinInetFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
		moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "wininet.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		WinInetFactory.MatchRules.Add(moduleNameMatchRule2);
		WinInetFactory.Name = "WinInetFactory";
		WinInetFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		WinInetFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633633C76"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule2);
		// 
		// Result
		// 
		return WinInetFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633633C76"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "wininet.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MicrosoftHTMLFactory Create_MicrosoftHTMLFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.SetId(MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D55846338FF410"));
		MicrosoftHTMLFactory.Extender = null;
		MicrosoftHTMLFactory.FactoryName = null;
		MicrosoftHTMLFactory.ForwardObjectExplorerEvent = true;
		MicrosoftHTMLFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
		moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		MicrosoftHTMLFactory.MatchRules.Add(moduleNameMatchRule3);
		MicrosoftHTMLFactory.Name = "MicrosoftHTMLFactory";
		MicrosoftHTMLFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		MicrosoftHTMLFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633970CD5"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule3);
		// 
		// Result
		// 
		return MicrosoftHTMLFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584633970CD5"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule3;
	}
	
	internal OpenSpan.Adapters.Controls.Form Create_Windows_Security(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Form Windows_Security = new OpenSpan.Adapters.Controls.Form();
		this.SetId(Windows_Security, new OpenSpan.Design.ComponentIdentity("Form-8D5584714C2129B"));
		OpenSpan.Adapters.Controls.Control Control1;
		Control1 = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control1
		// 
		OpenSpan.Adapters.Controls.Control Control;
		Control = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control
		// 
		OpenSpan.Adapters.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.Extender = null;
		txtUserName.ExtensibleTypeName = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4;
		classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule4
		// 
		classNameMatchRule4.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3;
		windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule3
		// 
		windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtUserName.MatchRules.Add(classNameMatchRule4);
		txtUserName.MatchRules.Add(windowTypeMatchRule3);
		txtUserName.Name = "txtUserName";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control.Controls.Add(txtUserName);
		Control.Extender = null;
		Control.ExtensibleTypeName = null;
		Control.ForwardObjectExplorerEvent = true;
		Control.MatchingIndex = 6;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule3;
		classNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule3
		// 
		classNameMatchRule3.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule2;
		windowTypeMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule2
		// 
		windowTypeMatchRule2.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control.MatchRules.Add(classNameMatchRule3);
		Control.MatchRules.Add(windowTypeMatchRule2);
		Control.Name = "Control";
		Control.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		OpenSpan.Adapters.Controls.Control Control2;
		Control2 = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control2
		// 
		OpenSpan.Adapters.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.Extender = null;
		txtPassword.ExtensibleTypeName = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6;
		classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule6
		// 
		classNameMatchRule6.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5;
		windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule5
		// 
		windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtPassword.MatchRules.Add(classNameMatchRule6);
		txtPassword.MatchRules.Add(windowTypeMatchRule5);
		txtPassword.Name = "txtPassword";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control2.Controls.Add(txtPassword);
		Control2.Extender = null;
		Control2.ExtensibleTypeName = null;
		Control2.ForwardObjectExplorerEvent = true;
		Control2.MatchingIndex = 7;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule5;
		classNameMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule5
		// 
		classNameMatchRule5.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule4;
		windowTypeMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule4
		// 
		windowTypeMatchRule4.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control2.MatchRules.Add(classNameMatchRule5);
		Control2.MatchRules.Add(windowTypeMatchRule4);
		Control2.Name = "Control2";
		Control2.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		OpenSpan.Adapters.Controls.Control Control3;
		Control3 = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control3
		// 
		OpenSpan.Adapters.Controls.Button btnOk;
		btnOk = new OpenSpan.Adapters.Controls.Button();
		// 
		// btnOk
		// 
		btnOk.Extender = null;
		btnOk.ExtensibleTypeName = null;
		btnOk.ForwardObjectExplorerEvent = true;
		btnOk.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2;
		windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule2.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8;
		classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule8
		// 
		classNameMatchRule8.ClassName = "Button";
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3;
		windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "OK";
		windowTextMatchRule3.Text = textmatchdata2;
		btnOk.MatchRules.Add(windowTextMatchRule2);
		btnOk.MatchRules.Add(classNameMatchRule8);
		btnOk.MatchRules.Add(windowTextMatchRule3);
		btnOk.Name = "btnOk";
		btnOk.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows";
		Control3.Controls.Add(btnOk);
		Control3.Extender = null;
		Control3.ExtensibleTypeName = null;
		Control3.ForwardObjectExplorerEvent = true;
		Control3.MatchingIndex = 2;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule7;
		classNameMatchRule7 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule7
		// 
		classNameMatchRule7.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule6;
		windowTypeMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule6
		// 
		windowTypeMatchRule6.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control3.MatchRules.Add(classNameMatchRule7);
		Control3.MatchRules.Add(windowTypeMatchRule6);
		Control3.Name = "Control3";
		Control3.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		Control1.Controls.Add(Control);
		Control1.Controls.Add(Control2);
		Control1.Controls.Add(Control3);
		Control1.Extender = null;
		Control1.ExtensibleTypeName = null;
		Control1.ForwardObjectExplorerEvent = true;
		Control1.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule2;
		classNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule2
		// 
		classNameMatchRule2.ClassName = "DirectUIHWND";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule1;
		windowTypeMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule1
		// 
		windowTypeMatchRule1.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control1.MatchRules.Add(classNameMatchRule2);
		Control1.MatchRules.Add(windowTypeMatchRule1);
		Control1.Name = "Control1";
		Control1.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		Windows_Security.Controls.Add(Control1);
		Windows_Security.Extender = null;
		Windows_Security.ExtensibleTypeName = null;
		Windows_Security.ForwardObjectExplorerEvent = true;
		Windows_Security.MatchingIndex = 12;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1;
		windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "Windows Security";
		windowTextMatchRule1.Text = textmatchdata3;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule1;
		classNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule1
		// 
		classNameMatchRule1.ClassName = "#32770";
		Windows_Security.MatchRules.Add(windowTextMatchRule1);
		Windows_Security.MatchRules.Add(classNameMatchRule1);
		Windows_Security.Name = "Windows_Security";
		Windows_Security.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Form, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(Control1, new OpenSpan.Design.ComponentIdentity("Control-8D5584714C08BE7"));
		this.SetId(Control, new OpenSpan.Design.ComponentIdentity("Control-8D5584714BE2E50"));
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584714B9D4CF"));
		this.SetId(classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		this.SetId(windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		this.SetId(classNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E84DB8"));
		this.SetId(windowTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714EA49A2"));
		this.SetId(Control2, new OpenSpan.Design.ComponentIdentity("Control-8D55847168B2A31"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584716898FF4"));
		this.SetId(classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		this.SetId(windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		this.SetId(classNameMatchRule5, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847168D39A4"));
		this.SetId(windowTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584716900C71"));
		this.SetId(Control3, new OpenSpan.Design.ComponentIdentity("Control-8D558471845877E"));
		this.SetId(btnOk, new OpenSpan.Design.ComponentIdentity("Button-8D5584718417C21"));
		this.SetId(windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		this.SetId(classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		this.SetId(windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		this.SetId(classNameMatchRule7, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584718485A4B"));
		this.SetId(windowTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D55847184A42AC"));
		this.SetId(classNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E3B99C"));
		this.SetId(windowTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714E5C90F"));
		this.SetId(windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D5584714C4220E"));
		this.SetId(classNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714D512DC"));
		// 
		// Add components
		// 
		components.Add(Control1);
		components.Add(Control);
		components.Add(txtUserName);
		components.Add(classNameMatchRule4);
		components.Add(windowTypeMatchRule3);
		components.Add(classNameMatchRule3);
		components.Add(windowTypeMatchRule2);
		components.Add(Control2);
		components.Add(txtPassword);
		components.Add(classNameMatchRule6);
		components.Add(windowTypeMatchRule5);
		components.Add(classNameMatchRule5);
		components.Add(windowTypeMatchRule4);
		components.Add(Control3);
		components.Add(btnOk);
		components.Add(windowTextMatchRule2);
		components.Add(classNameMatchRule8);
		components.Add(windowTextMatchRule3);
		components.Add(classNameMatchRule7);
		components.Add(windowTypeMatchRule6);
		components.Add(classNameMatchRule2);
		components.Add(windowTypeMatchRule1);
		components.Add(windowTextMatchRule1);
		components.Add(classNameMatchRule1);
		// 
		// Result
		// 
		return Windows_Security;
	}
	
	internal OpenSpan.Adapters.Controls.Control Create_Control1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Control Control1 = new OpenSpan.Adapters.Controls.Control();
		this.SetId(Control1, new OpenSpan.Design.ComponentIdentity("Control-8D5584714C08BE7"));
		OpenSpan.Adapters.Controls.Control Control;
		Control = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control
		// 
		OpenSpan.Adapters.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.Extender = null;
		txtUserName.ExtensibleTypeName = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4;
		classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule4
		// 
		classNameMatchRule4.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3;
		windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule3
		// 
		windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtUserName.MatchRules.Add(classNameMatchRule4);
		txtUserName.MatchRules.Add(windowTypeMatchRule3);
		txtUserName.Name = "txtUserName";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control.Controls.Add(txtUserName);
		Control.Extender = null;
		Control.ExtensibleTypeName = null;
		Control.ForwardObjectExplorerEvent = true;
		Control.MatchingIndex = 6;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule3;
		classNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule3
		// 
		classNameMatchRule3.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule2;
		windowTypeMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule2
		// 
		windowTypeMatchRule2.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control.MatchRules.Add(classNameMatchRule3);
		Control.MatchRules.Add(windowTypeMatchRule2);
		Control.Name = "Control";
		Control.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		OpenSpan.Adapters.Controls.Control Control2;
		Control2 = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control2
		// 
		OpenSpan.Adapters.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.Extender = null;
		txtPassword.ExtensibleTypeName = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6;
		classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule6
		// 
		classNameMatchRule6.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5;
		windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule5
		// 
		windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtPassword.MatchRules.Add(classNameMatchRule6);
		txtPassword.MatchRules.Add(windowTypeMatchRule5);
		txtPassword.Name = "txtPassword";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control2.Controls.Add(txtPassword);
		Control2.Extender = null;
		Control2.ExtensibleTypeName = null;
		Control2.ForwardObjectExplorerEvent = true;
		Control2.MatchingIndex = 7;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule5;
		classNameMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule5
		// 
		classNameMatchRule5.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule4;
		windowTypeMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule4
		// 
		windowTypeMatchRule4.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control2.MatchRules.Add(classNameMatchRule5);
		Control2.MatchRules.Add(windowTypeMatchRule4);
		Control2.Name = "Control2";
		Control2.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		OpenSpan.Adapters.Controls.Control Control3;
		Control3 = new OpenSpan.Adapters.Controls.Control();
		// 
		// Control3
		// 
		OpenSpan.Adapters.Controls.Button btnOk;
		btnOk = new OpenSpan.Adapters.Controls.Button();
		// 
		// btnOk
		// 
		btnOk.Extender = null;
		btnOk.ExtensibleTypeName = null;
		btnOk.ForwardObjectExplorerEvent = true;
		btnOk.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2;
		windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule2.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8;
		classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule8
		// 
		classNameMatchRule8.ClassName = "Button";
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3;
		windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "OK";
		windowTextMatchRule3.Text = textmatchdata2;
		btnOk.MatchRules.Add(windowTextMatchRule2);
		btnOk.MatchRules.Add(classNameMatchRule8);
		btnOk.MatchRules.Add(windowTextMatchRule3);
		btnOk.Name = "btnOk";
		btnOk.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows";
		Control3.Controls.Add(btnOk);
		Control3.Extender = null;
		Control3.ExtensibleTypeName = null;
		Control3.ForwardObjectExplorerEvent = true;
		Control3.MatchingIndex = 2;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule7;
		classNameMatchRule7 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule7
		// 
		classNameMatchRule7.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule6;
		windowTypeMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule6
		// 
		windowTypeMatchRule6.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control3.MatchRules.Add(classNameMatchRule7);
		Control3.MatchRules.Add(windowTypeMatchRule6);
		Control3.Name = "Control3";
		Control3.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		Control1.Controls.Add(Control);
		Control1.Controls.Add(Control2);
		Control1.Controls.Add(Control3);
		Control1.Extender = null;
		Control1.ExtensibleTypeName = null;
		Control1.ForwardObjectExplorerEvent = true;
		Control1.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule2;
		classNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule2
		// 
		classNameMatchRule2.ClassName = "DirectUIHWND";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule1;
		windowTypeMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule1
		// 
		windowTypeMatchRule1.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control1.MatchRules.Add(classNameMatchRule2);
		Control1.MatchRules.Add(windowTypeMatchRule1);
		Control1.Name = "Control1";
		Control1.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(Control, new OpenSpan.Design.ComponentIdentity("Control-8D5584714BE2E50"));
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584714B9D4CF"));
		this.SetId(classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		this.SetId(windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		this.SetId(classNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E84DB8"));
		this.SetId(windowTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714EA49A2"));
		this.SetId(Control2, new OpenSpan.Design.ComponentIdentity("Control-8D55847168B2A31"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584716898FF4"));
		this.SetId(classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		this.SetId(windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		this.SetId(classNameMatchRule5, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847168D39A4"));
		this.SetId(windowTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584716900C71"));
		this.SetId(Control3, new OpenSpan.Design.ComponentIdentity("Control-8D558471845877E"));
		this.SetId(btnOk, new OpenSpan.Design.ComponentIdentity("Button-8D5584718417C21"));
		this.SetId(windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		this.SetId(classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		this.SetId(windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		this.SetId(classNameMatchRule7, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584718485A4B"));
		this.SetId(windowTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D55847184A42AC"));
		this.SetId(classNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E3B99C"));
		this.SetId(windowTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714E5C90F"));
		// 
		// Add components
		// 
		components.Add(Control);
		components.Add(txtUserName);
		components.Add(classNameMatchRule4);
		components.Add(windowTypeMatchRule3);
		components.Add(classNameMatchRule3);
		components.Add(windowTypeMatchRule2);
		components.Add(Control2);
		components.Add(txtPassword);
		components.Add(classNameMatchRule6);
		components.Add(windowTypeMatchRule5);
		components.Add(classNameMatchRule5);
		components.Add(windowTypeMatchRule4);
		components.Add(Control3);
		components.Add(btnOk);
		components.Add(windowTextMatchRule2);
		components.Add(classNameMatchRule8);
		components.Add(windowTextMatchRule3);
		components.Add(classNameMatchRule7);
		components.Add(windowTypeMatchRule6);
		components.Add(classNameMatchRule2);
		components.Add(windowTypeMatchRule1);
		// 
		// Result
		// 
		return Control1;
	}
	
	internal OpenSpan.Adapters.Controls.Control Create_Control(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Control Control = new OpenSpan.Adapters.Controls.Control();
		this.SetId(Control, new OpenSpan.Design.ComponentIdentity("Control-8D5584714BE2E50"));
		OpenSpan.Adapters.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.Extender = null;
		txtUserName.ExtensibleTypeName = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4;
		classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule4
		// 
		classNameMatchRule4.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3;
		windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule3
		// 
		windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtUserName.MatchRules.Add(classNameMatchRule4);
		txtUserName.MatchRules.Add(windowTypeMatchRule3);
		txtUserName.Name = "txtUserName";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control.Controls.Add(txtUserName);
		Control.Extender = null;
		Control.ExtensibleTypeName = null;
		Control.ForwardObjectExplorerEvent = true;
		Control.MatchingIndex = 6;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule3;
		classNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule3
		// 
		classNameMatchRule3.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule2;
		windowTypeMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule2
		// 
		windowTypeMatchRule2.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control.MatchRules.Add(classNameMatchRule3);
		Control.MatchRules.Add(windowTypeMatchRule2);
		Control.Name = "Control";
		Control.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584714B9D4CF"));
		this.SetId(classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		this.SetId(windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		this.SetId(classNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E84DB8"));
		this.SetId(windowTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714EA49A2"));
		// 
		// Add components
		// 
		components.Add(txtUserName);
		components.Add(classNameMatchRule4);
		components.Add(windowTypeMatchRule3);
		components.Add(classNameMatchRule3);
		components.Add(windowTypeMatchRule2);
		// 
		// Result
		// 
		return Control;
	}
	
	internal OpenSpan.Adapters.Controls.TextBox Create_txtUserName(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.TextBox txtUserName = new OpenSpan.Adapters.Controls.TextBox();
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584714B9D4CF"));
		txtUserName.Extender = null;
		txtUserName.ExtensibleTypeName = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4;
		classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule4
		// 
		classNameMatchRule4.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3;
		windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule3
		// 
		windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtUserName.MatchRules.Add(classNameMatchRule4);
		txtUserName.MatchRules.Add(windowTypeMatchRule3);
		txtUserName.Name = "txtUserName";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		this.SetId(windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		// 
		// Add components
		// 
		components.Add(classNameMatchRule4);
		components.Add(windowTypeMatchRule3);
		// 
		// Result
		// 
		return txtUserName;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule4, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714ED7E1C"));
		classNameMatchRule4.ClassName = "Edit";
		// 
		// Result
		// 
		return classNameMatchRule4;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714F002C5"));
		windowTypeMatchRule3.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule3;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E84DB8"));
		classNameMatchRule3.ClassName = "CtrlNotifySink";
		// 
		// Result
		// 
		return classNameMatchRule3;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714EA49A2"));
		windowTypeMatchRule2.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule2;
	}
	
	internal OpenSpan.Adapters.Controls.Control Create_Control2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Control Control2 = new OpenSpan.Adapters.Controls.Control();
		this.SetId(Control2, new OpenSpan.Design.ComponentIdentity("Control-8D55847168B2A31"));
		OpenSpan.Adapters.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.Extender = null;
		txtPassword.ExtensibleTypeName = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6;
		classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule6
		// 
		classNameMatchRule6.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5;
		windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule5
		// 
		windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtPassword.MatchRules.Add(classNameMatchRule6);
		txtPassword.MatchRules.Add(windowTypeMatchRule5);
		txtPassword.Name = "txtPassword";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		Control2.Controls.Add(txtPassword);
		Control2.Extender = null;
		Control2.ExtensibleTypeName = null;
		Control2.ForwardObjectExplorerEvent = true;
		Control2.MatchingIndex = 7;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule5;
		classNameMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule5
		// 
		classNameMatchRule5.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule4;
		windowTypeMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule4
		// 
		windowTypeMatchRule4.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control2.MatchRules.Add(classNameMatchRule5);
		Control2.MatchRules.Add(windowTypeMatchRule4);
		Control2.Name = "Control2";
		Control2.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584716898FF4"));
		this.SetId(classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		this.SetId(windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		this.SetId(classNameMatchRule5, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847168D39A4"));
		this.SetId(windowTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584716900C71"));
		// 
		// Add components
		// 
		components.Add(txtPassword);
		components.Add(classNameMatchRule6);
		components.Add(windowTypeMatchRule5);
		components.Add(classNameMatchRule5);
		components.Add(windowTypeMatchRule4);
		// 
		// Result
		// 
		return Control2;
	}
	
	internal OpenSpan.Adapters.Controls.TextBox Create_txtPassword(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.TextBox txtPassword = new OpenSpan.Adapters.Controls.TextBox();
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584716898FF4"));
		txtPassword.Extender = null;
		txtPassword.ExtensibleTypeName = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6;
		classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule6
		// 
		classNameMatchRule6.ClassName = "Edit";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5;
		windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule5
		// 
		windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		txtPassword.MatchRules.Add(classNameMatchRule6);
		txtPassword.MatchRules.Add(windowTypeMatchRule5);
		txtPassword.Name = "txtPassword";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		this.SetId(windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		// 
		// Add components
		// 
		components.Add(classNameMatchRule6);
		components.Add(windowTypeMatchRule5);
		// 
		// Result
		// 
		return txtPassword;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule6, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584716926A08"));
		classNameMatchRule6.ClassName = "Edit";
		// 
		// Result
		// 
		return classNameMatchRule6;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D558471694797B"));
		windowTypeMatchRule5.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule5;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule5 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule5, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847168D39A4"));
		classNameMatchRule5.ClassName = "CtrlNotifySink";
		// 
		// Result
		// 
		return classNameMatchRule5;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule4 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584716900C71"));
		windowTypeMatchRule4.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule4;
	}
	
	internal OpenSpan.Adapters.Controls.Control Create_Control3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Control Control3 = new OpenSpan.Adapters.Controls.Control();
		this.SetId(Control3, new OpenSpan.Design.ComponentIdentity("Control-8D558471845877E"));
		OpenSpan.Adapters.Controls.Button btnOk;
		btnOk = new OpenSpan.Adapters.Controls.Button();
		// 
		// btnOk
		// 
		btnOk.Extender = null;
		btnOk.ExtensibleTypeName = null;
		btnOk.ForwardObjectExplorerEvent = true;
		btnOk.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2;
		windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule2.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8;
		classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule8
		// 
		classNameMatchRule8.ClassName = "Button";
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3;
		windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "OK";
		windowTextMatchRule3.Text = textmatchdata2;
		btnOk.MatchRules.Add(windowTextMatchRule2);
		btnOk.MatchRules.Add(classNameMatchRule8);
		btnOk.MatchRules.Add(windowTextMatchRule3);
		btnOk.Name = "btnOk";
		btnOk.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows";
		Control3.Controls.Add(btnOk);
		Control3.Extender = null;
		Control3.ExtensibleTypeName = null;
		Control3.ForwardObjectExplorerEvent = true;
		Control3.MatchingIndex = 2;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule7;
		classNameMatchRule7 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule7
		// 
		classNameMatchRule7.ClassName = "CtrlNotifySink";
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule6;
		windowTypeMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		// 
		// windowTypeMatchRule6
		// 
		windowTypeMatchRule6.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		Control3.MatchRules.Add(classNameMatchRule7);
		Control3.MatchRules.Add(windowTypeMatchRule6);
		Control3.Name = "Control3";
		Control3.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(btnOk, new OpenSpan.Design.ComponentIdentity("Button-8D5584718417C21"));
		this.SetId(windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		this.SetId(classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		this.SetId(windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		this.SetId(classNameMatchRule7, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584718485A4B"));
		this.SetId(windowTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D55847184A42AC"));
		// 
		// Add components
		// 
		components.Add(btnOk);
		components.Add(windowTextMatchRule2);
		components.Add(classNameMatchRule8);
		components.Add(windowTextMatchRule3);
		components.Add(classNameMatchRule7);
		components.Add(windowTypeMatchRule6);
		// 
		// Result
		// 
		return Control3;
	}
	
	internal OpenSpan.Adapters.Controls.Button Create_btnOk(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Controls.Button btnOk = new OpenSpan.Adapters.Controls.Button();
		this.SetId(btnOk, new OpenSpan.Design.ComponentIdentity("Button-8D5584718417C21"));
		btnOk.Extender = null;
		btnOk.ExtensibleTypeName = null;
		btnOk.ForwardObjectExplorerEvent = true;
		btnOk.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2;
		windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule2.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8;
		classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		// 
		// classNameMatchRule8
		// 
		classNameMatchRule8.ClassName = "Button";
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3;
		windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		// 
		// windowTextMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "OK";
		windowTextMatchRule3.Text = textmatchdata2;
		btnOk.MatchRules.Add(windowTextMatchRule2);
		btnOk.MatchRules.Add(classNameMatchRule8);
		btnOk.MatchRules.Add(windowTextMatchRule3);
		btnOk.Name = "btnOk";
		btnOk.TargetTypeString = "OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows";
		// 
		// Set designComp Ids
		// 
		this.SetId(windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		this.SetId(classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		this.SetId(windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		// 
		// Add components
		// 
		components.Add(windowTextMatchRule2);
		components.Add(classNameMatchRule8);
		components.Add(windowTextMatchRule3);
		// 
		// Result
		// 
		return btnOk;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Create_windowTextMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.SetId(windowTextMatchRule2, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D55847184CB3CC"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return windowTextMatchRule2;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule8(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule8 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule8, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D55847184ED6C8"));
		classNameMatchRule8.ClassName = "Button";
		// 
		// Result
		// 
		return classNameMatchRule8;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Create_windowTextMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.SetId(windowTextMatchRule3, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D558471850E63B"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "OK";
		windowTextMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return windowTextMatchRule3;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule7(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule7 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule7, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584718485A4B"));
		classNameMatchRule7.ClassName = "CtrlNotifySink";
		// 
		// Result
		// 
		return classNameMatchRule7;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule6 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D55847184A42AC"));
		windowTypeMatchRule6.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule6;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714E3B99C"));
		classNameMatchRule2.ClassName = "DirectUIHWND";
		// 
		// Result
		// 
		return classNameMatchRule2;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Create_windowTypeMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule windowTypeMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule();
		this.SetId(windowTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTypeMatchRule-8D5584714E5C90F"));
		windowTypeMatchRule1.Type = OpenSpan.Adapters.Windows.WindowType.Child;
		// 
		// Result
		// 
		return windowTypeMatchRule1;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Create_windowTextMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule windowTextMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule();
		this.SetId(windowTextMatchRule1, new OpenSpan.Design.ComponentIdentity("WindowTextMatchRule-8D5584714C4220E"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Windows Security";
		windowTextMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return windowTextMatchRule1;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Create_classNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule classNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule();
		this.SetId(classNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ClassNameMatchRule-8D5584714D512DC"));
		classNameMatchRule1.ClassName = "#32770";
		// 
		// Result
		// 
		return classNameMatchRule1;
	}
}

}

