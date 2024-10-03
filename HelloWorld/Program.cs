// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var name = "Isaac";
Console.WriteLine("Hello," + name);

for(var i = 0; i < name.length; i++) {
    Console.WriteLine(name[i]);
}

for(var i = name.length - 1; i >= 0; i--) {
    Console.WriteLine(name[i]);
}