#if DEBUG
using AeBrewCommon.Storyboarding;
using System.Collections.Generic;

namespace AeBrewCommon.Storyboarding3d
{
    public interface HasOsbSprites
    {
        IEnumerable<OsbSprite> Sprites { get; }
    }
}
#endif