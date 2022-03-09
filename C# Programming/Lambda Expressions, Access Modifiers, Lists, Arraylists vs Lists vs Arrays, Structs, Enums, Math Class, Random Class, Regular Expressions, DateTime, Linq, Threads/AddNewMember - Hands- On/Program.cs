using System;
using System.Collections.Generic;

namespace AddNewMember
{
    public class Club
    {

        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };

        public static void Main(string[] args)
        {
            var gold = memberInfo[1];
            var silver = memberInfo[2];
            var platinum = memberInfo[3];

            Console.WriteLine("Group Name :");
            string groupName = Console.ReadLine();

            Console.WriteLine("Member Name :");
            string memberName = Console.ReadLine();

            if (groupName.ToLower() == "Gold".ToLower()) AddAndDisplay(gold, memberName);
            else if (groupName.ToLower() == "Silver".ToLower()) AddAndDisplay(silver, memberName);
            else if (groupName.ToLower() == "Platinum".ToLower()) AddAndDisplay(platinum, memberName);

        }
        private static void AddAndDisplay(List<string> members, string memberName)
        {
            members.Add(memberName);
            foreach (string member in members) Console.WriteLine(member);
        }
    }
}
