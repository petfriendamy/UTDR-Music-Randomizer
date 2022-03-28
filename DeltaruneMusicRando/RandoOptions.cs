using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaruneMusicRando
{
    public class RandoOptions
    {
        public bool SpeedrunLegal { get; }
        public bool CyberBattle { get; }
        public bool MultiPart { get; }
        public bool CreditsSongs { get; }
        public bool Ambience { get; }
        public bool SFX { get; }

        public RandoOptions(bool speedrunLegal, bool cyberBattle, bool multiPart,
            bool creditsSongs, bool ambience, bool sfx)
        {
            SpeedrunLegal = speedrunLegal;
            CyberBattle = cyberBattle;
            MultiPart = multiPart;
            CreditsSongs = creditsSongs;
            Ambience = ambience;
            SFX = sfx;
        }
    }
}
