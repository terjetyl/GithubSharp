
using System;
using System.Collections.Generic;

namespace GithubSharp.Core.Models
{
	public class Tree
	{
		public string RepositoryName { get; set; }
		public string Sha { get; set; }
		public IList<BlobItem> BlobItems { get; set; }
	}
}