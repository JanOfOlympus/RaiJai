using RaiJaiApi.Domains;
using Path = System.IO.Path;

namespace RaiJaiApi
{
	public class Mutation
	{
		public async Task<Author> UploadProfilePicture(int authorId, IFile file, CancellationToken cancellationToken)
		{
			using var stream = File.Create(Path.Combine("C:\\work\\RaiJai", $"{authorId}.png"));
			await file.CopyToAsync(stream, cancellationToken);
			return new Author("Jon Skeet");
		}
	}
}
