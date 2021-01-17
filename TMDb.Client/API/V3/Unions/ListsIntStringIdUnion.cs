namespace TMDb.Client.Unions
{
    public struct ListsIntStringIdUnion
    {
        public int IntId { get; set; }
        public string StringId { get; set; }

        public static implicit operator ListsIntStringIdUnion(int intId) => 
            new ListsIntStringIdUnion 
            { 
                IntId = intId 
            };

        public static implicit operator ListsIntStringIdUnion(string stringId) => 
            new ListsIntStringIdUnion 
            { 
                StringId = stringId 
            };
    }
}