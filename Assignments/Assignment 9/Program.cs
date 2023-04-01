// See https://aka.ms/new-console-template for more information
Console.WriteLine("Assignment 9!");

/*
    Skip and Take method. Create the pagination with it 
*/

List<bool> bools = new List<bool> { true, false, true, true, false };
// Will contain { true, false, true }
IEnumerable<bool> result = bools.Take(3);

List<bool> bools = new List<bool> { true, false, true, true, false };
// Will contain { true, true, false }
IEnumerable<bool> result = bools.Skip(2);


// Define class size and student number
int classSize = 10;
int studentNumber = 1;

// Get data from database
var data = dbContext.Customers.ToList();

// Implement pagination using Skip and Take methods
var studentdData = data.Skip((studentNumber - 1) * classSize).Take(classSize);

// Display the paged data
foreach (var item in studentData)
{
    Console.WriteLine(item.StudentName);
}
