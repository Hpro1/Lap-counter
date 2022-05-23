using System.Windows.Forms;

namespace Laskuri
{
    class Player
    {
        public string Name { get; set; }
        public int Stops { get; set; }
        public int Laps { get; set; }

        public Player (string name)
        {
            Name = name;
            Stops = 0;
            Laps = 0;
        }

        public Player (Player_Item playerControl)
        {
            Name = playerControl.Username;
            Stops = playerControl.Stops;
            Laps = playerControl.Laps;
        }
    }
}
