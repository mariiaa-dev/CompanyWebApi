using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWebApi.Migrations
{
    public partial class AddEmployeeTriggerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TRIGGER IF EXISTS [dbo].[TRG_EmployeeSalarySmallerThan_CompanyBudget];");

            migrationBuilder.Sql(@"CREATE TRIGGER [dbo].[TRG_EmployeeSalarySmallerThan_CompanyBudget]
                                    on [dbo].[Employee]
                                    after insert, update
                                    as 
                                    if
                                    (select MounthlyBudget
                                    from Company inner join inserted 
                                    on Company.Id = inserted.CompanyId) < (select sum(e.Salary)
																		from Employee e left join inserted i 
                                                                        on e.Id = i.Id
																		where e.CompanyId = i.CompanyId)
                                    begin
                                    RaisError('The mounthly budget of the company is less than the sum of salaries of all employees of the company',1,10)
                                    rollback transaction
                                    return
                                    end;"
                                         );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
