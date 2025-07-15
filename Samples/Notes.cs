namespace net_application
{
    public class Notes
    {
        public string name;
        public string notes;
        public bool complite;
        public DateTime startTime;
        public DateTime endTime;


        public Notes(string name, string notes, DateTime startTime, DateTime endTime, bool complite)
        {
            this.name = name;
            this.notes = notes;
            this.startTime = startTime;
            this.endTime = endTime;
            this.complite = complite;
        }
    }
}
