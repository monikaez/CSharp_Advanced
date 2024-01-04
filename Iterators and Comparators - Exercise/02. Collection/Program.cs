

using Collection;

List<string> items = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();

ListyIterator<string> listyIterator = new(items);

string command;

while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Move":
            Console.WriteLine(listyIterator.Move());
            break;
        case "HasNext":
            Console.WriteLine(listyIterator.HasNext());
            break;
        case "Print":
            try
            {
                listyIterator.Print();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "PrintAll":
            Console.WriteLine(string.Join(" ",listyIterator));
            break;
    }
}