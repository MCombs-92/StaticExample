using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample {


	class Program {
		static void Main(string[] args) {

			Technology Git = new Technology();
			Git.Name = "Git/GitHub";
			Git.Difficulty = Technology.DifficultyType.Medium;

			Technology SQL = new Technology();
			SQL.Name = "SQL Server";
			SQL.Difficulty = Technology.DifficultyType.Hard;

			Technology CSharp = new Technology("C Sharp Language");

			Technology EF = new Technology("EntityFramework", Technology.DifficultyType.Easiest);
		}
	}
}
