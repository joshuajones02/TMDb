namespace TMDb.Client.Unions
{
    public struct ListsIntStringIdUnion
    {
        public int Int { get; set; }
        public string String { get; set; }

        public static implicit operator ListsIntStringIdUnion(int @int) => 
            new ListsIntStringIdUnion 
            { 
                Int = @int 
            };

        public static implicit operator ListsIntStringIdUnion(string @string) => 
            new ListsIntStringIdUnion 
            { 
                String = @string 
            };
    }
}