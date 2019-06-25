using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.NPCs
{
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/blushiemagic/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Slimoe : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimoe");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[3];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 35;
			npc.damage = 20;
			npc.defense = 6;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.RedSlime;
			animationType = NPCID.RedSlime;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 10f;
		}

	}
}
