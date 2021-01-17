namespace TMDb.Client.API.V3.Models.Lists
{
    public struct ListIdUnion
    {
        public int Int { get; set; }
        public string String { get; set; }

        public static implicit operator ListIdUnion(int @int) =>
            new ListIdUnion { Int = @int };

        public static implicit operator ListIdUnion(string @string) =>
            new ListIdUnion { String = @string };
    }
}