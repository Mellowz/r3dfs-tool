using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace BIN_Editor.r3d
{
	public class Folder
	{
		private Dictionary<string, Folder> _subfolders = new Dictionary<string,Folder>();
		private List<File> _files = new List<File>();

		private string _name;

		public Folder(string Name)
		{
			_name = Name;
		}

		/// <summary>
		/// Creates a new Folder, if a Folder of the same Name does not exists.
		/// If the Folder already exists, the 
		/// </summary>
		/// <param name="Name"></param>
		/// <returns></returns>
		public Folder CreateFolder(string Name)
		{
			// Create Entry if it does not exist
			if (!_subfolders.ContainsKey(Name))
				_subfolders.Add(Name, new Folder(Name));

			return _subfolders[Name];
		}


		/// <summary>
		/// Adds a File to this Folder
		/// </summary>
		/// <param name="file"></param>
		public void AddFile(File file)
		{
			_files.Add(file);
		}


		public File GetFile(string filename)
		{

			foreach (File file in _files)
			{
				if (file.Name == filename)
					return file;
			}

			throw new Exception("File " + filename + " not found");
		}

		/// <summary>
		/// Enter a Folder (for Navigation-Purposes only!)
		/// </summary>
		/// <param name="Name"></param>
		/// <returns></returns>
		public Folder this[string Name]
		{
			get
			{
				return _subfolders[Name];
			}
		}


		public List<File> Files
		{
			get
			{
				return _files;
			}
		}

		public List<Folder> Folders
		{
			get
			{
				return _subfolders.Values.ToList<Folder>();
			}
		}

		public string Name
		{
			get { return _name; }
		}

	}
}
