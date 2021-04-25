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
    public class SimpleFlash : StoryboardObjectGenerator
{
        public override void Generate()
        {
            par(39482);
            par(89656);
            par(146383);
            par(181292);
            par(220565);
            par(266382);
            par(288200);
            par(340564);
            par(375473);
            par(416927);
            par(358018);
            par(356927);
            par(257654);
            par(259836);
            par(78747);
            
        }
        private void par(int time)
        {
            var Layer = GetLayer("Main");             
                var s = Layer.CreateSprite("SB/Flare.png", OsbOrigin.Centre);
                s.Move(time,320,240);
                s.Scale(time,20);
                s.Fade(time - 200, time,0,0.2);
                s.Fade(time, time + 2000,0.2,0);
                s.Additive(time,time + 2000);
                

            
                


                
            
        }



        }
    }