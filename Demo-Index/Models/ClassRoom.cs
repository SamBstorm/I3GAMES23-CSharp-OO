using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Index.Models
{
    internal class ClassRoom
    {
        private List<Student> _students = new List<Student>();
        public string Nom { get; set; }

        public Student this[int index]
        {
            get {
                if (index < 0 || index > _students.Count - 1) return null;
                return _students[index];
            }
            set {
                if (value is null) return; //Gestion d'exception
                if (index < 0 || index > _students.Count - 1) return;  //Gestion d'exception
                _students[index] = value;
            }
        }

        public Student this[string nom, string prenom]
        {
            get
            {
                for (int i = 0; i < _students.Count; i++)
                {
                    if (_students[i].Nom == nom && _students[i].Prenom == prenom) return _students[i];
                }
                return null;
            }
        }

        public int Add(Student newStudent)
        {
            if (newStudent is null) return -1;
            if (_students.Contains(newStudent)) return _students.IndexOf(newStudent);
            _students.Add(newStudent);
            return _students.Count-1;
        }
    }
}
