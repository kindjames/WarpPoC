namespace Warp.Data.Entities
{
    public class sysdiagram
    {
        public string name { get; set; }
        public int principal_Id { get; set; }
        public int diagram_Id { get; set; }
        public int? version { get; set; }
        public byte[] definition { get; set; }
    }
}