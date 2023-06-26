namespace DataAccess.Interfaces
{
    public interface ISqlAccess
    {
        Task LoadDataAsync<T>(string storedProcedure, T param);
        Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedure, U param);
    }
}