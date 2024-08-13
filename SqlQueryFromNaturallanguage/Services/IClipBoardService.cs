namespace SqlQueryFromNaturallanguage.Services
{
    public interface IClipBoardService
    {
        Task CopyToClipboard(string text);
    }
}
