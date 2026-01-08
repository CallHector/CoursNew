using UnrealBuildTool;

public class RueMedievaleClientTarget : TargetRules
{
	public RueMedievaleClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("RueMedievale");
	}
}
