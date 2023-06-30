using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persistence
{
    public static class MigrationBuilderExtensions
    {
        public static void ConfigForSqlite(this MigrationBuilder migrationBuilder)
        {
            //For each table registered in the builder, let's change the type of nvarchar to TEXT
            foreach (CreateTableOperation createTableOperation in migrationBuilder.Operations.ToArray().OfType<CreateTableOperation>())
            {
                foreach (var column in createTableOperation.Columns.Where(x => x.ColumnType.StartsWith("nvarchar", StringComparison.OrdinalIgnoreCase)))
                {
                    if (column.ColumnType.Contains('(') && !column.ColumnType.Contains("MAX", StringComparison.OrdinalIgnoreCase))
                        column.MaxLength = int.Parse(column.ColumnType.Substring("nvarchar".Length + 1).Replace(")", ""));
                    column.ColumnType = "TEXT";
               }
            }
        }
    }

}
