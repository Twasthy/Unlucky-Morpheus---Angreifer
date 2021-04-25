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
    public class Flower : StoryboardObjectGenerator
    {
        [Configurable]
        public string SpritePath = "SB/dot.png";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 1000;

        [Configurable]
        public int CentreX = 320;

        [Configurable]
        public int CentreY = 240;

        [Configurable]
        public Color4 Color = new Color4(255, 255, 255, 100);

        public override void Generate()
        {
            {
                int Count = 10;
                for (int i = 0; i < Count; i++)
            {   
            var Radius = 60 ;
            double x, y, x1, y1;
            x = CentreX + Radius;
            y = CentreY ;
            int BeatTimer = 360;
            int time = (EndTime - StartTime ) / BeatTimer;
            int time2 = StartTime ;
            var angle = i * (Math.PI * 2) / Count+ (40* Math.PI /180);
            var ranTime = Random(0,1000);
            var cor = Random(0.5,1);
            var dot = GetLayer("").CreateSprite(SpritePath, OsbOrigin.BottomCentre);
            dot.Scale(OsbEasing.OutQuart,StartTime + ranTime, StartTime + ranTime + 2000, 0,0.8 );
            //dot.Fade(EndTime - 500,EndTime ,1,0);
            dot.Rotate(StartTime,EndTime,angle,angle + (400* Math.PI /180));
            //dot.Fade(StartTime, StartTime + 1000,0, Color.A);
            dot.ColorHsb(StartTime,355836,0,1,0.3,0,1,0.2);
            dot.ColorHsb(OsbEasing.InQuart,356654 - 1000,356927,0,1,0.2,0,0,0);
            dot.Scale(OsbEasing.InQuart,356654 - ranTime,356927,0.8,0);
            //dot.Additive(StartTime,EndTime);
            for (int deg = 360 /Count*i; deg < 360 /Count*i + 120  ; deg += BeatTimer/120)
            {
                double rad = deg * Math.PI / 180;
                x1 = Radius * Math.Cos(rad) + CentreX;
                y1 = Radius * Math.Sin(rad) + CentreY;
                dot.Move(time2, time2 + time, x, y, x1, y1);
                time2 += time;
                x = x1;
                y = y1;
                        }
                    }
                }
                {
                int Count = 10;
                for (int i = 0; i < Count; i++)
            {   
            var Radius = 0 ;
            double x, y, x1, y1;
            x = CentreX + Radius;
            y = CentreY ;
            int BeatTimer = 360;
            int time = (EndTime - StartTime ) / BeatTimer;
            int time2 = StartTime ;
            var angle = i * (Math.PI * 2) / Count+ (40* Math.PI /180);
            var ranTime = Random(0,1000);
            var cor = Random(0.3,0.6);
            var dot = GetLayer("").CreateSprite(SpritePath, OsbOrigin.BottomCentre);
            dot.Scale(OsbEasing.OutQuart,StartTime + ranTime, StartTime + ranTime + 2000, 0,0.6 );
            //dot.Fade(EndTime - 500,EndTime ,1,0);
            dot.Rotate(StartTime,EndTime,angle,angle + (360* Math.PI /180));
            //dot.Fade(StartTime, StartTime + 1000,0, Color.A);
            dot.ColorHsb(StartTime,355836,0,1,cor,0,1,cor-0.2);
            dot.ColorHsb(OsbEasing.InQuart,356654 - 1000,356927,0,1,cor-0.2,0,0,0);
            dot.Scale(OsbEasing.InQuart,356654 - ranTime,356927,0.6,0);
            //dot.Additive(StartTime,EndTime);
            for (int deg = 360 /Count*i; deg < 360 /Count*i + 240  ; deg += BeatTimer/240)
            {
                double rad = deg * Math.PI / 180;
                x1 = Radius * Math.Cos(rad) + CentreX;
                y1 = Radius * Math.Sin(rad) + CentreY;
                //dot.Move(time2, time2 + time, x, y, x1, y1);
                time2 += time;
                x = x1;
                y = y1;
                        }
                    }
                }
                {
                int Count = 6;
                for (int i = 0; i < Count; i++)
            {   
            var Radius = -2 ;
            double x, y, x1, y1;
            x = CentreX + Radius;
            y = CentreY ;
            int BeatTimer = 360;
            int time = (EndTime - StartTime ) / BeatTimer;
            int time2 = StartTime ;
            var angle = i * (Math.PI * 2) / Count+ (40* Math.PI /180);
            var ranTime = Random(0,1000);
            var cor = Random(0.6,1);
            var dot = GetLayer("").CreateSprite(SpritePath, OsbOrigin.BottomCentre);
            dot.Scale(OsbEasing.OutQuart,StartTime + ranTime, StartTime + ranTime + 2000, 0,0.4 );
            //dot.Fade(EndTime - 500,EndTime ,1,0);
            dot.Rotate(StartTime,EndTime,angle,angle + (360* Math.PI /180));
            //dot.Fade(StartTime, StartTime + 1000,0, Color.A);
            dot.ColorHsb(StartTime,355836,0,1,cor,0,0.8,cor-0.2);
            dot.ColorHsb(OsbEasing.InQuart,356654 - 1000,356927,0,0.8,cor-0.2,0,0,0);
            dot.Scale(OsbEasing.InQuart,356654 - ranTime,356927,0.4,0);
            //dot.Additive(StartTime,EndTime);
            for (int deg = 360 /Count*i; deg < 360 /Count*i + 360  ; deg += BeatTimer/360)
            {
                double rad = deg * Math.PI / 180;
                x1 = Radius * Math.Cos(rad) + CentreX;
                y1 = Radius * Math.Sin(rad) + CentreY;
                dot.Move(time2, time2 + time, x, y, x1, y1);
                time2 += time;
                x = x1;
                y = y1;
                        }
                    }
                }
            }
        }
    }

