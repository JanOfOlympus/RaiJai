using RaiJaiApi.Domains;

namespace RaiJaiApi.Queries
{
	public class Query
	{
		public Book GetBook() =>
			Book.CreateBook("Test Title", Author.CreateAuthor("Jan Jan"));
	}
}
