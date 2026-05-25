using ConsoleApp;
Engineering me = new Engineering();
me.name = "Joseph Obeng";
me.indexNumber = "1703199754";
me.level = 300;

me.Welcome();

Engineering someone = new Engineering();
someone.name = "Stanger Danger";
someone.indexNumber = "0502583166";
someone.level = 200;

someone.Welcome();

Engineering newOne = new Engineering()
{
    name = "Bossu",
    indexNumber = "9703132754",
    level = 400,
};

newOne.Welcome();