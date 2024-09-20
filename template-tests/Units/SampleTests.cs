namespace MyTests.Unit;

using Xunit;
using FluentAssertions;

/// Import DataSample classes or objects to learn
/// about testing with FluentAssertions;
using MyTests.DataSamples;

/// <summary>
/// Simple class is demonstrating simple tests
/// with FluentAssertions.
/// </summary>
public class Simple
{
    [Fact]
    public void StringHasVowels()
    {
        string s = "github";

        s.Should().Contain("i");
        s.Should().Contain("u");
    }

    [Fact]
    public void IntegerIs_5()
    {
        int sum = 2 + 3;
        sum.Should().Be(5);
    }

    [Fact]
    public void IsValid_Person()
    {
        Person p = new("john doe", "john", 45);
        p.Should().BeOfType<Person>();
    }

    [Fact]
    public void IsValidInheritance_MyPerson()
    {
        MyPerson p = new("jane doe", "jane", 23);
        // Is of type MyPerson
        p.Should().BeOfType<MyPerson>();
        // Inherits Correctly From IPerson
        p.Should().BeAssignableTo<IPerson2>();
        // No Null Properties
        Type pType = typeof(MyPerson);
        foreach (var prop in pType.GetProperties())
        {
            var pName = pType.GetProperty(prop.Name);
            pName.Should().NotBeNull();
            pName?.GetValue(p).Should().NotBeNull();
        }
    }

    [Fact]
    public void IsValid_IPAddress()
    {
        string ip = "192.168.1.1";
        IPAddressHelper.IsValid(ip).Should().BeTrue();
    }

    [Fact]
    public void IsNotValid_IPAddress()
    {
        string ip = "192.168.651.1";
        IPAddressHelper.IsValid(ip).Should().BeFalse();
    }

    [Fact]
    public void IsNotSupported_IPAddress()
    {
        string ip = "127.0.0.1";
        IPAddressHelper.IsNotSupported(ip)
            .Should()
            .BeTrue();
    }

    [Fact]
    public void ValidNamingConvention_Rule()
    {
        string value = "ibo-001-exfiltration";
        value.Should().StartWith("ibo-").And.EndWith("exfiltration");
        value.Split('-').ToList()[1]
            .Should()
            .HaveLength(3)
            .And
            .StartWith("00");
    }
}