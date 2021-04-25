using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using System;
using System.Linq;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        public override void Generate()
        {
            if (BackgroundPath == "") BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.Scale(StartTime, 500.0f / bitmap.Height);
            bg.Fade(StartTime ,  0);
            bg.Fade(EndTime, 0);
            bg.Fade(124565,1);
            bg.Fade(181292,181292,1,0);
            bg.Fade(220565 ,220565,0,1);
            bg.Fade(198746,1);
            bg.Fade(356927,0);
            bg.Fade(358018 - 500,358018 ,0,1);
            bg.Fade(88565,1);
            bg.Fade(414745,0);

            var s = GetLayer("").CreateSprite("sb/blur.png", OsbOrigin.Centre);
            s.Scale(StartTime, 500.0f / bitmap.Height);
            s.Fade(OsbEasing.InOutBounce,89656,89656 + 1000,0,1);
            s.Fade(OsbEasing.InOutBounce,163837,163837 + 1000,0,1);
            s.Fade(OsbEasing.InOutBounce,392927,392927 + 1000,0,1);
            s.Fade(0,1);
            s.Fade(39482,39482 + 2000,1,0);
            s.Fade(416927,421291,1,0);
            s.Fade(124565,124565 + 2000,1,0);
            s.Fade(266382,266382 + 500,0,1);
            s.Fade(314382,314382 + 2000,1,0);
            s.Fade(340564,1);
            s.Fade(356927,356927 + 200,1,0.2);
            s.Fade(181292,181292 + 500,1,0);

            var ss = GetLayer("").CreateSprite("sb/noblur.png", OsbOrigin.Centre);
            ss.Scale(StartTime, 500.0f / bitmap.Height);
            ss.Fade(0,0);
            ss.Fade(39482,1);
            ss.Fade(89656- 500,89656,1,0);
            ss.Fade(OsbEasing.InOutBounce,142019 ,142019 +  1000,0,1);
            ss.Fade(146383,146383 + 500,1,0);
            ss.Fade(OsbEasing.InOutBounce,183201,183201 + 1000,0,1);
            ss.Fade(OsbEasing.InOutBounce,216201,216201 + 1000,0,1);
            ss.Fade(220565,220565 + 500,1,0);
            ss.Fade(198746,198746 + 2000,1,0);
            ss.Fade(238018,238018 + 2000,0,1);
            ss.Fade(266382,266382 + 500,1,0);
            ss.Fade(OsbEasing.InOutBounce,331836,331836 + 1000,0,1);
            ss.Fade(340564,340564 + 2000,1,0);

            var v = GetLayer("Vignette").CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            v.Scale(StartTime, 500.0f / bitmap.Height);
            v.Fade(StartTime,1);
            v.Fade(EndTime,EndTime + 2000,1,0);

            {
            var step = Random(2000,5000);
            for(var t = 0 + step; t < EndTime; t += step) {
            var previousTime = t - step;
            var ranPoX = Random(-5, 5);
            var ranPoY = Random(-5, 5);
            bg.Move(OsbEasing.InOutQuad,previousTime, t, bg.PositionAt(previousTime), new Vector2(ranPoX+ 320, ranPoY+240));
            s.Move(OsbEasing.InOutQuad,previousTime, t, s.PositionAt(previousTime), new Vector2(ranPoX+ 320, ranPoY+240));
            ss.Move(OsbEasing.InOutQuad,previousTime, t, ss.PositionAt(previousTime), new Vector2(ranPoX+ 320, ranPoY+240));
            
            
                    }
                }
                var step1 = Random(6000,10000);
                for(var t = 0 + step1; t < EndTime; t += step1) {
            var previousTime = t - step1;
            var rot = Random(-0.04,0.04 );
            bg.Rotate(OsbEasing.InOutQuad,previousTime, t, bg.RotationAt(previousTime),rot);
            s.Rotate(OsbEasing.InOutQuad,previousTime, t, s.RotationAt(previousTime),  rot);
            ss.Rotate(OsbEasing.InOutQuad,previousTime, t, ss.RotationAt(previousTime),rot);
                
            
            }
        }
    }
}
