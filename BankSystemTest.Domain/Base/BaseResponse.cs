using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Domain.Base
{
  public class BaseResponse<TSource>
  {
    public string Status { get; set; }
    public TSource Data { get; set; }
  }
}
