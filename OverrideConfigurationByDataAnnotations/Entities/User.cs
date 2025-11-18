
using System.ComponentModel.DataAnnotations.Schema;

[Table("tblUsers")]

public class User
{
    // Primary key convention [Id, id , ID] , [{Class}Id]
    public int UserId { get; set; }
    public string Username { get; set; }
}
