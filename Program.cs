using ConsoleApp;

//Manual object creation
Engineering me = new Engineering();
me.name = "Joseph Obeng";
me.indexNumber = "1703199754";
me.level = 300;

//Simplified way
Engineering someone = new Engineering
{
    name = "Stanger Danger",
    indexNumber = "0502583166",
    level = 200
};

//Object creation using constructor with parameters
Engineering hello = new("Broski", "190123123", 400);

//Creating objects without parameters
Circle myCircle = new();
Triangle myTriangle = new();

//Calling methods
me.Welcome();
hello.Welcome();
someone.Welcome();
myCircle.Describe();
myTriangle.Describe();