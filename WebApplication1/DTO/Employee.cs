using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 员工信息表实体类
public class Employee
{
    /// <summary>
    ///  员工id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmployeeID { get; set; }

    /// <summary>
    ///  店铺id
    /// </summary>
    [Required]
    public int StoreID { get; set; }

    /// <summary>
    ///  员工姓名
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string? EmployeeName { get; set; }

    /// <summary>
    ///  员工性别
    /// </summary>
    [MaxLength(10)]
    public string? Gender { get; set; }

    /// <summary>
    ///  员工职位
    /// </summary>
    [MaxLength(50)]
    public string? Position { get; set; }

    /// <summary>
    ///  出生日期
    /// </summary>
    public DateTime? HireDate { get; set; }

    /// <summary>
    ///  店铺
    /// </summary>
    public Store? Store { get; set; }
  
}

