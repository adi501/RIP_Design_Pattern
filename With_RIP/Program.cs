//Ref : https://www.c-sharpcorner.com/article/replace-conditional-statements-ifelse-or-switch-with-factory/

Console.WriteLine("Enter your skill set for job opening (like .net,java,php,reactjs)");
string knowledge = Console.ReadLine();
Console.WriteLine(SimpleFactory.Create(knowledge.ToLower()));
Console.ReadKey();

public class SimpleFactory
{
    private static Dictionary<string, string> skill = new Dictionary<string, string>();
    static SimpleFactory()
    {
        skill.Add(".net", "Requirement matches");
        skill.Add("java", "Requirement matches");
        skill.Add("php", "Requirement matches");
        skill.Add("reactjs", "Requirement matches");
    }
    public static string Create(string CustType)
    {
        // Design Pattern : RIP Pattern
        return skill[CustType];
    }
}