using System;
using System.Collections.Generic;

namespace HelloMarten.Model
{
  public class BlogPost
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public IEnumerable<string> Tags { get; set; }
    public Dates ModifiedDates { get; set; }

    public class Dates
    {
      public DateTime CreatedDate { get; set; }
      public DateTime LastEditedDate { get; set; }
    }
  }
}
