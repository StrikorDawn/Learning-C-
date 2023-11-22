// abstract class Goal
// {
//     List<string> _goals;
//     List<bool> _goalsComplete;
//     string _goalName;
//     string _goalDescription;
//     int _goalPoints;

//     public void CreateGoal()
//     {
//         Console.WriteLine("What is the name of your goal? ");
//         _goalName = SetName();
//         Console.WriteLine("What is a short description of it? ");
//         _goalDescription = SetDescription();
//         Console.WriteLine("How many points do you want to have associated with this goal? ");
//         _goalPoints = SetPoints();

//     }
//     public string SetName()
//     {

//         return Console.ReadLine();
//     }
//     public string SetDescription()
//     {
//         return Console.ReadLine();
//     }
//     public int SetPoints()
//     {
//         return int.Parse(Console.ReadLine()); 
//     }
//     public void AddToList()
//     {
//         string goal = $"{_goalName}|{_goalDescription}|{_goalPoints}";
//         _goals.Add(goal);
//         _goalsComplete.Add(false);
//     }
//     public bool CompleteGoal()
//     {
//         return true;
//     }
//     public int AwardPoints()
//     {
//         return _goalPoints;
//     }
// }