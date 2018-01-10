using System;

namespace PegaDevWebProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WebAdapter-8D558467FE3C125
[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class PegaDevLab5127 : OpenSpan.Adapters.Web.WebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\ActiveXFactory-8D558468A88736F")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\WinInetFactory-8D558468B3F49AB")]
	public OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\MicrosoftHTMLFactory-8D558468B767596")]
	public OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\WebPage-8D5584692C8C418")]
	public OpenSpan.Adapters.Web.Controls.WebPage Pega_7;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\Form-8D5584692C408EA")]
	public OpenSpan.Adapters.Web.Controls.Form main;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\TextBox-8D5584692BD2AC0")]
	public OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\TextBox-8D55846948851C9")]
	public OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D558467FE3C125\\BasicButton-8D5584695F43CF2")]
	public OpenSpan.Adapters.Web.Controls.BasicButton btnLogIn;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
	
	private OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule formNameMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
	
	public PegaDevLab5127()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(PegaDevLab5127));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata10 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata11 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata12 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.ApplicationFramework.AssistedSignOn.Credential credential1 = new OpenSpan.ApplicationFramework.AssistedSignOn.Credential();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.Pega_7 = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.main = new OpenSpan.Adapters.Web.Controls.Form();
		this.txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.btnLogIn = new OpenSpan.Adapters.Web.Controls.BasicButton();
		this.elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.formNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule();
		this.documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WebAdapter-8D558467FE3C125");
		// 
		// Set component Ids
		// 
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D558468A88736F"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468A8D904A"));
		this.SetId(this.WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D558468B3F49AB"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B43A32C"));
		this.SetId(this.MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D558468B767596"));
		this.SetId(this.moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B7DB56D"));
		this.SetId(this.Pega_7, new OpenSpan.Design.ComponentIdentity("WebPage-8D5584692C8C418"));
		this.SetId(this.main, new OpenSpan.Design.ComponentIdentity("Form-8D5584692C408EA"));
		this.SetId(this.txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584692BD2AC0"));
		this.SetId(this.inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D5584692E0E134"));
		this.SetId(this.elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584692EB1AEA"));
		this.SetId(this.txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D55846948851C9"));
		this.SetId(this.inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558469498B9D8"));
		this.SetId(this.elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D55846949E8684"));
		this.SetId(this.btnLogIn, new OpenSpan.Design.ComponentIdentity("BasicButton-8D5584695F43CF2"));
		this.SetId(this.elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584695FB2EA5"));
		this.SetId(this.formNameMatchRule1, new OpenSpan.Design.ComponentIdentity("FormNameMatchRule-8D5584692D9EF81"));
		this.SetId(this.documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584692CF05FA"));
		this.SetId(this.documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584692D33869"));
		// 
		// PegaDevLab5127
		// 
		this.AddressBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_PegaDevLab5127_1_");
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
		// Pega_7
		// 
		// 
		// main
		// 
		// 
		// txtUserName
		// 
		this.txtUserName.ElementId = "txtUserID";
		this.txtUserName.Extender = null;
		this.txtUserName.ForwardObjectExplorerEvent = true;
		this.txtUserName.MatchingIndex = 1;
		// 
		// inputTypeMatchRule1
		// 
		this.inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// elementIdMatchRule1
		// 
		textmatchdata4.Text = "txtUserID";
		this.elementIdMatchRule1.Text = textmatchdata4;
		this.txtUserName.MatchRules.Add(this.inputTypeMatchRule1);
		this.txtUserName.MatchRules.Add(this.elementIdMatchRule1);
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.TagName = "INPUT";
		this.txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		this.txtUserName.UseElementId = true;
		// 
		// txtPassword
		// 
		this.txtPassword.ElementId = "txtPassword";
		this.txtPassword.Extender = null;
		this.txtPassword.ForwardObjectExplorerEvent = true;
		this.txtPassword.MatchingIndex = 2;
		// 
		// inputTypeMatchRule2
		// 
		this.inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// elementIdMatchRule2
		// 
		textmatchdata5.Text = "txtPassword";
		this.elementIdMatchRule2.Text = textmatchdata5;
		this.txtPassword.MatchRules.Add(this.inputTypeMatchRule2);
		this.txtPassword.MatchRules.Add(this.elementIdMatchRule2);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.TagName = "INPUT";
		this.txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		this.txtPassword.UseElementId = true;
		// 
		// btnLogIn
		// 
		this.btnLogIn.ElementId = "sub";
		this.btnLogIn.Extender = null;
		this.btnLogIn.ForwardObjectExplorerEvent = true;
		this.btnLogIn.MatchingIndex = 0;
		// 
		// elementIdMatchRule3
		// 
		textmatchdata6.Text = "sub";
		this.elementIdMatchRule3.Text = textmatchdata6;
		this.btnLogIn.MatchRules.Add(this.elementIdMatchRule3);
		this.btnLogIn.Name = "btnLogIn";
		this.btnLogIn.TagName = "BUTTON";
		this.btnLogIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlButtonElement, OpenSpan.Adapters.Web";
		this.btnLogIn.UseElementId = true;
		this.main.Controls.Add(this.txtUserName);
		this.main.Controls.Add(this.txtPassword);
		this.main.Controls.Add(this.btnLogIn);
		this.main.ElementId = null;
		this.main.Extender = null;
		this.main.ForwardObjectExplorerEvent = true;
		this.main.MatchingIndex = 0;
		// 
		// formNameMatchRule1
		// 
		this.formNameMatchRule1.HtmlName = "main";
		this.main.MatchRules.Add(this.formNameMatchRule1);
		this.main.Name = "main";
		this.main.TagName = "FORM";
		this.main.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		this.main.UseElementId = false;
		this.Pega_7.Controls.Add(this.main);
		this.Pega_7.Extender = null;
		this.Pega_7.ForwardObjectExplorerEvent = true;
		this.Pega_7.IsGlobal = true;
		this.Pega_7.MatchingIndex = 0;
		// 
		// documentUrlMatchRule1
		// 
		this.documentUrlMatchRule1.Fragment = textmatchdata7;
		textmatchdata8.Text = "lab5127.lab.pega.com";
		this.documentUrlMatchRule1.Host = textmatchdata8;
		textmatchdata9.Text = "/prweb/PRServlet/beEBp4uRVTogorRwSwWqbOtn9IL2fwdI*/!STANDARD";
		this.documentUrlMatchRule1.Path = textmatchdata9;
		this.documentUrlMatchRule1.Port = 443;
		this.documentUrlMatchRule1.Query = textmatchdata10;
		textmatchdata11.Text = "https";
		this.documentUrlMatchRule1.Scheme = textmatchdata11;
		// 
		// documentTitleMatchRule1
		// 
		textmatchdata12.Text = "Pega 7";
		this.documentTitleMatchRule1.Text = textmatchdata12;
		this.Pega_7.MatchRules.Add(this.documentUrlMatchRule1);
		this.Pega_7.MatchRules.Add(this.documentTitleMatchRule1);
		this.Pega_7.Name = "Pega_7";
		this.Pega_7.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		this.Controls.Add(this.ActiveXFactory);
		this.Controls.Add(this.WinInetFactory);
		this.Controls.Add(this.MicrosoftHTMLFactory);
		this.Controls.Add(this.Pega_7);
		credential1.ApplicationKey = "PegaDevLab5127";
		credential1.Category = null;
		credential1.Group = null;
		credential1.LoginControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D558467FE3C125\\BasicButton-8D5584695F43CF2");
		credential1.PasswordControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D558467FE3C125\\TextBox-8D55846948851C9");
		credential1.UserNameControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D558467FE3C125\\TextBox-8D5584692BD2AC0");
		this.Credentials.Add(credential1);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "PegaDevLab5127";
		this.MenuBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.Name = "PegaDevLab5127";
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.Automatic;
		this.StartOnProjectStart = false;
		this.StartPage = "lab5127.lab.pega.com/prweb/PRServlet";
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
		this.Components.Add(this.Pega_7);
		this.Components.Add(this.main);
		this.Components.Add(this.txtUserName);
		this.Components.Add(this.inputTypeMatchRule1);
		this.Components.Add(this.elementIdMatchRule1);
		this.Components.Add(this.txtPassword);
		this.Components.Add(this.inputTypeMatchRule2);
		this.Components.Add(this.elementIdMatchRule2);
		this.Components.Add(this.btnLogIn);
		this.Components.Add(this.elementIdMatchRule3);
		this.Components.Add(this.formNameMatchRule1);
		this.Components.Add(this.documentUrlMatchRule1);
		this.Components.Add(this.documentTitleMatchRule1);
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
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D558468A88736F"));
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
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468A8D904A"));
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
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468A8D904A"));
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
		this.SetId(WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D558468B3F49AB"));
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
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B43A32C"));
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
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B43A32C"));
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
		this.SetId(MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D558468B767596"));
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
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B7DB56D"));
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
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D558468B7DB56D"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_Pega_7(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage Pega_7 = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(Pega_7, new OpenSpan.Design.ComponentIdentity("WebPage-8D5584692C8C418"));
		OpenSpan.Adapters.Web.Controls.Form main;
		main = new OpenSpan.Adapters.Web.Controls.Form();
		// 
		// main
		// 
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.ElementId = "txtUserID";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtUserID";
		elementIdMatchRule1.Text = textmatchdata1;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule1);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.ElementId = "txtPassword";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "txtPassword";
		elementIdMatchRule2.Text = textmatchdata2;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule2);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.BasicButton btnLogIn;
		btnLogIn = new OpenSpan.Adapters.Web.Controls.BasicButton();
		// 
		// btnLogIn
		// 
		btnLogIn.ElementId = "sub";
		btnLogIn.Extender = null;
		btnLogIn.ForwardObjectExplorerEvent = true;
		btnLogIn.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "sub";
		elementIdMatchRule3.Text = textmatchdata3;
		btnLogIn.MatchRules.Add(elementIdMatchRule3);
		btnLogIn.Name = "btnLogIn";
		btnLogIn.TagName = "BUTTON";
		btnLogIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlButtonElement, OpenSpan.Adapters.Web";
		btnLogIn.UseElementId = true;
		main.Controls.Add(txtUserName);
		main.Controls.Add(txtPassword);
		main.Controls.Add(btnLogIn);
		main.ElementId = null;
		main.Extender = null;
		main.ForwardObjectExplorerEvent = true;
		main.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule formNameMatchRule1;
		formNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule();
		// 
		// formNameMatchRule1
		// 
		formNameMatchRule1.HtmlName = "main";
		main.MatchRules.Add(formNameMatchRule1);
		main.Name = "main";
		main.TagName = "FORM";
		main.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		main.UseElementId = false;
		Pega_7.Controls.Add(main);
		Pega_7.Extender = null;
		Pega_7.ForwardObjectExplorerEvent = true;
		Pega_7.IsGlobal = true;
		Pega_7.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
		documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "lab5127.lab.pega.com";
		documentUrlMatchRule1.Host = textmatchdata5;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "/prweb/PRServlet/beEBp4uRVTogorRwSwWqbOtn9IL2fwdI*/!STANDARD";
		documentUrlMatchRule1.Path = textmatchdata6;
		documentUrlMatchRule1.Port = 443;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata7;
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata8.Text = "https";
		documentUrlMatchRule1.Scheme = textmatchdata8;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
		documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata9.Text = "Pega 7";
		documentTitleMatchRule1.Text = textmatchdata9;
		Pega_7.MatchRules.Add(documentUrlMatchRule1);
		Pega_7.MatchRules.Add(documentTitleMatchRule1);
		Pega_7.Name = "Pega_7";
		Pega_7.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(main, new OpenSpan.Design.ComponentIdentity("Form-8D5584692C408EA"));
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584692BD2AC0"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D5584692E0E134"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584692EB1AEA"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D55846948851C9"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558469498B9D8"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D55846949E8684"));
		this.SetId(btnLogIn, new OpenSpan.Design.ComponentIdentity("BasicButton-8D5584695F43CF2"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584695FB2EA5"));
		this.SetId(formNameMatchRule1, new OpenSpan.Design.ComponentIdentity("FormNameMatchRule-8D5584692D9EF81"));
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584692CF05FA"));
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584692D33869"));
		// 
		// Add components
		// 
		components.Add(main);
		components.Add(txtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule1);
		components.Add(txtPassword);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule2);
		components.Add(btnLogIn);
		components.Add(elementIdMatchRule3);
		components.Add(formNameMatchRule1);
		components.Add(documentUrlMatchRule1);
		components.Add(documentTitleMatchRule1);
		// 
		// Result
		// 
		return Pega_7;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Form Create_main(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Form main = new OpenSpan.Adapters.Web.Controls.Form();
		this.SetId(main, new OpenSpan.Design.ComponentIdentity("Form-8D5584692C408EA"));
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.ElementId = "txtUserID";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtUserID";
		elementIdMatchRule1.Text = textmatchdata1;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule1);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.ElementId = "txtPassword";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "txtPassword";
		elementIdMatchRule2.Text = textmatchdata2;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule2);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.BasicButton btnLogIn;
		btnLogIn = new OpenSpan.Adapters.Web.Controls.BasicButton();
		// 
		// btnLogIn
		// 
		btnLogIn.ElementId = "sub";
		btnLogIn.Extender = null;
		btnLogIn.ForwardObjectExplorerEvent = true;
		btnLogIn.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "sub";
		elementIdMatchRule3.Text = textmatchdata3;
		btnLogIn.MatchRules.Add(elementIdMatchRule3);
		btnLogIn.Name = "btnLogIn";
		btnLogIn.TagName = "BUTTON";
		btnLogIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlButtonElement, OpenSpan.Adapters.Web";
		btnLogIn.UseElementId = true;
		main.Controls.Add(txtUserName);
		main.Controls.Add(txtPassword);
		main.Controls.Add(btnLogIn);
		main.ElementId = null;
		main.Extender = null;
		main.ForwardObjectExplorerEvent = true;
		main.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule formNameMatchRule1;
		formNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule();
		// 
		// formNameMatchRule1
		// 
		formNameMatchRule1.HtmlName = "main";
		main.MatchRules.Add(formNameMatchRule1);
		main.Name = "main";
		main.TagName = "FORM";
		main.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		main.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584692BD2AC0"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D5584692E0E134"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584692EB1AEA"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D55846948851C9"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558469498B9D8"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D55846949E8684"));
		this.SetId(btnLogIn, new OpenSpan.Design.ComponentIdentity("BasicButton-8D5584695F43CF2"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584695FB2EA5"));
		this.SetId(formNameMatchRule1, new OpenSpan.Design.ComponentIdentity("FormNameMatchRule-8D5584692D9EF81"));
		// 
		// Add components
		// 
		components.Add(txtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule1);
		components.Add(txtPassword);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule2);
		components.Add(btnLogIn);
		components.Add(elementIdMatchRule3);
		components.Add(formNameMatchRule1);
		// 
		// Result
		// 
		return main;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_txtUserName(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D5584692BD2AC0"));
		txtUserName.ElementId = "txtUserID";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtUserID";
		elementIdMatchRule1.Text = textmatchdata1;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule1);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D5584692E0E134"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584692EB1AEA"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule1);
		// 
		// Result
		// 
		return txtUserName;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D5584692E0E134"));
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// Result
		// 
		return inputTypeMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584692EB1AEA"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtUserID";
		elementIdMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_txtPassword(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D55846948851C9"));
		txtPassword.ElementId = "txtPassword";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtPassword";
		elementIdMatchRule2.Text = textmatchdata1;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule2);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558469498B9D8"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D55846949E8684"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule2);
		// 
		// Result
		// 
		return txtPassword;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558469498B9D8"));
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// Result
		// 
		return inputTypeMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D55846949E8684"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtPassword";
		elementIdMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.Controls.BasicButton Create_btnLogIn(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.BasicButton btnLogIn = new OpenSpan.Adapters.Web.Controls.BasicButton();
		this.SetId(btnLogIn, new OpenSpan.Design.ComponentIdentity("BasicButton-8D5584695F43CF2"));
		btnLogIn.ElementId = "sub";
		btnLogIn.Extender = null;
		btnLogIn.ForwardObjectExplorerEvent = true;
		btnLogIn.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "sub";
		elementIdMatchRule3.Text = textmatchdata1;
		btnLogIn.MatchRules.Add(elementIdMatchRule3);
		btnLogIn.Name = "btnLogIn";
		btnLogIn.TagName = "BUTTON";
		btnLogIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlButtonElement, OpenSpan.Adapters.Web";
		btnLogIn.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584695FB2EA5"));
		// 
		// Add components
		// 
		components.Add(elementIdMatchRule3);
		// 
		// Result
		// 
		return btnLogIn;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D5584695FB2EA5"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "sub";
		elementIdMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule Create_formNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule formNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule();
		this.SetId(formNameMatchRule1, new OpenSpan.Design.ComponentIdentity("FormNameMatchRule-8D5584692D9EF81"));
		formNameMatchRule1.HtmlName = "main";
		// 
		// Result
		// 
		return formNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584692CF05FA"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "lab5127.lab.pega.com";
		documentUrlMatchRule1.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/prweb/PRServlet/beEBp4uRVTogorRwSwWqbOtn9IL2fwdI*/!STANDARD";
		documentUrlMatchRule1.Path = textmatchdata3;
		documentUrlMatchRule1.Port = 443;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "https";
		documentUrlMatchRule1.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return documentUrlMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Create_documentTitleMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584692D33869"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Pega 7";
		documentTitleMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule1;
	}
}

}

