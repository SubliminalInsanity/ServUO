using System;
using Server;
using Server.Spells;

namespace Server.Items
{
    public class GargishDupresSword : VikingSword
    {
        public override bool IsArtifact { get { return true; } }
        public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
        public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

        [Constructable]
        public GargishDupresSword()
        {
            this.Hue = 0xA91;
            this.ItemID = 0x0900;
            this.Attributes.BonusStr = 10;
            this.Attributes.AttackChance = 25;
            this.Attributes.WeaponSpeed = 35;
            this.Attributes.WeaponDamage = 100;
            this.WeaponAttributes.HitManaDrain = 50;
        }
        
        public GargishDupresSword(Serial serial) : base(serial)
        {
        }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }
        public override int AosMinDamage { get { return 15; } }
        public override int AosMaxDamage { get { return 17; } }

        public override bool CanFortify { get { return false; } }

        public override int LabelNumber { get { return 1153551; } }

        public override Race RequiredRace { get { return Race.Gargoyle; } }

        public override bool CanBeWornByGargoyles { get { return true; } }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );

            writer.Write( (int) 0 );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );

            int version = reader.ReadInt();
        }
    }
}