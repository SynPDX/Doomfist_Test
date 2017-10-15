using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Engines.CannedEvil;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "the body of a lost soul" )]
	public class LostSoul : BaseCreature
	{
		private bool m_TrueForm;
		[Constructable]
		public LostSoul() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a lost soul";
			BodyValue = 146;
			Hue = 1175;

			SetStr( 900, 1000 );
			SetDex( 125, 135 );
			SetInt( 1000, 1200 );

			Fame = 22500;
			Karma = -22500;

			VirtualArmor = 60;

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 60, 80 );
			SetResistance( ResistanceType.Poison, 60, 80 );
			SetResistance( ResistanceType.Energy, 60, 80 );

			SetSkill( SkillName.Wrestling, 90.1, 100.0 );
			SetSkill( SkillName.Tactics, 90.2, 110.0 );
			SetSkill( SkillName.MagicResist, 120.2, 160.0 );
			SetSkill( SkillName.Magery, 120.0 );
			SetSkill( SkillName.EvalInt, 120.0 );
			SetSkill( SkillName.Meditation, 120.0 );
			Fame = 45000;
			Karma = -45000;

			VirtualArmor = 50;
			Hue = 0;
			switch ( Utility.Random( 2 ))
			{
				case 0: PackItem( new Halloween2017SkullRugSouthDeed() ); break; 
			    case 1: PackItem( new Halloween2017SkullRugEastDeed() ); break;
			}
			TokenDropHT(2);
			switch ( Utility.Random( 10 ))
			{
				case 0: PackItem( new TrickOrTreatBag() ); break;
				case 1: PackItem( new TrickOrTreatBag() ); break;
				case 2: PackItem( new TrickOrTreatBag() ); break;
				case 3: PackItem( new TrickOrTreatBag() ); break;
				case 4: PackItem( new TrickOrTreatBag() ); break;
				case 5: PackItem( new TrickOrTreatBag() ); break;
				case 6: PackItem( new TrickOrTreatBag() ); break;
				case 7: PackItem( new TrickOrTreatBagMedium() ); break;
				case 8: PackItem( new TrickOrTreatBagMedium() ); break;
				case 9: PackItem( new TrickOrTreatBagLarge() ); break;
			}
		}
		public override bool OnBeforeDeath()
        {
 			if ( m_TrueForm )
			{
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 2 ))
				{
					case 0: PackItem( new Halloween2017SkullRugSouthDeed() ); break; 
					case 1: PackItem( new Halloween2017SkullRugEastDeed() ); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
				switch ( Utility.Random( 11 ))
				{
					case 0: PackItem(new Halloween2017SacrificialAlterEastDeed()); break;
					case 1: PackItem(new Halloween2017Lantern()); break;
					case 2: PackItem(new Halloween2017SacrificialAlterSouthDeed()); break;
					case 3: PackItem(new Halloween2017StoneCoffinEastDeed()); break;
					case 4: PackItem(new Halloween2017StoneCoffinSouthDeed()); break;
					case 5: PackItem(new Halloween2017ShadowStone()); break;
					case 6: PackItem(new Halloween2017ShadowShort()); break;
					case 7: PackItem(new Halloween2017ShadowTall()); break;
					case 8: PackItem(new Halloween2017SpikeStatue()); break;
					case 9: PackItem(new Halloween2017SpikePoleStatue()); break;
					case 10: PackItem(new Halloween2017DaemonPoleStatue()); break;
				}
			PackItem( new Gold(60000) );
			PackItem( new Gold(60000) );
			PackItem( new Gold(25000) );
			PackItem( new Gold(25000) );
			PackItem( new Gold(60000) );
			PackItem( new Gold(10000) );
		
				return base.OnBeforeDeath();
			}
			else
			{
				Morph();
				return false;
			}
		}
		public override void OnDeath(Container c)
		{
			base.OnDeath(c);

			// Random non-craft skill PS, can be 5, 10, 15 or 20
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 20));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 20));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			c.DropItem(PowerScroll.CreateRandomNoCraft(5, 15));
			
		}
		public virtual void TokenDropHT(int amount)
        {
            if (0.10 > Utility.RandomDouble())
				switch ( Utility.Random( 10 ))
				{
					case 0: PackItem(new HalloweenToken(5)); break;
					case 1: PackItem(new HalloweenToken(5)); break;
					case 2: PackItem(new HalloweenToken(5)); break;
					case 3: PackItem(new HalloweenToken(5)); break;
					case 4: PackItem(new HalloweenToken(5)); break;
					case 5: PackItem(new HalloweenToken(5)); break;
					case 6: PackItem(new HalloweenToken(7)); break;
					case 7: PackItem(new HalloweenToken(9)); break;
					case 8: PackItem(new HalloweenToken(11)); break;
					case 9: PackItem(new HalloweenToken(13)); break;
				}
		}
		public void Morph()
		{
			if ( m_TrueForm )
				return;
			m_TrueForm = true;
			PlaySound( 0x1BA );
			Name = "the corrupted lost soul";
			BodyValue = 308;
			Hue = 1175;

			Hits = HitsMax;
			Stam = StamMax;
			Mana = ManaMax;

			PublicOverheadMessage( MessageType.Regular, GetRandomHue(),  true, "Y-you!" );

			Map map = this.Map;
			int newghostsx = 8;
				for ( int i = 0; i < newghostsx; ++i )
				{
					BaseCreature ghostsx;

					switch ( Utility.Random( 12 ) )
					{
						default:
						case 0:  ghostsx = new DarkChocolateDragon(); break;
						case 1:	 ghostsx = new WhiteChocolateDragon(); break;
						case 2:  ghostsx = new MilkChocolateDragon(); break;
						case 3:	 ghostsx = new HalloweenWitch(); break;
						case 4:	 ghostsx = new HalloweenScarecrow(); break;
						case 5:  ghostsx = new HalloweenSkeleton(); break;
						case 6:	 ghostsx = new HalloweenZombie(); break;
						case 7:  ghostsx = new GhostPhysical(); break;
						case 8:	 ghostsx = new GhostMagical(); break;
						case 9:  ghostsx = new HalloweenMummy(); break;
						case 10: ghostsx = new HalloweenVampireBat(); break;
						case 11: ghostsx = new TheVampire(); break;
					}

					ghostsx.Team = this.Team;

					bool validLocation = false;
					Point3D loc = this.Location;

					for ( int j = 0; !validLocation && j < 10; ++j )
					{
						int x = X + GetRandomLocation();
						int y = Y + GetRandomLocation();
						int z = map.GetAverageZ( x, y );

						if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
							loc = new Point3D( x, y, Z );
						else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
							loc = new Point3D( x, y, z );
					}

					ghostsx.MoveToWorld( loc, map );
				}
		}
		[CommandProperty( AccessLevel.GameMaster )]
		public override int HitsMax{ get{ return m_TrueForm ? 90000 : 45000; } }
		[CommandProperty( AccessLevel.GameMaster )]
		public override int ManaMax{ get{ return 3000; } }
		public virtual int GetRandomHue()
		{
			switch ( Utility.Random( 5 ) )
			{
				default:
				case 0: return Utility.RandomBlueHue();
				case 1: return Utility.RandomGreenHue();
				case 2: return Utility.RandomRedHue();
				case 3: return Utility.RandomYellowHue();
				case 4: return Utility.RandomNeutralHue();
			}
		}
		public virtual int GetRandomLocation()
		{
			switch ( Utility.Random( 2 ) )
			{
				default:
				case 0: return - Utility.Random( 6 );
				case 1: return + Utility.Random( 6 );
			}
		}
		public override void GenerateLoot()
		{
			AddLoot( LootPack.SuperBoss, 4 );
			AddLoot( LootPack.Meager );
		}
		public override Poison PoisonImmune{ get{ return Poison.Greater; } }
		public override int TreasureMapLevel{ get{ return 2; } }
		public override bool DisallowAllMoves{ get{ return m_TrueForm; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }

		public LostSoul( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_TrueForm );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			
			switch ( version )
			{
				case 0:
				{
					m_TrueForm = reader.ReadBool();
					break;
				}
			}
		}
	}
}