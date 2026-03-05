using ConsoleApp1;
using NUnit.Framework;
namespace TestProject1;

public class sua
{
    [Test]
    public void suaTC()
    {
        class1service service = new class1service();
        Class1 class1 = new Class1
        {
            Id = 1,
            Name = "Test",
            Description = "Test Description",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = true
        };
        service.Them(class1);
        class1.Name = "test thu";
        var result = service.suaclass1(class1);
        Assert.That(result.Trim(), Is.EqualTo("Sửa thành công"));
    }

    [Test]
    public void test_suakotontai()
    {
        class1service class1 = new class1service();
        Class1 class2 = new Class1 
        {
            Id = 999,

        };
        var result = class1.suaclass1(class2);
        Assert.That(result, Is.EqualTo("Không tìm thấy sản phẩm cần sửa"));
    }
}
