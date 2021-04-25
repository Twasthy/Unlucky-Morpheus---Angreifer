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
    public class FLash : StoryboardObjectGenerator
{
        public override void Generate()
        {
            par(145292);
            par(219474);
            par(265291);
            par(339473);
            par(356927);
            par(256564);
            par(88565);
            par(355836);
        }
        private void par(int time)
        {
            var Layer = GetLayer("Main");
            

            //Flash
                {
                var s = Layer.CreateSprite("SB/Flare.png", OsbOrigin.Centre);
                s.Move(time,320,480);
                s.ScaleVec(OsbEasing.InQuart,time,time + 1091,10,0,10,20);
                s.StartLoopGroup(time,8);
                s.Fade(OsbEasing.InOutQuad,0,68,0,0.1);
                s.Fade(OsbEasing.InOutQuad,68,136,0.1,0);
                s.EndGroup();
                s.ColorHsb(time,0,1,1);
                s.Additive(time,time + 10000);
                }

            //Stroke
                {
                var s = Layer.CreateSprite("SB/Flare.png", OsbOrigin.Centre);
                s.Move(time,320,420);
                s.Scale(time,20);
                s.Fade(OsbEasing.InQuart,time,time + 1091,0,0.2);
                s.Fade(OsbEasing.OutQuart,time + 1091, time +3000,0.2,0);
                s.ColorHsb(time,0,1,1);
                s.Additive(time,time + 10000);
                }
                


                
            
        }



        }
    }