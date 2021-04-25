using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

namespace StorybrewScripts
{
    public class HitObjectHighlight : StoryboardObjectGenerator
    {
        [Configurable]
        public string SpritePath = "";
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 10000;

        public override void Generate()
        {

            var hitobjectLayer = GetLayer("");
            foreach (var hitobject in Beatmap.HitObjects) 
            {
                
                if ((StartTime != 0 || EndTime != 0) && 
                    (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime))
                    continue;
                var fade = 500;
                var fadeStart = hitobject.StartTime - fade;
                var st = hitobject.StartTime;
                var en = hitobject.EndTime + 200;
                var fadeEnd = en + fade;

               
            if(hitobject is OsuSlider)
            {   
                var ran = Random(1000,2000);
                for(var time = st; time < hitobject.EndTime; time += 10) {
                    var temp = GetLayer("foreground").CreateSprite(SpritePath, OsbOrigin.Centre);
                    temp.Move(OsbEasing.InQuart,time, time + ran,hitobject.PositionAtTime(time).X,hitobject.PositionAtTime(time).Y,hitobject.PositionAtTime(time).X + Random(-50,50),hitobject.PositionAtTime(time).Y - 200);
                    temp.ColorHsb(time ,0,0,0);
                    temp.Scale(time, 0.6);
                    temp.Fade(time , hitobject.EndTime + ran, 0.2, 0);
                    //temp.Additive(time , time + fade);
                }
            }
            else
            {
                var temp = GetLayer("foreground").CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position );
                //temp.Color(fadeStart, UseComboColour ? (Color4) obj.Color : palette[colour]);
                temp.ColorHsb(st ,0,0,0);
                temp.Fade(st , st +900, 1, 0);
                temp.Scale(OsbEasing.OutQuart,st, st + 1000,0.6,0.3);
                //temp.Additive(st, st+fade);

                var l = GetLayer("foreground").CreateSprite("Sb/ring.png", OsbOrigin.Centre, hitobject.Position );
                //temp.Color(fadeStart, UseComboColour ? (Color4) obj.Color : palette[colour]);
                l.ColorHsb(st ,0,0,0);
                l.Fade(st , st +900, 1, 0);
                l.Scale(OsbEasing.OutQuart,st, st + 1000,0,0.3);
                //l.Additive(st, st+1000);
            }
            

               

                    
                
            }
        }
    }
}
