============================
        Event
----------------------------
 - string _title
 - string _description
 - DateTime _date
 - DateTime _time
 - Address _address
----------------------------
 + DisplayStandard()
 + DisplayFull()
 + DisplayShort()
============================
============================
        LectureEvent
----------------------------
 - int _capacity
 - string _speaker
 - bool _isFull
----------------------------
 + LectureEvent(speaker, capacity)
 + IsFull()
============================
============================
        ReceptionEvent
----------------------------
 - list<string> = _rsvps
----------------------------
 + RSVP(name, iscoming)
============================
============================
        OutdoorEvent
----------------------------
 - string _weatherType
----------------------------
 + GetWeather()
============================
============================
        Address
----------------------------
 - string _street
 - string _city
 - string _state
 - string _country
----------------------------
 + GetAddress
 + SetAddress
============================