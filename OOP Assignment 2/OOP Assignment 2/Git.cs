// the git class ideally would hold git functions
using System.Collections.Generic;
public class Git
{
	public bool diff(string[] file1, string[] file2) // git diff takes two files and indicates the differences between
	{
		if (file1.Length == file2.Length) // if the length is the same
		{
			for (int i = 0; i < file1.Length; i++) // cycles through the files
			{
				if (file1[i] != file2[i]) // compares values at the same index
				{
					return false; // if it is not the same it returns false
				}
			}
			return true; // this means that all the values are the same and therefore the files are identical
		}
		return false; // if the length is different the files cannot be identical
	}
}

