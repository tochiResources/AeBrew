using System;
using System.IO;

namespace AeBrewCommon.Storyboarding
{
    public abstract class StoryboardObject : MarshalByRefObject
    {
        public abstract double StartTime { get; }
        public abstract double EndTime { get; }

        public abstract void WriteOsb(TextWriter writer, ExportSettings exportSettings, OsbLayer layer);
    }
}
