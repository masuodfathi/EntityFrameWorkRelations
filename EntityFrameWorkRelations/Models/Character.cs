namespace EntityFrameWorkRelations.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BackPackId { get; set; }
        public Backpack Backpack { get; set; }
    }
}
