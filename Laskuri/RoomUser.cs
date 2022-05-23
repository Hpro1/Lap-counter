namespace Laskuri
{
    class RoomUser
    {
        public string Name { get; set; }
        public int Effect { get; set; }
        public int Index { get; set; }

        public RoomUser (string name, int index)
        {
            Index = index;
            Name = name;
        }
    }
}
