namespace TMDb.Client.Attributes
{
    public enum ParameterType
    {
        NotSet = 0,
        JsonBody = 1,
        Endpoint = 5,
        // TODO: Prepend {version} to all paths and make it a path parameter?
        Version = 50,
        Path = 55,
        Query = 60,
        Header = 70
    }
}