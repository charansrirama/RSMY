<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-IN">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Office, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="Outlook_P_FromList" Id="Automator-8D559A6871D46FC">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5000, 5000" />
        <Objects>
          <ConnectionBlock>
            <DisplayName Value="MicrosoftOutlook.NewMail" />
            <ConnectableUniqueId Value="Automator-8D559A6871D46FC\ConnectableEvent-8D559D6C58C5034" />
            <PartID Value="1" />
            <Left Value="180" />
            <Top Value="220" />
            <Collapsed Value="True" />
            <WillExecute Value="True" />
            <InstanceName Value="Outlook" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links />
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <ShowDesignCompNames Value="True" />
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.ConnectableEvent Name="connectableEvent1" Id="ConnectableEvent-8D559D6C58C5034">
      <ComponentName Value="Outlook" />
      <DisplayName Value="MicrosoftOutlook.NewMail" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Office.MicrosoftOutlook" />
      <InstanceUniqueId Value="GlobalContainer-8D559A643E79644\MicrosoftOutlook-8D559A64DC65E61" />
      <MemberDetails Value=".NewMail Event" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="NewMail" />
            <MemberType Value="Event" />
            <TypeAssemblyName Value="OpenSpan.Office" />
            <TypeName Value="OpenSpan.Office.MicrosoftOutlookMailHandler" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableEvent>
  </Component>
</OpenSpanDesignDocument>