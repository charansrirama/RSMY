<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-IN">
  <ComponentInfo>
    <Type Value="OpenSpan.Adapters.Web.WebAdapter" />
    <Assembly Value="OpenSpan.Adapters.Web" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.ActiveX, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.WinInet, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.ApplicationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences>
      <File Value="OpenSpan.WinInet.x32.dll" />
      <File Value="OpenSpan.WinInet.x64.dll" />
    </FileReferences>
    <BuildReferences>
      <File Value="DefaultWindowFactoryConfiguration.xml" />
      <File Value="OpenSpan.ActiveX.x32.dll" />
      <File Value="OpenSpan.ActiveX.x64.dll" />
      <File Value="OpenSpan.Brokers.Windows.x32.dll" />
      <File Value="OpenSpan.Brokers.Windows.x64.dll" />
      <File Value="openspan.ini" />
      <File Value="OpenSpan.Native.IPC.x32.dll" />
      <File Value="OpenSpan.Native.IPC.x64.dll" />
      <File Value="OpenSpan.RemoteFunctions.x32.dll" />
      <File Value="OpenSpan.RemoteFunctions.x64.dll" />
      <File Value="OpenSpan.Scout.x32.dll" />
      <File Value="OpenSpan.Scout.x64.dll" />
      <File Value="OpenSpan.Security.x32.dll" />
      <File Value="OpenSpan.Security.x64.dll" />
      <File Value="OpenSpan.SharedMemory.x32.dll" />
      <File Value="OpenSpan.SharedMemory.x64.dll" />
      <File Value="OpenSpan.Sinon.x32.dll" />
      <File Value="OpenSpan.Sinon.x64.dll" />
      <File Value="OpenSpan.Translators.InternetExplorer.x32.dll" />
      <File Value="OpenSpan.Translators.InternetExplorer.x64.dll" />
      <File Value="OpenSpan.Utilities.x32.dll" />
      <File Value="OpenSpan.Utilities.x64.dll" />
      <File Value="OpenSpan.WER.x32.dll" />
      <File Value="OpenSpan.WER.x64.dll" />
      <File Value="OpenSpan.WinInet.x32.dll" />
      <File Value="OpenSpan.WinInet.x64.dll" />
      <File Value="OpenSpan.x32.sys" />
      <File Value="OpenSpan.x64.sys" />
    </BuildReferences>
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Adapters.Web.WebAdapter Name="PMF" Id="WebAdapter-8D55845DBDF670E">
      <StartMyDay Value="Automatic" />
      <StartOnProjectStart Value="False" />
      <StartPage Value="https://agilestudio.pega.com" />
      <Content Name="Controls">
        <Items>
          <OpenSpan.Adapters.ActiveX.ActiveXFactory Name="ActiveXFactory" Id="ActiveXFactory-8D55846328EB70D">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule1" Id="ModuleNameMatchRule-8D55846329BB007">
                  <Text Value="Simple|True|(User Culture)|ole32.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.ActiveX.ActiveXFactory>
          <OpenSpan.Adapters.WinInet.WinInetFactory Name="WinInetFactory" Id="WinInetFactory-8D55846335D21A6">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule2" Id="ModuleNameMatchRule-8D5584633633C76">
                  <Text Value="Simple|True|(User Culture)|wininet.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.WinInet.WinInetFactory>
          <OpenSpan.Adapters.Web.MicrosoftHTMLFactory Name="MicrosoftHTMLFactory" Id="MicrosoftHTMLFactory-8D55846338FF410">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule3" Id="ModuleNameMatchRule-8D5584633970CD5">
                  <Text Value="Simple|True|(User Culture)|mshtml.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Web.MicrosoftHTMLFactory>
          <OpenSpan.Adapters.Controls.Form Name="Windows_Security" Id="Form-8D5584714C2129B">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="12" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Form, OpenSpan.Adapters.Windows" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Controls.Control Name="Control1" Id="Control-8D5584714C08BE7">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="0" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Controls.Control Name="Control" Id="Control-8D5584714BE2E50">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="6" />
                        <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                        <Content Name="Controls">
                          <Items>
                            <OpenSpan.Adapters.Controls.TextBox Name="txtUserName" Id="TextBox-8D5584714B9D4CF">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="0" />
                              <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows" />
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule4" Id="ClassNameMatchRule-8D5584714ED7E1C">
                                    <ClassName Value="Edit" />
                                  </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                  <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule3" Id="WindowTypeMatchRule-8D5584714F002C5">
                                    <Type Value="Child" />
                                  </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.TextBox>
                          </Items>
                        </Content>
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule3" Id="ClassNameMatchRule-8D5584714E84DB8">
                              <ClassName Value="CtrlNotifySink" />
                            </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                            <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule2" Id="WindowTypeMatchRule-8D5584714EA49A2">
                              <Type Value="Child" />
                            </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Control>
                      <OpenSpan.Adapters.Controls.Control Name="Control2" Id="Control-8D55847168B2A31">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="7" />
                        <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                        <Content Name="Controls">
                          <Items>
                            <OpenSpan.Adapters.Controls.TextBox Name="txtPassword" Id="TextBox-8D5584716898FF4">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="0" />
                              <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.TextBox, OpenSpan.Adapters.Windows" />
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule6" Id="ClassNameMatchRule-8D5584716926A08">
                                    <ClassName Value="Edit" />
                                  </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                  <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule5" Id="WindowTypeMatchRule-8D558471694797B">
                                    <Type Value="Child" />
                                  </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.TextBox>
                          </Items>
                        </Content>
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule5" Id="ClassNameMatchRule-8D55847168D39A4">
                              <ClassName Value="CtrlNotifySink" />
                            </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                            <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule4" Id="WindowTypeMatchRule-8D5584716900C71">
                              <Type Value="Child" />
                            </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Control>
                      <OpenSpan.Adapters.Controls.Control Name="Control3" Id="Control-8D558471845877E">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="2" />
                        <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Control, OpenSpan.Adapters.Windows" />
                        <Content Name="Controls">
                          <Items>
                            <OpenSpan.Adapters.Controls.Button Name="btnOk" Id="Button-8D5584718417C21">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="0" />
                              <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Button, OpenSpan.Adapters.Windows" />
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule2" Id="WindowTextMatchRule-8D55847184CB3CC">
                                    <Text Value="Simple|True|(User Culture)|OK" />
                                  </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                                  <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule8" Id="ClassNameMatchRule-8D55847184ED6C8">
                                    <ClassName Value="Button" />
                                  </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                                  <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule3" Id="WindowTextMatchRule-8D558471850E63B">
                                    <Text Value="Simple|True|(User Culture)|OK" />
                                  </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.Button>
                          </Items>
                        </Content>
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule7" Id="ClassNameMatchRule-8D5584718485A4B">
                              <ClassName Value="CtrlNotifySink" />
                            </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                            <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule6" Id="WindowTypeMatchRule-8D55847184A42AC">
                              <Type Value="Child" />
                            </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Control>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule2" Id="ClassNameMatchRule-8D5584714E3B99C">
                        <ClassName Value="DirectUIHWND" />
                      </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule Name="windowTypeMatchRule1" Id="WindowTypeMatchRule-8D5584714E5C90F">
                        <Type Value="Child" />
                      </OpenSpan.Adapters.Windows.MatchRules.WindowTypeMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Control>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule1" Id="WindowTextMatchRule-8D5584714C4220E">
                  <Text Value="Simple|True|(User Culture)|Windows Security" />
                </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                <OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule Name="classNameMatchRule1" Id="ClassNameMatchRule-8D5584714D512DC">
                  <ClassName Value="#32770" />
                </OpenSpan.Adapters.Windows.MatchRules.ClassNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Controls.Form>
          <OpenSpan.Adapters.Web.Controls.WebPage Name="pgPegaAgileStudio" Id="WebPage-8D55DC06F18EBF8">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <IsGlobal Value="True" />
            <MatchingIndex Value="3" />
            <TargetTypeString Value="OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Web.Controls.Link Name="linkNotifications" Id="Link-8D55DC0DDDCA8AE">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="13" />
                  <TagName Value="A" />
                  <TargetTypeString Value="OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web" />
                  <UseElementId Value="False" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Web.MatchRules.AnchorUrlMatchRule Name="anchorUrlMatchRule1" Id="AnchorUrlMatchRule-8D55DC0DDE5A9D4">
                        <Fragment Value="Simple|True|(User Culture)|#" />
                        <Host Value="Simple|True|(User Culture)|agilestudio.pega.com" />
                        <Path Value="Contains|True|(User Culture)|/prweb/AgileStudio/" />
                        <Port Value="443" />
                        <Query Value="Contains|True|(User Culture)|?pzPostData" />
                        <Scheme Value="Simple|True|(User Culture)|https" />
                      </OpenSpan.Adapters.Web.MatchRules.AnchorUrlMatchRule>
                      <OpenSpan.Adapters.Web.MatchRules.AnchorNameMatchRule Name="anchorNameMatchRule1" Id="AnchorNameMatchRule-8D55DC0DDF2A2CE">
                        <Target Value="pyDesktopNotificationGadget_pyDisplayHarness_1" />
                      </OpenSpan.Adapters.Web.MatchRules.AnchorNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Web.Controls.Link>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Name="documentUrlMatchRule1" Id="DocumentUrlMatchRule-8D55DC06F893FB8">
                  <Fragment Value="Simple|True|(User Culture)|" />
                  <Host Value="Simple|True|(User Culture)|agilestudio.pega.com" />
                  <Path Value="Contains|True|(User Culture)|/prweb/AgileStudio/" />
                  <Port Value="443" />
                  <Query Value="Simple|True|(User Culture)|" />
                  <Scheme Value="Simple|True|(User Culture)|https" />
                </OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule>
                <OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Name="documentTitleMatchRule1" Id="DocumentTitleMatchRule-8D55DC06F8E0E6F">
                  <Text Value="Simple|True|(User Culture)|Pega Agile Studio" />
                </OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Web.Controls.WebPage>
          <OpenSpan.Adapters.Web.Controls.WebPage Name="Dashboard_tab_of_Case_Manager_porta" Id="WebPage-8D55DC211994A09">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <IsGlobal Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Web.Controls.Form Name="main" Id="Form-8D55DC21D423335">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="0" />
                  <TagName Value="FORM" />
                  <TargetTypeString Value="OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web" />
                  <UseElementId Value="False" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Web.Controls.BasicButton Name="basicButton1" Id="BasicButton-8D55DC21D38BCD9">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="12" />
                        <TagName Value="BUTTON" />
                        <TargetTypeString Value="OpenSpan.Adapters.Web.HtmlButtonElement, OpenSpan.Adapters.Web" />
                        <UseElementId Value="False" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Web.MatchRules.ButtonNameMatchRule Name="buttonNameMatchRule1" Id="ButtonNameMatchRule-8D55DC21D57CBA8">
                              <HtmlName Value="pyFeed_D_pzFeedParams_7" />
                            </OpenSpan.Adapters.Web.MatchRules.ButtonNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Web.Controls.BasicButton>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule Name="formNameMatchRule1" Id="FormNameMatchRule-8D55DC21D4A22DD">
                        <HtmlName Value="main" />
                      </OpenSpan.Adapters.Web.MatchRules.FormNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Web.Controls.Form>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Name="documentUrlMatchRule2" Id="DocumentUrlMatchRule-8D55DC2119DCA9C">
                  <Fragment Value="Simple|True|(User Culture)|" />
                  <Host Value="Simple|True|(User Culture)|agilestudio.pega.com" />
                  <Path Value="Simple|True|(User Culture)|/prweb/AgileStudio/z9TwsFgrP5T_i0ULWyqfeAGRYGrYSWAmXg2-aEDs9JI%5B*/!TABTHREAD0" />
                  <Port Value="443" />
                  <Query Value="Simple|True|(User Culture)|" />
                  <Scheme Value="Simple|True|(User Culture)|https" />
                </OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule>
                <OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Name="documentTitleMatchRule2" Id="DocumentTitleMatchRule-8D55DC211A1FD0B">
                  <Text Value="Simple|True|(User Culture)|Dashboard tab of Case Manager portal" />
                </OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Web.Controls.WebPage>
        </Items>
      </Content>
      <Content Name="Credentials">
        <Items>
          <OpenSpan.ApplicationFramework.AssistedSignOn.Credential>
            <ApplicationKey Value="PMF" />
            <LoginControl Value="WebAdapter-8D55845DBDF670E\Button-8D5584718417C21" />
            <PasswordControl Value="WebAdapter-8D55845DBDF670E\TextBox-8D5584716898FF4" />
            <UserNameControl Value="WebAdapter-8D55845DBDF670E\TextBox-8D5584714B9D4CF" />
          </OpenSpan.ApplicationFramework.AssistedSignOn.Credential>
        </Items>
      </Content>
    </OpenSpan.Adapters.Web.WebAdapter>
  </Component>
</OpenSpanDesignDocument>