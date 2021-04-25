using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class HitObjectRing : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        public override void Generate()
        {
            var hitobjectLayer = GetLayer("");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if ((StartTime != 0 || EndTime != 0) && 
                    (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime))
                    continue;

                var temp = GetLayer("foreground").CreateSprite("Sb/Flare.png", OsbOrigin.Centre, hitobject.Position );
                //temp.Color(fadeStart, UseComboColour ? (Color4) obj.Color : palette[colour]);
                temp.ColorHsb(hitobject.StartTime ,0,0,0);
                temp.Fade(hitobject.StartTime , hitobject.StartTime +900, 1, 0);
                temp.Scale(OsbEasing.OutQuart,hitobject.StartTime, hitobject.StartTime + 1000,0.6,0.3);
                //temp.Additive(st, st+fade);

                var l = GetLayer("foreground").CreateSprite("Sb/ring.png", OsbOrigin.Centre, hitobject.Position );
                //temp.Color(fadeStart, UseComboColour ? (Color4) obj.Color : palette[colour]);
                l.ColorHsb(hitobject.StartTime ,0,0,0);
                l.Fade(hitobject.StartTime , hitobject.StartTime +900, 1, 0);
                l.Scale(OsbEasing.OutQuart,hitobject.StartTime, hitobject.StartTime + 1000,0,0.3);

                
                    
            }
        }
    }
}
