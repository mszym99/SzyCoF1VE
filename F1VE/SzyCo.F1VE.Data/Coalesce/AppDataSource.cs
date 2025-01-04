namespace SzyCo.F1VE.Data.Coalesce;

public abstract class AppDataSource<T> : StandardDataSource<T, AppDbContext>
    where T : class
{
    protected AppDataSource(CrudContext<AppDbContext> context) : base(context)
    {
    }
}
