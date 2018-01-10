using System;

namespace GitLabWebProj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WebAdapter-8D55848EDC39C90
[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class GitLab : OpenSpan.Adapters.Web.WebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\ActiveXFactory-8D5584915C7E7A0")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\WinInetFactory-8D55849162C75D0")]
	public OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\MicrosoftHTMLFactory-8D558491646B490")]
	public OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\WebPage-8D5584925CC3F20")]
	public OpenSpan.Adapters.Web.Controls.WebPage pgGitLab;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\Link-8D5584925C699D0")]
	public OpenSpan.Adapters.Web.Controls.Link Standard;
	
	private OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\Form-8D558494C3F62E0")]
	public OpenSpan.Adapters.Web.Controls.Form frmSignIn;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\TextBox-8D558494C3AF610")]
	public OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\TextBox-8D558494D7BDA80")]
	public OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D55848EDC39C90\\Button-8D558494ECE4B20")]
	public OpenSpan.Adapters.Web.Controls.Button btnSignIn;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
	
	private OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
	
	public GitLab()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(GitLab));
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
		OpenSpan.Adapters.TextMatchData textmatchdata13 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata14 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.ApplicationFramework.AssistedSignOn.Credential credential1 = new OpenSpan.ApplicationFramework.AssistedSignOn.Credential();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.pgGitLab = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.Standard = new OpenSpan.Adapters.Web.Controls.Link();
		this.innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		this.frmSignIn = new OpenSpan.Adapters.Web.Controls.Form();
		this.txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.btnSignIn = new OpenSpan.Adapters.Web.Controls.Button();
		this.inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		this.elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WebAdapter-8D55848EDC39C90");
		// 
		// Set component Ids
		// 
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D5584915C7E7A0"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584915CE2930"));
		this.SetId(this.WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D55849162C75D0"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584916321B20"));
		this.SetId(this.MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D558491646B490"));
		this.SetId(this.moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55849164CA800"));
		this.SetId(this.pgGitLab, new OpenSpan.Design.ComponentIdentity("WebPage-8D5584925CC3F20"));
		this.SetId(this.Standard, new OpenSpan.Design.ComponentIdentity("Link-8D5584925C699D0"));
		this.SetId(this.innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D5584925DDCB50"));
		this.SetId(this.frmSignIn, new OpenSpan.Design.ComponentIdentity("Form-8D558494C3F62E0"));
		this.SetId(this.txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494C3AF610"));
		this.SetId(this.inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494C4D4590"));
		this.SetId(this.elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C549890"));
		this.SetId(this.txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494D7BDA80"));
		this.SetId(this.inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494D81F500"));
		this.SetId(this.elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494D879A50"));
		this.SetId(this.btnSignIn, new OpenSpan.Design.ComponentIdentity("Button-8D558494ECE4B20"));
		this.SetId(this.inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494ED465A0"));
		this.SetId(this.inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D558494EDA0AF0"));
		this.SetId(this.elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C475220"));
		this.SetId(this.documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584925D20B80"));
		this.SetId(this.documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584925D65140"));
		// 
		// GitLab
		// 
		this.AddressBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_GitLab_1_");
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
		// pgGitLab
		// 
		// 
		// Standard
		// 
		this.Standard.ElementId = null;
		this.Standard.Extender = null;
		this.Standard.ForwardObjectExplorerEvent = true;
		this.Standard.MatchingIndex = 3;
		// 
		// innerTextMatchRule1
		// 
		textmatchdata4.Text = "Standard";
		this.innerTextMatchRule1.Text = textmatchdata4;
		this.Standard.MatchRules.Add(this.innerTextMatchRule1);
		this.Standard.Name = "Standard";
		this.Standard.TagName = "A";
		this.Standard.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		this.Standard.UseElementId = false;
		// 
		// frmSignIn
		// 
		// 
		// txtUserName
		// 
		this.txtUserName.ElementId = "user_login";
		this.txtUserName.Extender = null;
		this.txtUserName.ForwardObjectExplorerEvent = true;
		this.txtUserName.MatchingIndex = 2;
		// 
		// inputTypeMatchRule1
		// 
		this.inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// elementIdMatchRule2
		// 
		textmatchdata5.Text = "user_login";
		this.elementIdMatchRule2.Text = textmatchdata5;
		this.txtUserName.MatchRules.Add(this.inputTypeMatchRule1);
		this.txtUserName.MatchRules.Add(this.elementIdMatchRule2);
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.TagName = "INPUT";
		this.txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		this.txtUserName.UseElementId = true;
		// 
		// txtPassword
		// 
		this.txtPassword.ElementId = "user_password";
		this.txtPassword.Extender = null;
		this.txtPassword.ForwardObjectExplorerEvent = true;
		this.txtPassword.MatchingIndex = 3;
		// 
		// inputTypeMatchRule2
		// 
		this.inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// elementIdMatchRule3
		// 
		textmatchdata6.Text = "user_password";
		this.elementIdMatchRule3.Text = textmatchdata6;
		this.txtPassword.MatchRules.Add(this.inputTypeMatchRule2);
		this.txtPassword.MatchRules.Add(this.elementIdMatchRule3);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.TagName = "INPUT";
		this.txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		this.txtPassword.UseElementId = true;
		// 
		// btnSignIn
		// 
		this.btnSignIn.ElementId = null;
		this.btnSignIn.Extender = null;
		this.btnSignIn.ForwardObjectExplorerEvent = true;
		this.btnSignIn.MatchingIndex = 6;
		// 
		// inputTypeMatchRule3
		// 
		this.inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// inputNameMatchRule1
		// 
		textmatchdata7.Text = "commit";
		this.inputNameMatchRule1.Text = textmatchdata7;
		this.btnSignIn.MatchRules.Add(this.inputTypeMatchRule3);
		this.btnSignIn.MatchRules.Add(this.inputNameMatchRule1);
		this.btnSignIn.Name = "btnSignIn";
		this.btnSignIn.TagName = "INPUT";
		this.btnSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		this.btnSignIn.UseElementId = false;
		this.frmSignIn.Controls.Add(this.txtUserName);
		this.frmSignIn.Controls.Add(this.txtPassword);
		this.frmSignIn.Controls.Add(this.btnSignIn);
		this.frmSignIn.ElementId = "new_user";
		this.frmSignIn.Extender = null;
		this.frmSignIn.ForwardObjectExplorerEvent = true;
		this.frmSignIn.MatchingIndex = 1;
		// 
		// elementIdMatchRule1
		// 
		textmatchdata8.Text = "new_user";
		this.elementIdMatchRule1.Text = textmatchdata8;
		this.frmSignIn.MatchRules.Add(this.elementIdMatchRule1);
		this.frmSignIn.Name = "frmSignIn";
		this.frmSignIn.TagName = "FORM";
		this.frmSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		this.frmSignIn.UseElementId = true;
		this.pgGitLab.Controls.Add(this.Standard);
		this.pgGitLab.Controls.Add(this.frmSignIn);
		this.pgGitLab.Extender = null;
		this.pgGitLab.ForwardObjectExplorerEvent = true;
		this.pgGitLab.IsGlobal = true;
		this.pgGitLab.MatchingIndex = 1;
		// 
		// documentUrlMatchRule1
		// 
		this.documentUrlMatchRule1.Fragment = textmatchdata9;
		textmatchdata10.Text = "10.0.3.112";
		this.documentUrlMatchRule1.Host = textmatchdata10;
		textmatchdata11.Text = "/users/sign_in";
		this.documentUrlMatchRule1.Path = textmatchdata11;
		this.documentUrlMatchRule1.Port = 80;
		this.documentUrlMatchRule1.Query = textmatchdata12;
		textmatchdata13.Text = "http";
		this.documentUrlMatchRule1.Scheme = textmatchdata13;
		// 
		// documentTitleMatchRule1
		// 
		textmatchdata14.Text = "GitLab";
		this.documentTitleMatchRule1.Text = textmatchdata14;
		this.pgGitLab.MatchRules.Add(this.documentUrlMatchRule1);
		this.pgGitLab.MatchRules.Add(this.documentTitleMatchRule1);
		this.pgGitLab.Name = "pgGitLab";
		this.pgGitLab.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		this.Controls.Add(this.ActiveXFactory);
		this.Controls.Add(this.WinInetFactory);
		this.Controls.Add(this.MicrosoftHTMLFactory);
		this.Controls.Add(this.pgGitLab);
		credential1.ApplicationKey = "GitLab";
		credential1.Category = null;
		credential1.Group = null;
		credential1.LoginControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55848EDC39C90\\Button-8D558494ECE4B20");
		credential1.PasswordControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55848EDC39C90\\TextBox-8D558494D7BDA80");
		credential1.UserNameControl = new OpenSpan.Design.ReferenceIdentity("WebAdapter-8D55848EDC39C90\\TextBox-8D558494C3AF610");
		this.Credentials.Add(credential1);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "GitLab";
		this.MenuBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.Name = "GitLab";
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.Automatic;
		this.StartOnProjectStart = false;
		this.StartPage = "http://10.0.3.112/users/sign_in";
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
		this.Components.Add(this.pgGitLab);
		this.Components.Add(this.Standard);
		this.Components.Add(this.innerTextMatchRule1);
		this.Components.Add(this.frmSignIn);
		this.Components.Add(this.txtUserName);
		this.Components.Add(this.inputTypeMatchRule1);
		this.Components.Add(this.elementIdMatchRule2);
		this.Components.Add(this.txtPassword);
		this.Components.Add(this.inputTypeMatchRule2);
		this.Components.Add(this.elementIdMatchRule3);
		this.Components.Add(this.btnSignIn);
		this.Components.Add(this.inputTypeMatchRule3);
		this.Components.Add(this.inputNameMatchRule1);
		this.Components.Add(this.elementIdMatchRule1);
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
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D5584915C7E7A0"));
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
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584915CE2930"));
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
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584915CE2930"));
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
		this.SetId(WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D55849162C75D0"));
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
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584916321B20"));
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
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D5584916321B20"));
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
		this.SetId(MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D558491646B490"));
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
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55849164CA800"));
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
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D55849164CA800"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_pgGitLab(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage pgGitLab = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(pgGitLab, new OpenSpan.Design.ComponentIdentity("WebPage-8D5584925CC3F20"));
		OpenSpan.Adapters.Web.Controls.Link Standard;
		Standard = new OpenSpan.Adapters.Web.Controls.Link();
		// 
		// Standard
		// 
		Standard.ElementId = null;
		Standard.Extender = null;
		Standard.ForwardObjectExplorerEvent = true;
		Standard.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
		innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		// 
		// innerTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Standard";
		innerTextMatchRule1.Text = textmatchdata1;
		Standard.MatchRules.Add(innerTextMatchRule1);
		Standard.Name = "Standard";
		Standard.TagName = "A";
		Standard.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		Standard.UseElementId = false;
		OpenSpan.Adapters.Web.Controls.Form frmSignIn;
		frmSignIn = new OpenSpan.Adapters.Web.Controls.Form();
		// 
		// frmSignIn
		// 
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.ElementId = "user_login";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "user_login";
		elementIdMatchRule2.Text = textmatchdata2;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule2);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.ElementId = "user_password";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "user_password";
		elementIdMatchRule3.Text = textmatchdata3;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule3);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.Button btnSignIn;
		btnSignIn = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// btnSignIn
		// 
		btnSignIn.ElementId = null;
		btnSignIn.Extender = null;
		btnSignIn.ForwardObjectExplorerEvent = true;
		btnSignIn.MatchingIndex = 6;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "commit";
		inputNameMatchRule1.Text = textmatchdata4;
		btnSignIn.MatchRules.Add(inputTypeMatchRule3);
		btnSignIn.MatchRules.Add(inputNameMatchRule1);
		btnSignIn.Name = "btnSignIn";
		btnSignIn.TagName = "INPUT";
		btnSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		btnSignIn.UseElementId = false;
		frmSignIn.Controls.Add(txtUserName);
		frmSignIn.Controls.Add(txtPassword);
		frmSignIn.Controls.Add(btnSignIn);
		frmSignIn.ElementId = "new_user";
		frmSignIn.Extender = null;
		frmSignIn.ForwardObjectExplorerEvent = true;
		frmSignIn.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "new_user";
		elementIdMatchRule1.Text = textmatchdata5;
		frmSignIn.MatchRules.Add(elementIdMatchRule1);
		frmSignIn.Name = "frmSignIn";
		frmSignIn.TagName = "FORM";
		frmSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		frmSignIn.UseElementId = true;
		pgGitLab.Controls.Add(Standard);
		pgGitLab.Controls.Add(frmSignIn);
		pgGitLab.Extender = null;
		pgGitLab.ForwardObjectExplorerEvent = true;
		pgGitLab.IsGlobal = true;
		pgGitLab.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
		documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata6;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "10.0.3.112";
		documentUrlMatchRule1.Host = textmatchdata7;
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata8.Text = "/users/sign_in";
		documentUrlMatchRule1.Path = textmatchdata8;
		documentUrlMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata9;
		OpenSpan.Adapters.TextMatchData textmatchdata10 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata10.Text = "http";
		documentUrlMatchRule1.Scheme = textmatchdata10;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
		documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata11 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata11.Text = "GitLab";
		documentTitleMatchRule1.Text = textmatchdata11;
		pgGitLab.MatchRules.Add(documentUrlMatchRule1);
		pgGitLab.MatchRules.Add(documentTitleMatchRule1);
		pgGitLab.Name = "pgGitLab";
		pgGitLab.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(Standard, new OpenSpan.Design.ComponentIdentity("Link-8D5584925C699D0"));
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D5584925DDCB50"));
		this.SetId(frmSignIn, new OpenSpan.Design.ComponentIdentity("Form-8D558494C3F62E0"));
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494C3AF610"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494C4D4590"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C549890"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494D7BDA80"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494D81F500"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494D879A50"));
		this.SetId(btnSignIn, new OpenSpan.Design.ComponentIdentity("Button-8D558494ECE4B20"));
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494ED465A0"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D558494EDA0AF0"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C475220"));
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584925D20B80"));
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584925D65140"));
		// 
		// Add components
		// 
		components.Add(Standard);
		components.Add(innerTextMatchRule1);
		components.Add(frmSignIn);
		components.Add(txtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule2);
		components.Add(txtPassword);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		components.Add(btnSignIn);
		components.Add(inputTypeMatchRule3);
		components.Add(inputNameMatchRule1);
		components.Add(elementIdMatchRule1);
		components.Add(documentUrlMatchRule1);
		components.Add(documentTitleMatchRule1);
		// 
		// Result
		// 
		return pgGitLab;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Link Create_Standard(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Link Standard = new OpenSpan.Adapters.Web.Controls.Link();
		this.SetId(Standard, new OpenSpan.Design.ComponentIdentity("Link-8D5584925C699D0"));
		Standard.ElementId = null;
		Standard.Extender = null;
		Standard.ForwardObjectExplorerEvent = true;
		Standard.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
		innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		// 
		// innerTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Standard";
		innerTextMatchRule1.Text = textmatchdata1;
		Standard.MatchRules.Add(innerTextMatchRule1);
		Standard.Name = "Standard";
		Standard.TagName = "A";
		Standard.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		Standard.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D5584925DDCB50"));
		// 
		// Add components
		// 
		components.Add(innerTextMatchRule1);
		// 
		// Result
		// 
		return Standard;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule Create_innerTextMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D5584925DDCB50"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Standard";
		innerTextMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return innerTextMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Form Create_frmSignIn(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Form frmSignIn = new OpenSpan.Adapters.Web.Controls.Form();
		this.SetId(frmSignIn, new OpenSpan.Design.ComponentIdentity("Form-8D558494C3F62E0"));
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName;
		txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtUserName
		// 
		txtUserName.ElementId = "user_login";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_login";
		elementIdMatchRule2.Text = textmatchdata1;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule2);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword;
		txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// txtPassword
		// 
		txtPassword.ElementId = "user_password";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "user_password";
		elementIdMatchRule3.Text = textmatchdata2;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule3);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.Button btnSignIn;
		btnSignIn = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// btnSignIn
		// 
		btnSignIn.ElementId = null;
		btnSignIn.Extender = null;
		btnSignIn.ForwardObjectExplorerEvent = true;
		btnSignIn.MatchingIndex = 6;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "commit";
		inputNameMatchRule1.Text = textmatchdata3;
		btnSignIn.MatchRules.Add(inputTypeMatchRule3);
		btnSignIn.MatchRules.Add(inputNameMatchRule1);
		btnSignIn.Name = "btnSignIn";
		btnSignIn.TagName = "INPUT";
		btnSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		btnSignIn.UseElementId = false;
		frmSignIn.Controls.Add(txtUserName);
		frmSignIn.Controls.Add(txtPassword);
		frmSignIn.Controls.Add(btnSignIn);
		frmSignIn.ElementId = "new_user";
		frmSignIn.Extender = null;
		frmSignIn.ForwardObjectExplorerEvent = true;
		frmSignIn.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "new_user";
		elementIdMatchRule1.Text = textmatchdata4;
		frmSignIn.MatchRules.Add(elementIdMatchRule1);
		frmSignIn.Name = "frmSignIn";
		frmSignIn.TagName = "FORM";
		frmSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		frmSignIn.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494C3AF610"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494C4D4590"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C549890"));
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494D7BDA80"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494D81F500"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494D879A50"));
		this.SetId(btnSignIn, new OpenSpan.Design.ComponentIdentity("Button-8D558494ECE4B20"));
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494ED465A0"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D558494EDA0AF0"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C475220"));
		// 
		// Add components
		// 
		components.Add(txtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule2);
		components.Add(txtPassword);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		components.Add(btnSignIn);
		components.Add(inputTypeMatchRule3);
		components.Add(inputNameMatchRule1);
		components.Add(elementIdMatchRule1);
		// 
		// Result
		// 
		return frmSignIn;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_txtUserName(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox txtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(txtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494C3AF610"));
		txtUserName.ElementId = "user_login";
		txtUserName.Extender = null;
		txtUserName.ForwardObjectExplorerEvent = true;
		txtUserName.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_login";
		elementIdMatchRule2.Text = textmatchdata1;
		txtUserName.MatchRules.Add(inputTypeMatchRule1);
		txtUserName.MatchRules.Add(elementIdMatchRule2);
		txtUserName.Name = "txtUserName";
		txtUserName.TagName = "INPUT";
		txtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		txtUserName.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494C4D4590"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C549890"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule1);
		components.Add(elementIdMatchRule2);
		// 
		// Result
		// 
		return txtUserName;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494C4D4590"));
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// Result
		// 
		return inputTypeMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C549890"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_login";
		elementIdMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_txtPassword(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox txtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(txtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D558494D7BDA80"));
		txtPassword.ElementId = "user_password";
		txtPassword.Extender = null;
		txtPassword.ForwardObjectExplorerEvent = true;
		txtPassword.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_password";
		elementIdMatchRule3.Text = textmatchdata1;
		txtPassword.MatchRules.Add(inputTypeMatchRule2);
		txtPassword.MatchRules.Add(elementIdMatchRule3);
		txtPassword.Name = "txtPassword";
		txtPassword.TagName = "INPUT";
		txtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		txtPassword.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494D81F500"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494D879A50"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		// 
		// Result
		// 
		return txtPassword;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494D81F500"));
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// Result
		// 
		return inputTypeMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494D879A50"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_password";
		elementIdMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Button Create_btnSignIn(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Button btnSignIn = new OpenSpan.Adapters.Web.Controls.Button();
		this.SetId(btnSignIn, new OpenSpan.Design.ComponentIdentity("Button-8D558494ECE4B20"));
		btnSignIn.ElementId = null;
		btnSignIn.Extender = null;
		btnSignIn.ForwardObjectExplorerEvent = true;
		btnSignIn.MatchingIndex = 6;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "commit";
		inputNameMatchRule1.Text = textmatchdata1;
		btnSignIn.MatchRules.Add(inputTypeMatchRule3);
		btnSignIn.MatchRules.Add(inputNameMatchRule1);
		btnSignIn.Name = "btnSignIn";
		btnSignIn.TagName = "INPUT";
		btnSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		btnSignIn.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494ED465A0"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D558494EDA0AF0"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule3);
		components.Add(inputNameMatchRule1);
		// 
		// Result
		// 
		return btnSignIn;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D558494ED465A0"));
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// Result
		// 
		return inputTypeMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule Create_inputNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D558494EDA0AF0"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "commit";
		inputNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return inputNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D558494C475220"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "new_user";
		elementIdMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D5584925D20B80"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "10.0.3.112";
		documentUrlMatchRule1.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/users/sign_in";
		documentUrlMatchRule1.Path = textmatchdata3;
		documentUrlMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
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
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D5584925D65140"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "GitLab";
		documentTitleMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule1;
	}
}

}

