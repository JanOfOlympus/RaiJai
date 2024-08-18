namespace RaiJaiApi.Domains
{
	public class Book(string title, Author author)
	{
		public string Title { get; private set; } = title;

		public Author Author { get; private set; } = author;

		public static Book CreateBook(string title, Author author)
		{
			return new Book(title, author);
		}
	}
}
