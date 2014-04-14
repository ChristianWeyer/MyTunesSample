namespace MyTunes.BusinessLogic.Interfaces
{
    public class TrackDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Composer { get; set; }
        public int? Size { get; set; }
        public int Duration { get; set; }
    }
}
