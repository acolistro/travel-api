using System;
using System.Collections.Generic;

namespace TravelBlog.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string DestinationId { get; set; }
    public virtual Destination Destination { get; set; }
  }
}