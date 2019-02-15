using School;

namespace Conference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LoggingProxy<Tutorial> tutorialProxy = new LoggingProxy<Tutorial>();
            LoggingProxy<FrameProgram> frameProgramProxy = new LoggingProxy<FrameProgram>();
            LoggingProxy<Participant> participantProxy = new LoggingProxy<Participant>();
            LoggingProxy<Referee> refereeProxy = new LoggingProxy<Referee>();
            LoggingProxy<Registration> registrationProxy = new LoggingProxy<Registration>();
        }
    }
}
