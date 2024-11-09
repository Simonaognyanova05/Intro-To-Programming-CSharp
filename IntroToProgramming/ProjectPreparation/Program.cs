Console.WriteLine("Enter the name of the architect:");
string architectName = Console.ReadLine()!;

Console.WriteLine("Enter the count of the projects:");
int projectsCount = int.Parse(Console.ReadLine()!);

int hoursPerProject = 3;
int timeNeeded = projectsCount * hoursPerProject;

Console.WriteLine($"The architect {architectName} will need {timeNeeded} hours to complete {projectsCount} project/s.");