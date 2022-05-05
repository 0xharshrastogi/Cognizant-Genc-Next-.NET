using System;
using System.Threading.Tasks;

static async Task<string> GetString()
{
    await Task.Delay(3000);

    return "Hello World";
}

static async void ProgramFunc()
{
    var result = await GetString();
    Console.WriteLine(result);
}

// -----------------------------------------------------------------------------------

static void GetCohertDetails(string name, int count, string mode, string track, string currModule)
{
    Console.WriteLine("And print the details in the format – It is [Cohort name] with [GenC count] GenCs undergoing training for [Track] thru [Mode]. The current module of training is [Current Module]");
}

GetCohertDetails(
    name: "FSE DOTNET",
    mode: "OBL",
    count: 20,
    track: ".NET",
    currModule: ".NET Advance"
);