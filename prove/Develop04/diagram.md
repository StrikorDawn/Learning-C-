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

Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
===================================
        Breathing Activity
-----------------------------------
    - string _breathIn
    - string _breathOut
-----------------------------------
    + BreathDirection()
===================================

Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.
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

Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
===================================
        Listing Activity
-----------------------------------
    - List<string> _questions
-----------------------------------
    + AnswerQuestion()
    + DisplayTotalResponses()
===================================