using System.Collections.Generic;
using NUnit.Framework;

namespace CollectionsLib.UnitTest;

public class EmployeeManagerTest
{
    EmployeeManager? manager;


    [SetUp]
    public void Setup()
    {
        manager = new();
    }

    [Test]
    public void GetEmployees_CheckNoNullEmployee()
    {
        var isNull = manager!.GetEmployees().Contains(null!);

        if (isNull)
            Assert.Fail("Containe Null Values");
    }

    [Test]
    public void GetEmployees_CheckID100_Exists()
    {
        var employee = manager!.GetEmployees().Find((emp) => emp.EmpId == 100);
        if (employee != null)
        {
            Assert.Pass();
            return;
        }

        Assert.Fail("List not contains Emp With ID 100");
    }

    [Test]
    public void GetEmployees_Contains_UniqueIDs()
    {
        var idSet = new HashSet<int>();
        foreach (var emp in manager!.GetEmployees())
        {
            if (idSet.Contains(emp.EmpId))
            {
                Assert.Fail("Employee List Do Not Containes Unique Ids");
                return;
            }

            idSet.Add(emp.EmpId);
        }
    }

    [Test]
    public void GetEmployees_SameObjectAsGetEmpByYear_AreSame()
    {
        var emps = manager!.GetEmployees();
        var prevYearEmps = manager.GetEmployeesWhoJoinedInPreviousYears();

        var contains = prevYearEmps.TrueForAll(emp => emps.Contains(emp));

        if (contains) Assert.Pass();
    }
}