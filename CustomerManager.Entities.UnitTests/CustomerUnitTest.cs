namespace CustomerManager.Entities.UnitTests;

public class CustomerUnitTest
{
    [Fact]
    public void CustomerNewOk()
    {
        Customer customerTest = Customer.Instance(1, "Argenis", "Villarroel", "Desconocida", "Contado", Environment.UserName);

        Assert.NotNull(customerTest);
        Assert.Equal(Environment.UserName, customerTest.CreatedBy);
        Assert.Null(customerTest.LastModifiedBy);
        Assert.Null(customerTest.LastModifiedOn);

        Assert.False(customerTest.IsDelete);
        Assert.Null(customerTest.DeletedBy);
        Assert.Null(customerTest.DeletedOn);
    }

    [Fact]
    public void CustomerModifyOk()
    {
        Customer customerTest = Customer.Instance(1, "Argenis", "Villarroel", "Desconocida", "Contado", Environment.UserName);

        customerTest.ChangeName("Arturo", "Davila", Environment.UserName);

        Assert.NotNull(customerTest);
        Assert.Equal(Environment.UserName, customerTest.CreatedBy);
        Assert.NotNull(customerTest.LastModifiedBy);
        Assert.NotNull(customerTest.LastModifiedOn);
        Assert.Equal(Environment.UserName, customerTest.LastModifiedBy);

        Assert.False(customerTest.IsDelete);
        Assert.Null(customerTest.DeletedBy);
        Assert.Null(customerTest.DeletedOn);

    }

    [Fact]
    public void CustomerDeleteOk()
    {
        Customer customerTest = Customer.Instance(1, "Argenis", "Villarroel", "Desconocida", "Contado", Environment.UserName);

        customerTest.Delete(Environment.UserName);

        Assert.NotNull(customerTest);
        Assert.Equal(Environment.UserName, customerTest.CreatedBy);
        Assert.Null(customerTest.LastModifiedBy);
        Assert.Null(customerTest.LastModifiedOn);

        Assert.True(customerTest.IsDelete);
        Assert.NotNull(customerTest.DeletedBy);
        Assert.NotNull(customerTest.DeletedOn);
        Assert.Equal(Environment.UserName, customerTest.DeletedBy);
    }
}
