# EncryptColumn.Core
The source of the project is taken from [NuGet Package](https://www.nuget.org/packages/EntityFrameworkCore.EncryptColumn) , and because it's development did not continue, I decided to fix its problems for the new version of .NET Core and publish it here.
# What is EncryptColumn.Core ?
You can store your data in encrypted form in your database with this package.
# How to use?
Install ["EncryptColumn.Core"](https://www.nuget.org/packages/EncryptColumn.Core) package to your project.

Specify your encryption key in the constructor method of your DbContext class and create a instance from the encryption provider.
For example, you can use this [Encryption Key Generator](https://www.allkeysgenerator.com/Random/Security-Encryption-Key-Generator.aspx) to create an encrypted key.

```csharp
private readonly IEncryptionProvider _provider;
public ExampleDbContext()
{
    string key = "example_encrypt_key";
    this._provider = new GenerateEncryptionProvider(key);
}
```
Then specify that you will use an encryption provider in the "OnModelCreating" method.

```csharp
modelBuilder.UseEncryption(this._provider);
```
That's it! Now you can encrypt the parameters in the class you want by adding the "EncryptColumn" attribute.

```csharp
public class User
{
    public Guid ID { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    [EncryptColumn]
    public string Username { get; set; }
    [EncryptColumn]
    public string Password { get; set; }
}
```

