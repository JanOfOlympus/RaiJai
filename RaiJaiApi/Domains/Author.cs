namespace RaiJaiApi.Domains
{
	public class Author(string name)
	{
		public string Name { get; private set; } = name;

		public static Author CreateAuthor(string name)
		{
			return new Author(name);
		}
	}
}
