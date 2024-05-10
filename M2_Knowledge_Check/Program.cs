Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Dogs>();


for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var dog = new Dogs();
	Console.WriteLine("Enter the value for color");
	dog.Color = Console.ReadLine();
    System.Console.WriteLine("Enter the value for breed");
    dog.Breed = Console.ReadLine();
	recordList.Add(dog);
}

// Print out the list of records using Console.WriteLine()

foreach (Dogs item in recordList)
{
    Console.WriteLine(item.Breed + ", " + item.Color);
}