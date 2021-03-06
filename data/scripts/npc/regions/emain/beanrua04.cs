using Aura.Shared.Const;
using System;
using Aura.World.Network;
using Aura.World.Scripting;
using Aura.World.World;

public class Beanrua04Script : Beanrua_baseScript
{
	public override void OnLoad()
	{
		base.OnLoad();
		SetName("_beanrua04");
		SetBody(height: 0.97f, fat: 0.97f, upper: 1.09f, lower: 1f);
		SetFace(skin: 15, eye: 3, eyeColor: 37, lip: 2);

		SetColor(0x0, 0x0, 0x0);

		EquipItem(Pocket.Face, 0xF3C, 0xF67F6A, 0x1AA547, 0x5676);
		EquipItem(Pocket.Hair, 0xBDC, 0x911411, 0x911411, 0x911411);
		EquipItem(Pocket.Armor, 0x3AEC, 0x171211, 0x2E2623, 0x875253);
		EquipItem(Pocket.Head, 0x468D, 0x0, 0xFFFFFF, 0xFFFFFF);

		SetLocation(region: 57, x: 6164, y: 6507);

		SetDirection(183);
		SetStand("human/female/anim/female_stand_npc_emain_Rua_02");
	}
}
