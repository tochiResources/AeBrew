using AeBrewCommon.Storyboarding.Commands;

namespace AeBrewCommon.Storyboarding.Display
{
    public interface IAnimatedValueBuilder
    {
        void Add(ICommand command);
        void StartDisplayLoop(LoopCommand loopCommand);
        void StartDisplayTrigger(TriggerCommand triggerCommand);
        void EndDisplayComposite();
    }
}
