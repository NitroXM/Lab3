using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Author : BookProperty
{
    public Author(string value) : base(value, "Author", ConsoleColor.DarkMagenta) { }
}

