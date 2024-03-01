namespace SPL.Services.IServices
{
    public interface IGraphService
    {
        IEnumerable<string> GetPath(string pathA, string pathB);
    }
}
