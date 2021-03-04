using System;
using System.Collections.Generic;


namespace Quest
{
    public class HeadCover
    {
        public int ShininessLevel { get; set; }

        public string ShininessDescription()
        {
            string shineDescrtiption = "it's a hat";
            if (ShininessLevel < 2)
            {
                shineDescrtiption = "dull";
            }
            else if (ShininessLevel > 2 && ShininessLevel < 5)
            {
                shineDescrtiption = "noticeable";
            }
            else if (ShininessLevel >= 6 && ShininessLevel <= 9)
            {
                shineDescrtiption = "bright";
            }
            else if (ShininessLevel > 9)
            {
                shineDescrtiption = "blinding";
            }

            return $"{shineDescrtiption}";

        }


    }
}