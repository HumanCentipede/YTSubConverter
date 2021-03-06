﻿using Arc.YTSubConverter.Animations;
using Arc.YTSubConverter.Util;

namespace Arc.YTSubConverter.Formats.Ass.Tags
{
    internal class AssSecondaryAlphaTagHandler : AssTagHandlerBase
    {
        public override string Tag => "2a";

        public override void Handle(AssTagContext context, string arg)
        {
            int alpha = 255 - ParseHex(arg);
            context.Section.SecondaryColor = ColorUtil.ChangeColorAlpha(context.Section.SecondaryColor, alpha);
            context.Section.Animations.RemoveAll(a => a is SecondaryColorAnimation);
        }
    }
}
