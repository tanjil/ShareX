﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace HelpersLib
{
    class Hue : iDrawStyles
    {
        public override void SetBoxMarker(Point lastPos, MyColor SelectedColor, int ClientWidth, int ClientHeight)
        {
            lastPos.X = Round((ClientWidth - 1) * SelectedColor.HSB.Saturation);
            lastPos.Y = Round((ClientHeight - 1) * (1.0 - SelectedColor.HSB.Brightness));
        }
        public override void SetSliderMarker(Point lastPos, MyColor SelectedColor, int ClientHeight)
        {
            lastPos.Y = (ClientHeight - 1) - Round((ClientHeight - 1) * SelectedColor.HSB.Saturation);
        }
        public override void GetBoxColor(Point lastPos, MyColor selectedColor, int ClientWidth, int ClientHeight)
        {
            selectedColor.HSB.Saturation = (double)lastPos.X / (ClientWidth - 1);
            selectedColor.HSB.Brightness = 1.0 - (double)lastPos.Y / (ClientHeight - 1);
            selectedColor.HSBUpdate();
        }
        public override void GetSliderColor(Point lastPos, MyColor selectedColor, int ClientWidth, int ClientHeight)
        {
            selectedColor.HSB.Hue = 1.0 - (double)lastPos.Y / (ClientHeight - 1);
            selectedColor.HSBUpdate();
        }
    }
}



