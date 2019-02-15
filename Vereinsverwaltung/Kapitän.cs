namespace Fußballvereinsverwaltung
{
    public class Kapitän : Fußballer
    {
        private bool _teamKoordiniert = false;

        public void KoordiniereTeam()
        {
            if (_teamKoordiniert)
                return;

            foreach(Fußballer fußballer in Team.Mannschaft)
            {
                fußballer.TorschussWahrscheinlichkeit *= 1.5;
            }
        }
    }
}
