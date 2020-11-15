//
// Types.cs
//
// Author:
//       Josh Santos <josh@omnidapps.com>
//
// Copyright (c) 2020 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE
namespace GreetingApp
{
    public interface IGreetable
    {
        string Greet();
    }

    public class Person : IGreetable
    {
        // TODO: Convert Person class to an abstract class, implement stranger and friend classes.
        // Properties and methods which are virtual should actually be abstract
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        protected string Name;
        protected string Surname;
        protected virtual string Greeting
        {
            get
            {
                return "Hello";
            }
        }

        public virtual string Greet()
        {
            return string.Format("{0}, {1}.", Greeting, this.String());
        }

        public virtual string String()
        {
            return string.Format("{0} {1}", this.Name, this.Surname);
        }
    }

    public class Friend : Person
    {
        public Friend(string name, string surname) : base(name, surname) {}

        protected override string Greeting
        {
            get
            {
                return "Hey";
            }
        }

        public override string Greet()
        {
            return string.Format("{0}, {1}!", Greeting, this.String());
        }
        public override string String()
        {
            return this.Name;
        }
    }
}
