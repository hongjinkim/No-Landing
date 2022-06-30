using UnrealBuildTool;

public class SANPEROTarget : TargetRules
{
	public SANPEROTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SANPERO");
	}
}
