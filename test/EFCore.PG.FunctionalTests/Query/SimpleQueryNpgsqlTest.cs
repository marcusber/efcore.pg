using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Npgsql.EntityFrameworkCore.PostgreSQL.TestUtilities;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Query;

public class SimpleQueryNpgsqlTest : SimpleQueryRelationalTestBase
{
    protected override ITestStoreFactory TestStoreFactory => NpgsqlTestStoreFactory.Instance;

    // Writes DateTime with Kind=Unspecified to timestamptz
    public override Task SelectMany_where_Select(bool async)
        => Task.CompletedTask;

    // Writes DateTime with Kind=Unspecified to timestamptz
    public override Task Subquery_first_member_compared_to_null(bool async)
        => Task.CompletedTask;

    // https://github.com/dotnet/efcore/pull/27280, fixed for 7.0
    public override Task Aggregate_over_subquery_in_group_by_projection(bool async)
        => Task.CompletedTask;
}
