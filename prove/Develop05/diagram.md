===============================
            Menu
===============================

    - int _userInput
    - int endProgram
    - list<string> _menuList
    - int _score
-------------------------------
    + DisplayScore()
    + DisplayMenu()
    + MenuSelect()
    + CreateNewGoal()
    + ListGoal()
    + SaveGoal()
    + LoadGoal()
    + RecordEvent()

===============================
===============================
            Goal
===============================

    - list<string> _goals
    - list<bool> _goalsComplete
    - string _goalName
    - string _goalDescription
    - int _goalPoints
-------------------------------
    + CreateGoal()
    + SetName()
    + SetDescription()
    + SetPoints()
    + CompleteGoal()
    + AwardPoints()

===============================

===============================
        Simple Goal
===============================

    - bool _isComplete
-------------------------------
    + SimpleGoal()

===============================

===============================
        Eternal Goal
===============================

-------------------------------
    + EternalGoal()
===============================

===============================
        Checklist Goal
===============================

    - int _bonusPoints
    - int _numberTimes
    - int _timesCompleted

-------------------------------
    + ChecklistGoal()
    + IsComplete()

===============================

===============================
        File Handler
===============================

    - string _fileName
-------------------------------
    + FileHandler()
    + WriteFile()
    + ReadFile()
===============================
