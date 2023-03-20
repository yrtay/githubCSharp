bool man = true;
if (man)
{
    System.Console.WriteLine("man");
}
bool woman = true;

if (woman)
{
    System.Console.WriteLine("woman");
}

if (!woman || man)
{
    System.Console.WriteLine("man");
}

if ( woman || !man)
{
    System.Console.WriteLine("woman");
}

if (!woman || !man)
{
    System.Console.WriteLine("woman");
}
else
{
    System.Console.WriteLine("neutral");
}

/*
string name  = "Bob";
if ( name == "Bob" && man )
{
    System.Console.WriteLine("這是男生Bob");
}
else if ( name =="Bob" && woman)
{
    System.Console.WriteLine("這是女生Bob");
}
else
{
    System.Console.WriteLine("這是中性Bob");
}
*/