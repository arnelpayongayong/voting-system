using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentVoting
{
    class Person
    {

        private string name;
        private string filepath;


        public void setName(string _name)
        {
            name = _name;
        }

        public void setFilePath(string _filePath)
        {
            filepath = _filePath;
        }

        public string getName()
        {
            return name;
        }

        public string getFilePath()
        {
            return filepath;
        }
    }
}
