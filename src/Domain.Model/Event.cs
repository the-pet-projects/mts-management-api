namespace Domain.Model
{
    public class Event : IMessage
    {
        public int Version { get; set; }
    }
}