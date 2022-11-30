using System.Collections;

IDictionary envVals = Environment.GetEnvironmentVariables();

foreach (DictionaryEntry envVal in envVals)
{
    Console.WriteLine($"{envVal.Key} : {envVal.Value}");
}
