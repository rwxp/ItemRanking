namespace RankingApp.Server.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
        public int Ranking {  get; set; }
        // Movies are assigned value 1, albums are assigned value 2.
        public int ItemType { get; set; }

    }
}
