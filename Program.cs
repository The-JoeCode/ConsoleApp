using ConsoleApp;

//Manual object creation
Engineering me = new Engineering();
me.name = "Joseph Obeng";
me.indexNumber = "1703199754";
me.level = 600;
// me.Level = 500; //This will trigger the validation in the setter
me.Welcome();

//Object creation using constructor with parameters
Engineering hello = new("Broski", "190123123", 300);
hello.Welcome();

//Simplified way
Engineering someone = new Engineering
{
    name = "Stanger Danger",
    indexNumber = "0502583166",
    level = 200
};
someone.Welcome();

Circle myCircle = new();
myCircle.Describe();

Triangle myTriangle = new();
myTriangle.Describe();