//
// InterfaceGreetingApp.cs
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
using System;

namespace GreetingApp
{
    class InterfaceGreetingApp
    {
        static string Greet(IGreetable obj)
        {
            return obj.Greet();
        }

        public static void App()
        {
            Console.Write("Enter a strangers first name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a strangers last name: ");
            string surname = Console.ReadLine();

            IGreetable person = new Person(name,
                                       surname);
            Console.WriteLine(string.Format("Here is a greeting for a stranger: {0}", Greet(person)));

            Console.Write("Enter your friends first name: ");
            name = Console.ReadLine();
            Console.Write("Enter your friends last name: ");
            surname = Console.ReadLine();

            IGreetable friend = new Friend(name,
                                       surname);
            Console.WriteLine(string.Format("Here is a greeting for your friend: {0}", Greet(friend)));
        }
    }
}
