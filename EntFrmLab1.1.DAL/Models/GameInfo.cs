namespace EntFrmLab1._1.DAL.Models
{
    public class GameInfo
    {
        public int Id { get; set; }

        public string GameName { get; set; }

        public string Studio { get; set; }

        public string Genre { get; set; }

        public bool? IsMultiplayer { get; set; }
        public int? CopiesSold { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
