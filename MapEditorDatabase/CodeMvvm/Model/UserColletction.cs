﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMvvm.Model
{
	public class UserColletction : ObservableCollection<User>
	{
		LinqToSQLClassesDataContext l_db;
	
		public UserColletction()
		{

		}
		public UserColletction GetData(LinqToSQLClassesDataContext db)
		{
			l_db = db;

			foreach (User T in l_db.Users)
			{
				Add(T);
				Console.WriteLine(T.Name);
			}
			return this;

		}
	}
}
