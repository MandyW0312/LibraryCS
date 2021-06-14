using System.Collections.Generic;

namespace LibraryCS
{
    public class Book
  {
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public string Genre { get; set; }
    
    public bool IsSeries { get; set; }
    
    public int YearPublished { get; set; }
    
    public bool Completed { get; set; }
    
    public int AuthorId { get; set; }
    
  }
}