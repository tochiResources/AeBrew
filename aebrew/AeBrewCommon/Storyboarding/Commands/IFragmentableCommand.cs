using System.Collections.Generic;

namespace AeBrewCommon.Storyboarding.Commands
{
    public interface IFragmentableCommand : ICommand
    {
        bool IsFragmentable { get; }
        IFragmentableCommand GetFragment(double startTime, double endTime);
        IEnumerable<int> GetNonFragmentableTimes();
    }
}
