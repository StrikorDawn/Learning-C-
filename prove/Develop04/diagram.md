===================================
            Navagation
-----------------------------------
    - int _userInput
    - int endProgram
    - list<string> _menuList
-----------------------------------
    + DisplayMenu()
    + MenuSelect()
    + StartBreathing()
    + StartReflection()
    + StartListing()
===================================

===================================
            Activity
-----------------------------------
    - int _sessionTime
    - string _startingText
    - string _description
    - string _readyPrompt
    - List<int> _countDown
    - string _endingPrompt
    - List<string> _animation
-----------------------------------
    + DisplayIntroText()
    + SetDescription()
    + DisplayDescription()
    + DisplayReadyPrompt()
    + StartCountDown()
    + DisplayEndPrompt()
    + RandomPrompt()
    + DisplayQuestion()
===================================

===================================
        Breathing Activity
-----------------------------------
    - string _breathIn
    - string _breathOut
-----------------------------------
    + BreathDirection()
===================================

===================================
        Reflection Activity
-----------------------------------
    - string _userInput
    - Random _random
    - List<string> _prompts
    - List<string> _questions
    - List<string> _responses
-----------------------------------
    + LoadingAnimation()
    + DisplayQuestion()
    
===================================

===================================
        Listing Activity
-----------------------------------
    - List<string> _questions
-----------------------------------
    + AnswerQuestion()
    + DisplayTotalResponses()
===================================