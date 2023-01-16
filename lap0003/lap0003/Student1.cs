using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap0003
{
    internal class Student1
    {
        private string _name;
        private string _id;
        private int _birthYear;
        private int _hight;
        private double _grade;
        private string _major;

        public string name
        {
            get { return this._name; }
        }
        public string id
        {
            get { return this._id; }
        }
        public int birthyear
        {
            get { return this._birthYear; }
        }
        public int hight
        {
            get { return this._hight; }
        }
        public double grade
        {
            get { return this._grade; }
        }
        public string major
        {
            get { return this._major; }
        }
        //constructor
        public Student1(string name, string id, int birthYear, int hight, double grade, string major)
        {
            this._name = name;
            this._id = id;
            this._birthYear = birthYear;
            this._hight = hight;
            this._grade = grade;
            this._major = major;
        }
    }
}
