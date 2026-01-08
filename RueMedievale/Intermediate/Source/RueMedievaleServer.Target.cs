using UnrealBuildTool;

public class RueMedievaleServerTarget : TargetRules
{
	public RueMedievaleServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("RueMedievale");
	}
}
