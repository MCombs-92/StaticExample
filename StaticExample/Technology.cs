using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample {
	class Technology {

		public enum DifficultyType {
			Hardest = 1, Hard, Medium, Easy, Easiest
		};

		public string Name { get; set; }
		public DifficultyType Difficulty{ get; set; }
		public int Id { get; set; }

		public static int Counter { get; set; } = 0;

		private void Init() {
			Id = ++Counter;
			Difficulty = DifficultyType.Medium;
		}

		// Constructor
		public Technology() {
			Init();

		
		}

		//Cunstructor
		public Technology(string name) {
			Init();
			Name = name;
			
		}


		// Constructor
		public Technology(string name, DifficultyType difficulty) {
			Init();
			Name = name;
			Difficulty = difficulty;
		}
	}
}
